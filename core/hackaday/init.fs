\ Stripped-down version of init from Embello system
\ With Hackaday frills

: init ( -- )     
  jtag-deinit     \ disable JTAG, we only need SWD
  72MHz           \ set clock 
  1000 systick-hz \ set ms ticker

  \ Embello Hello
  \ flash-kb . ." KB <g6s> " hwid hex.
 ." With many libraries from Embello Forth" cr 
 ." (http://embello.jeelabs.org/flib/)" cr 
  $10000 compiletoflash here -  flashvar-here compiletoram here - ." ram/flash: " . . ." free " cr cr
 
 ."   =<[ Hackaday Edition ]>=" 
 wrencher-12 
 ." ok." cr
;
