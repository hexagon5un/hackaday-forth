\ Top-level include file that adds everything necessary for the 
\ Hackaday edition of Mecrisp-Stellaris / Embello Forth

\ This includes a hard flash reset down to Mecrisp base ($5000)
\ Then replaces eraseflash so that it doesn't get overwritten
\ include hackaday/cornerstone.fs

\ eraseflash
compiletoflash

\ Embello versions of many of the mecrisp common libs
include embello/explore/1608-forth/flib/mecrisp/hexdump.fs
include embello/explore/1608-forth/flib/mecrisp/calltrace.fs
include embello/explore/1608-forth/flib/mecrisp/cond.fs
\ include embello/explore/1608-forth/flib/mecrisp/multi.fs
cornerstone <<mecrisp-common>>

\ Replicating a large part of embello/g6s/board.fs
4 constant io-ports  \ A..D  -- why not in pins64?
include embello/explore/1608-forth/flib/stm32f1/io.fs
include embello/explore/1608-forth/flib/pkg/pins48.fs
include embello/explore/1608-forth/flib/stm32f1/hal.fs
\ include embello/explore/1608-forth/flib/stm32f1/spi.fs
\ include embello/explore/1608-forth/flib/stm32f1/timer.fs
\ include embello/explore/1608-forth/flib/stm32f1/pwm.fs
\ include embello/explore/1608-forth/flib/stm32f1/adc.fs
\ include embello/explore/1608-forth/flib/stm32f1/rtc.fs
cornerstone <<embello-board>>

include hackaday/multi.fs
include hackaday/LED.fs
include hackaday/prompt.fs
include hackaday/utilities.fs
include hackaday/wrencher.fs
include hackaday/init.fs
cornerstone <<hackaday>>

compiletoram

