
\ PB9  - button to VCC, sense with internal pulldown
\ PC15 - button to VCC, sense with internal pulldown

: button.init ( -- )
	imode-pull PB9 io-mode! 
	PB9 ioc! ( pulldown )
	imode-pull pc15 io-mode!
	pc15 ioc!
	omode-pp pc14 io-mode!
	pc14 ios!
;

: button.report? ( -- ) PB9 io@ ; \ the report output button
: button.next? ( -- ) PC15 io@ ; \ test "next" button

( Test functions )
: b begin button.next? if led.on else led.off then key? until ;

: button.test ( -- )
  begin 
  	button.report? if ." pressed" cr led.on 
	else led.off then 
	100 ms 
  key? until ;


