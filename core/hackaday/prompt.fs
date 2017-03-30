: printstack ( -- )
	depth dup if   \ only print if anything there
		begin  
		dup pick .  \ pick @ depth b/c just added counter on stack 
		1- dup 0= until  
	then drop 
;

: tab 9 emit ;

\ Prettier version of .s
: .s 	( -- )
	[char] [ emit space printstack [char] ] emit 
;

\ Start up new interpreter loop with stack printing
\ When this loop fails, you'll be back to normal prompt.
: prompt-stack ( -- )
	begin query interpret tab .s space ." ok." cr again 
;

\ this turns stack printing on "permanently"
\ run in compiletoram mode and will go away on next reset
\ run in compiletoflash mode and it will be permanent.
: print.stack ['] prompt-stack hook-quit !  quit ; 



