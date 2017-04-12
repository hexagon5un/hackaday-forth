\ Simple framework for blinking the onboard LED 

\ define the pin.  
\ Change if you have different hardware -- the rest should work
PC13 constant led.pin ( for blue pill boards )
\ PA1 constant led.pin ( for hytiny boards )

\ set output mode, push-pull driver
: led.init   omode-pp led.pin io-mode! ;
: led.on     led.pin ioc! ; \ LED lights up when port low
: led.off    led.pin ios! ;
: led.toggle led.pin iox! ;


