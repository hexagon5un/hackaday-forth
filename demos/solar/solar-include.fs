( clear to Hackaday Version as base )
<<hackaday-extras>>

( Solar Cell Reader Code )
compiletoflash 

include led.fs
include button.fs
include adc.fs
include tasks.fs

: solar.init 
	led.init
	button.init
	adc.init
	pb0 8 adc.pin-setup
	pb1 9 adc.pin-setup
	multitask
	blink&
	5 ms
	sample& 
	5 ms
	next&
	5 ms
;

: init init solar.init ;

cornerstone <<<solar>>>
compiletoram
reset
( ... and will run. )


