\ include adc-registers.fs

\   PA0..7 => 0..7, PB0..1 => 8..9, PC0..5 => 10..15

\ Hookup
\ PB0 - AIN8 is connected to panel voltage
\ PB1 - AIN9 is connected to current sense resistor

: adc.rcc-enable  9 bit RCC-APB2ENR bis! ; \ set ADC1EN
: adc.set-adon    0 bit ADC1-CR2    bis! ; \ set ADON to enable ADC
: adc.set-cal-bit 2 bit ADC1-CR2    bis! ;

: adc.cal-done?    2 bit ADC1-CR2    bit@ 0= ;
: adc.isdone?      1 bit ADC1-SR     bit@ ;

\ perform an ADC calibration cycle
: adc.cal 	( -- )  
		adc.set-cal-bit begin adc.cal-done? until ;

: adc.set-channel ( AIN# -- ) 
		ADC1-SQR3 ! ; 

: adc.once 	( -- u )  \ read ADC value once
		adc.set-adon
		begin adc.isdone? until  
		ADC1-DR @ ; 

: adc.init 	( -- ) 
		adc.rcc-enable adc.set-adon 
		5 us adc.cal  		\ calibration needs delay 
		adc.once drop ; 	\ throw away first conversion

: adc.set-sample-rate 	( mode ain# -- ) 
			dup 10 < 
			if 3 * lshift adc1-smpr2 ( AIN0-9 ) 
			else 10 - 3 * lshift adc1-smpr1 ( AIN10-17 )
			then bis! ;

( Note: sample rate cleared by adc.init.  Call this afterwards. )
: adc.pin-setup   	( pin ain# -- ) 
  %111 swap adc.set-sample-rate \ set slowest sample rate
  imode-adc swap io-mode! \ set pin to adc/input mode
;

