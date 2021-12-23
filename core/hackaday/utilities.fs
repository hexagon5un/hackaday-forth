
\ .s for the return stack 
: .r cr base @ hex
	rdepth dup if
	begin
		dup rpick . 
		1- dup 0= until
	then drop base ! 
;

\ list is a shorter version of words: from mecrisp/common
: list ( -- )
	cr dictionarystart 
	begin dup 6 + ctype space dictionarynext until drop
;

\ loop a function n times from the command line
: loops ( n -- ) ' swap 0 ?do dup execute loop drop ;
\ usage: if you've got a word named "foo": 10 loops foo 

\ quick print variable
: ? @ . ; 
\ print true / false
: tf if ." true" else ." false" then ;
\ incremements variable in memory, stores.  like C's ++
: ++ 1 swap +! ;

: _nibble bl hold # # # # ;
: _byte16 # # bl hold ;
: bin. 0 binary <# [char] ] hold 8 0 do _nibble loop bl hold [char] [ hold #> type space decimal ;
: hex. ( 32-bit number ) 0 hex <# _byte16 _byte16 _byte16 # # #> type space decimal ;

\ free memory / flash space: adapted from Embello libs

: flashfree compiletoram? $10000 compiletoflash here - swap if compiletoram then ; 
: ramfree  compiletoram? not flashvar-here compiletoram here - swap if compiletoflash then ; 

