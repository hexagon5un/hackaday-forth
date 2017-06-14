## Get Stuff

To flash the initial Forth system onto your chip, you'll need a cheapo (or heck, official) STLink-compatible programmer.  They're available from all the usual Chinese retailers for a few bucks in whatever your local currency.  Pick up two -- they're a good deal and you can experiment with repurposing one into a more [sophisticated programmer](https://github.com/blacksphere/blackmagic/wiki) later.

Then get the software: Texane's [stlink](https://github.com/texane/stlink).  There are versions for Windows, Mac, and every Linux distro that counts.  We'll only need the simple flash upload capabilities, but it will also provide you with a GDB server if you want one for debugging in compiled languages, like C.

## Connect

Most "blue pill" style boards come with four pins pre-soldered to the requisite programming pins: GND, SWCLK, SWDIO, and 3V3.  These pins are similarly labelled on the ST-Link v2 programmer.  Connect all four.

You might as well wire up the serial connections now.  Pin A9 is RX and pin A10 is TX, connect these to your interface's TX and RX lines respectively, and don't forget that they need to share a common ground.  

## Flash Chips

This is easy.  `st-flash erase` and then `st-flash write mecrisp-stellaris-hackaday-edition.bin 0x8000000`.  (Or whichever ROM you want to load, see below.)  The "0x8000000" is the memory location to which the flash ROM is mapped inside the chip.  Do not change this.

In the erase phase, you should see confirmation of the type of chip you use and its memory layout: 
<pre>
Device connected is: F1 Medium-density device, id 0x20036410
SRAM size: 0x5000 bytes (20 KiB), Flash: 0x10000 bytes (64 KiB) in pages of 1024 bytes
</pre>

In the flash phase, you should additionally see something like this:
<pre>
 Attempting to write 33792 (0x8400) bytes to stm32 address: 134217728 (0x8000000)
 Flash page at addr: 0x08008000 erased
 Finished erasing 33 pages of 1024 (0x400) bytes
 Starting Flash write for VL/F0/F3 core id
 Successfully loaded flash loader in sram
 32/33 pages written
 Starting verification of write complete
 Flash written and verified! jolly good!
</pre>

Anything else is a nearly sure sign of crossed wires.  Check again.

## Get to Work

Connect to the chip with a serial terminal program.  Baud rate is 115,200 and Mecrisp expects and sends linefeeds as the end-of-line character.  

* `folie` is JeeLab's [Forth-specific terminal program](https://github.com/jeelabs/folie).  The _big_ difference between this and the other alternatives is that it has scrollback -- you can re-enter (and edit) the last command by pressing the up-arrow.  It also supports uploading of whole files through a simple "include" syntax.  

* `picocom -b 115200 /dev/ttyACM0 --imap lfcrlf` 

* `python -m serial.tools.miniterm -eol LF /dev/ttyACM0 115200` if you have Python's "pyserial" module installed.  

* On the Python topic, there's a "forth explorer" in the tools directory.

* Whatever else.  It's a serial connection.  You can figure it out.

If you hit return and see `ok.` then everything's ok.  If not, try the chip's reset button.  If that doesn't work, try pulling out the SWCLK and SWDIO pins from the programmer -- I have one that seems to randomly assert one of those two signals which keeps the chip forever in bootloader mode.  That's not cool.  

Once you're in, type `reset` to check the Mecrisp version and see the welcome message. Type `list` to see the full list of predefined words available.  Type `led.on 100 ms led.off` and blink the onboard LED.  Success! 

## Which ROMs For You?

I've included a few ROM images, all of which are current as of March 2017.  

* `mecrisp-stellaris-stm32f103-ra.bin` is the base Mecrisp Stellaris system.  You can consider this the bare minimum, although compared with many Forth systems it's already quite deluxe.  I've chosen the RA (register allocation optimization) version because it's fast.  The tradeoff is a little more flash space, but on chips like the STM32F103, where you've got 64K to 128K, flash memory is essentially limitless.  

* `mecrisp-stellaris-hackaday-edition.bin` is a good basis for getting started.  I've added some useful tools, multitasking, GPIO support, and some other frills from the [Mecrisp-Stellaris/common](https://github.com/jeelabs/mecrisp-stellaris/tree/master/common) directory as well as JeeLab's [embello libraries](https://github.com/jeelabs/embello/tree/master/explore/1608-forth).  If you want to poke around in the code there, don't forget to run `git submodule update --init --recursive` to pull down the latest versions.

Anyway, everything is extensible and layered.  If you've loaded the Hackaday version, and want to drop down to the bare Mecrisp Stellaris build, you can type `eraseflash` and you're set.  Other waypoints / cornerstones in the flash memory are delimited with `<<<angle-brackets>>>` and typing the relevant name will clear flash down to that point.




