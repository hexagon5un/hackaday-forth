\ These incorporate scaling factors that I measured
\ Could be derived, but power supply voltage and resistor tolerance, meh.
\ current is in nanoamps, voltage in millivolts

: read-V  8 adc.set-channel adc.once 3778 10000 */ ; \ ain8
: read-I  9 adc.set-channel adc.once 3668 1000 */ ; 

( Take 8 samples of each, for debugging )
: read-both 8 0 do read-V . loop 8 0 do read-I . loop ;
: readloop begin read-both cr 100 ms key? until ;

: sum-both 0 10 0 do read-V + loop 0 10 0 do read-I + loop ;
: comma [char] , emit ;
: print-reading swap . comma . cr ;
: sumloop begin sum-both print-reading 20 ms key? until ;

( this should be a background task )
: sample begin button.report? led.blink 50 ms until 
	 begin button.report? while sum-both print-reading 20 ms led.on repeat led.off ;



