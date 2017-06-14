Here you'll find all the code (and more!) to build up a very respectable Forth system.


## Building the Hackaday Edition

1. Update the submodules: `git submodule update --init --recursive`
2. Flash in a stock Mecrisp-Stellaris ROM: `st-flash erase && st-flash write ../ROMS/mecrisp-stellaris-stm32f103-ra.bin 0x8000000`
3. Use folie to connect to the chip and press the reset button once or twice.  See the welcome message.
4. This bit is folie-specific: type `include hackaday-includes.fs` and it will load all of the files and sub-files that comprise the system.  Otherwise, you can read through the includes file and upload them one by one yourself.
5. Hit or type `reset` and you should see the Jolly Wrencher.  You're on your way!

<pre>
Mecrisp-Stellaris RA 2.3.6 for STM32F103 by Matthias Koch
plus a lot of code from the Embello Forth libs by [jcw]
(http://embello.jeelabs.org/flib/)
ram/flash: 19336 31744 free 

  =<[ Hackaday Edition ]>=
   `[-.               ,-]'
,  ,'  |             |  `.  ,
\'-    `.    ___    ,'    -'|
 `....   I>-'   `-L   ,..,-'
      `.|'         `|,'
       .' _,_   _._ '.
       | |  _| `.  | |
       | `.'  ,  `.' |
      ,-`    |'|    /-.
 ,---'  `|.       , '  `---.
/,._   ,' \.,\_,,,' -.    ..\
'   \  /             \  /'  '
   /.,'               `.:.   

ok.
</pre>



