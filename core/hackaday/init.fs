\ Stripped-down version of init from Embello system
\ With Hackaday frills

: init ( -- )     
  jtag-deinit     \ disable JTAG, we only need SWD
  72MHz           \ set clock 
  1000 systick-hz \ set ms ticker

  \ Embello Hello
 ." plus a lot of code from the Embello Forth libs by [jcw]" cr 
 ." (http://embello.jeelabs.org/flib/)" cr 
  $10000 compiletoflash here -  flashvar-here 
  compiletoram here - ." ram/flash: " . . ." free " cr cr
 
 ."   =<[ Hackaday Edition ]>=" 
 \ requires wrencher.fs
 wrencher-12 

 \ requires LED.fs
 led.init
 led.off

 ." ok." cr
;
