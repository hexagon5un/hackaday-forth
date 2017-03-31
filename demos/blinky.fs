\ Embello libs provide simple GPIO functionality
\  see core/embello/explore/1608-forth/flib/stm32f1/io.fs
\ Hackaday version provides simple LED functions/drivers/init
\  see core/hackaday/LED.fs

\ this means that blinking led is as simple as:
\ led.on 100 ms led.off 
\ why not a function?
: led.simpleblink led.on 100 ms led.off 200 ms ;

\ I'm sure we'll want to vary the blinking speed later on
200  variable led.blink-time 
: led.blink       led.blink-time @ dup led.on ms led.off ms ;
: led.blinkloop   ." blinking...press return to stop " cr
  	    	  begin led.blink key? until ;

\ The begin ... key? until  loop is very useful when debugging


