\ these definitions should always stay loaded
\ Modified from Embello Forth g6s board
\ Changed to save memory pages

$5000 eraseflashfrom  \ need to start off with a clean Mecrisp image
compiletoflash

: cornerstone ( "name" -- )  \ define a flash memory cornerstone
  \ assume 2048-byte pages, in case this is an F103 w/ 256K flash or more
  \ it's a bit wasteful on 64..128K chips, but will work fine there as well
  \ to avoid the waste on small chips, change 2047 to 1023 in both lines below
  <builds   begin here 1023 and while 0 h, repeat
  does> cr  begin dup  1023 and while 2+   repeat  cr eraseflashfrom ;

( always end: ) here hex.
cornerstone eraseflash
compiletoram


