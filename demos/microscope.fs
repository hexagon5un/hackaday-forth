compiletoflash

( Set up with PB3 directly connected to PWR test point )
( Needs longish press to activate )
PB3 constant pin.POWER

( KEY test point pulls resistors down to connect to pb4-pb8 )
( Pull down with different resistances to trigger keys )
( Resistors: 0, 15K, 33K, 47K, 68K )
PB4 constant pin.OK
PB5 constant pin.MODE
PB6 constant pin.MENU
PB7 constant pin.RIGHT
PB8 constant pin.LEFT

: power-init omode-pp pin.POWER io-mode! ;
( works only b/c 5 pins in a row... )
: key-init   5 0 do omode-od pin.OK i + dup ios! io-mode! loop ;
( add these to global init ) 
: init       init power-init key-init ;

( scaffolding to keep track of modes )
0 constant  mode.video
1 constant  mode.photo
2 constant  mode.display

0 variable  current.mode
: wrap-mode dup mode.display > if drop mode.video then ;
: next-mode current.mode @ 1+ wrap-mode current.mode ! ;

( for pin.POWER )
: long-press dup ios! 1500 ms ioc! ;
: power      pin.POWER long-press mode.video current.mode ! ;

( read power status off of pullup on key pin )
( can leave in open-drain mode as long as not driven )
: is.on? pin.OK io@ ;
: on     is.on? not if power 2000 ms then ;
: off    is.on? if power then ;

( for normal buttons ) 
200 variable pause.time
: ppause     pause.time @ ms ;
: press      dup ioc! ppause ios! ppause ;

: ok    pin.ok press ;
: mode  pin.mode press next-mode ;
: menu  pin.menu press ;
: right pin.right press ;
: left  pin.left press ;

: play  ok ;
: next  left ; ( totally counterintuitive! )
: down  left ; 
: prev  right ;
: 2mode mode mode ;
: 2menu menu menu ;

( turning light on/off is global option -- any mode )
: light  on 2menu 8 0 do right loop ok right ok menu ;

( mode-based navigation -- with auto turn-on )
: is-mode? dup current.mode @ = ;
: go-mode  on begin is-mode? not while mode repeat drop ;
: display  mode.display go-mode ;
: photo    mode.photo   go-mode ;
: video    mode.video   go-mode ;

( deleting image needs display mode )
: delete    display menu ok ok right ok 2menu ;
( changing preview time needs photo mode )
: preview   photo menu right ok right ok 2menu ; \ toggle preview in photo mode
( can only shoot photo in photo mode )
: shoot     photo ok 500 ms ;
: timelapse 0 begin shoot 1+ key? until . space ." frames shot" cr ;

( usage: 10 shots, 50 second vid )
: shots  ( n -- )          0 ?do shoot loop ;
: second ( ms -- seconds ) 1000 * ;
: vid    ( ms -- )         video ok ms ok ;

( on, shoot, off )
: one-shot    shoot off ; 

cornerstone <<microscope>>
compiletoram

