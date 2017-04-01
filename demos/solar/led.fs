
: led.blink 	led.on 50 ms led.off ;
: led.blinkloop ( n -- ) 
		0 ?do led.blink 200 ms loop ;

