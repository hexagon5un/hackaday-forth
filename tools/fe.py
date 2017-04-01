import os
import re
import readline
import select
import serial
import signal
import sys
import time
import termios
import tty

if len(sys.argv) == 1:
    print "Usage: %s <port>" % sys.argv[0]
    sys.exit(0)

device = sys.argv[1]

# The list of possible baud rates is:
# 110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 230400, 460800, 921600
ser = serial.Serial(device, 115200)
#ser = serial.Serial(device, 460800)

completionSound = "./beep.wav"
errorSound = "./ascending-2tone.wav"
# Note: the logic here is not particularly robust given that it's possible to
# drastically change the Forth parser in pretty arbitrary way. Disable this
# when doing anything perverse like defining new words with " in the name,
# or something that affects parsing in a substantial way.
removePossibleJunk = True

def removeComments(line):
    if not removePossibleJunk:
        return line
    output = ''
    state = 0
    i = iter(line + ' ')
    inComment = False
    try:
        curWord = ""
        quoted = 0
        while True:
            ch = i.next()
            if ch == ' ':
                if curWord == '': # redundant space
                    continue
                if inComment:
                    if curWord == ')':
                        inComment = False
                    curWord = ''
                    continue
                if quoted == 0 and curWord == '(': # comment
                    inComment = True
                    continue
                if quoted == 0 and curWord == '\\': # comment
                    break
                output += curWord
                output += ch
                if quoted > 0:
                    quoted -= 1
                elif curWord == "[']" or curWord == "'": # bloody ticks
                    quoted = 1
                elif curWord in ['."', 's"', 'c"']: # start of string constant
                    while True:
                        try:
                            ch = i.next()
                        except StopIteration:
                            raise ValueError, "Unterminated string constant in: %s" % line
                        output += ch
                        if ch == '"':
                            break
                curWord = ''
            else:
                curWord += ch
    except StopIteration:
        if inComment:
            raise ValueError, "Unterminated (comment) in: %s" % line
        if curWord != '' and not inComment:
            output += curWord
    return output.rstrip()
    
def checkRemovedComments(line, expected):
    actual = removeComments(line)
    if actual != expected:
        raise AssertionError, "Expected: %s, got %s while removing comments from %s" % (repr(expected), repr(actual), repr(line))
def checkException(line, expected):
    try:
        actual = removeComments(line)
        raise AssertionError, "Expected: exception %s, got %s while removing comments from %s" % (repr(expected), repr(actual), repr(line))
    except ValueError as e:
        actual = str(e)
        if actual != expected:
            raise AssertionError, "Expected: exception %s, got exception %s while removing comments from %s" % (repr(expected), repr(actual), repr(line))
        

# Some quick and dirty unit test :)
checkRemovedComments("blabla\\something", "blabla\\something")
checkRemovedComments("blabla \\ something", "blabla")
checkRemovedComments("blabla \\ some \\ thing", "blabla")
#checkRemovedComments("blabla \"foo(ba\\r)\"", "blabla \"foo(ba\\r)\"")
checkRemovedComments("blabla s\" foo(ba\\r)\"", "blabla s\" foo(ba\\r)\"")
checkRemovedComments("blabla x\" foo(ba\\r)\"", "blabla x\" foo(ba\\r)\"")
checkRemovedComments("bla(something)bla", "bla(something)bla")
checkRemovedComments("bla ( something ) bla", "bla bla")
checkRemovedComments("bla  (something)bla", "bla (something)bla")
checkRemovedComments("bla  (something)", "bla (something)")
checkRemovedComments("bla   bla", "bla bla")
checkRemovedComments(" bla   bla", "bla bla")
checkRemovedComments(" bla(", "bla(") # ( is a part of a word, not an error
checkRemovedComments("bla ['] s\" foo", "bla ['] s\" foo") # s\" preceded by the bloody tick
checkRemovedComments("bla ' s\" foo", "bla ' s\" foo") # s\" preceded by another bloody tick
checkException("bla s\" foo", "Unterminated string constant in: bla s\" foo")
checkException("bla c\" foo", "Unterminated string constant in: bla c\" foo")
checkException("bla .\" foo", "Unterminated string constant in: bla .\" foo")
checkException("bla (", "Unterminated (comment) in: bla (")

def playSound(fname):
    if fname is not None:
        os.system("play -q '%s'" % fname)
def playCompletionSound():
    playSound(completionSound)
def playErrorSound():
    playSound(errorSound)

def wait_echo(ch):
    it = time.time()
    ser.timeout = 0.1
    fb = ''
    while True:
        fb += ser.read(1)
        if len(fb) == len(ch):
            if fb == ch:
                break
            raise IOError, "Not echoed properly: '%s' vs '%s'" % (repr(ch), repr(fb))
        if time.time() - it > 1:
            raise IOError, "Timeout waiting for echo for '%s'" % repr(ch)

def send(ln):
    it = time.time()
    for i in range(0, len(ln), 5):
        ch = ln[i : i + 5]
        ser.write(ch)
        wait_echo(ch)
    ser.write('\r')
    # print "%s" % ln
    
def recv(stop_on_ok, just_in_case):
    resp = ''
    had_ok = False
    got_line = False
    start_time = time.time()
    warnings = []
    while True:
        ser.timeout = 0.1 if had_ok or stop_on_ok or just_in_case else 1
        try:
            inp = ser.read()
        except serial.SerialException as ex:
            if ' (4,' in ex.args[0]: # Interrupted system call
                continue
            raise IOError, "Serial error: %s" % str(ex)
        if inp == '' and not stop_on_ok and got_line:
            break
        if inp == '' and stop_on_ok and time.time() > start_time + 5:
            raise IOError, "Serial got stuck?"
        got_line = True
        had_ok = False
        resp += inp
        eol = resp.find('\n')
        if eol != -1:
            msg = resp[:eol]
            resp = resp[eol + 1:]
            print "%s" % msg
            if stop_on_ok:
                if 'not found.' in msg:
                    raise IOError, "'not found' returned by the compiler"
                if 'Stack underflow' in msg:
                    raise IOError, "'Stack underflow' returned by the compiler"
                if msg.find('Redefine ') in [0, 1]:
                    warnings.append("Some keyword may have been redefined?")
            if 'Mecrisp' in msg and re.search("Mecrisp-Stellaris .* by Matthias Koch", msg): # reset detection
                warnings.append("reset detected")
                break
            if msg.find('ok.') != -1:
                had_ok = True
                if stop_on_ok:
                    break
    if resp != '':
        print resp
    if stop_on_ok:
        return warnings
    else:
        return got_line

histfile = os.path.expanduser('~/.mecrisp-stellaris-history')
if os.path.exists(histfile):
    readline.read_history_file(histfile)
readline.parse_and_bind('\C-r: "!s\r"')
readline.parse_and_bind('\C-t: "!t\r"')

print "Forth Explorer for Mecrisp-Stellaris"
print "Special commands:"
print "Ctrl+D          quit FE (only in Smart Terminal mode)"
print "!s[ <file>]     upload a file (defaults to last file; also: Ctrl+R)"
print "!t              switch to a dumb TTY mode (also: Ctrl+T)"
fn = None
try:
    recv(False, True)
except KeyboardInterrupt as e:
    pass
while True:
    try:
        def do_recv(signum, frame):
            if recv(False, True):
                readline.redisplay()
            signal.alarm(1)
        signal.signal(signal.SIGALRM, do_recv)
        signal.alarm(1)
        cmd = raw_input("> ")
        signal.alarm(0)
    except KeyboardInterrupt as e:
        print "^C"
        continue
    except EOFError as e:
        break        
    try:
        if cmd == '!t':
            print "Dumb terminal mode, press Ctrl-X to exit"
            fd = sys.stdin.fileno()
            old = termios.tcgetattr(fd)
            tty.setcbreak(fd)
            attrs = termios.tcgetattr(fd)
            # Block Ctrl-C and Ctrl-Z
            attrs[6][termios.VINTR] = '\x00'
            attrs[6][termios.VSUSP] = '\x00'
            termios.tcsetattr(fd, termios.TCSADRAIN, attrs)
            try:
                while True:
                    try:
                        r, w, e = select.select([fd, ser.fd], [], [fd], 0.1)
                    except select.error as ex:
                        if ex.args[0] == 4: # EINTR
                            continue
                        print "Select error: ", ex.args
                        continue
                    if not r and not e:
                        continue
                    if fd in r:
                        ch = sys.stdin.read(1)
                        if ch == '\x18':
                            break
                        ser.write(ch)
                    if ser.fd in r:
                        ch = ser.read(1)
                        sys.stdout.write(ch)
                        sys.stdout.flush()
                    if e:
                        print "Exceptional condition detected on:", e
            finally:
                termios.tcsetattr(fd, termios.TCSADRAIN, old)
            print "Terminal mode stopped."
            continue
        if cmd == '!s' or cmd[0:3] == '!s ':
            if cmd != '!s':
                fn = cmd[3:].strip()
            else:
                if fn is None:
                    print "No file specified."
                    continue
            try:
                warnings = []
                f = open(fn, 'r')
                line_no = 1
                for ln in f.readlines():
                    ln = removeComments(ln.strip().replace("\t", " "))
                    if ln != "":
                        send(ln)
                        for w in recv(True, False):
                            warnings.append("%s:%d Warning: %s" % (fn, line_no, w))
                    line_no += 1
                f.close()
                for w in warnings:
                    print w
                playCompletionSound()
            except IOError as e:
                print str(e)
                playErrorSound()
            except ValueError as e:
                print str(e)
                playErrorSound()
            except KeyboardInterrupt as e:
                print "^C"
        else:
            try:
                recv(False, True)
                send(cmd)
                recv(False, False)
            except IOError as e:
                print str(e)
    except KeyboardInterrupt as e:
        continue
print
readline.write_history_file(histfile)
