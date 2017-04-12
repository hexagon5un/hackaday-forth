\ cooperative multitasking
\ adapted from mecrisp-stellaris 2.2.1a (GPL3)

\ configuration:
\ 64 cells constant stackspace \ 64 stack elements for every task (both stacks)
64 cells variable stackspace

\ Internal stucture of task memory:
\  0: Pointer to next task
\  4: Task currently active ?
\  8: Saved stack pointer
\ 12: Handler for Catch/Throw
\  Parameter stack space
\  Return    stack space

false 0 true flashvar-here 4 cells - 4 nvariable boot-task \ Boot task is active, without handler and has no extra stackspace.
boot-task boot-task ! \ For compilation into RAM only

boot-task variable up \ User Pointer
: next-task  ( -- task )    up @ inline ;
: task-state ( -- state )   up @ 1 cells + inline ;
: save-task  ( -- save )    up @ 2 cells + inline ;
: handler    ( -- handler ) up @ 3 cells + inline ;

: (pause) ( stacks fly around )
    [ $B430 h, ]        \ push { r4  r5 } to save I and I'
    rp@ sp@ save-task !  \ save return stack and stack pointer
    begin
      next-task @ up !     \ switch to next running task
    task-state @ until
    save-task @ sp! rp!  \ restore pointers
    unloop ;              \ pop { r4  r5 } to restore the loop registers

: wake ( task -- ) 1 cells +  true swap ! ; \ Wake a random task (IRQ safe)
: idle ( task -- ) 1 cells + false swap ! ;  \ Idle a random task (IRQ safe)

\ -------------------------------------------------------
\  Round-robin list task handling - do not use in IRQ !
\ -------------------------------------------------------

: stop ( -- ) false task-state ! pause ; \ Stop current task
: multitask  ( -- ) ['] (pause) hook-pause ! ;
: singletask ( -- ) [']  nop    hook-pause ! ;

\ Checks if a task is currently inside of round-robin list (do not use in IRQ)
: task-in-list? ( task -- ? )
  next-task
  begin
    ( Task-Address )
    2dup = if 2drop true exit then
    @ dup next-task = \ Stop when end of circular list is reached
  until
  2drop false ;

: previous ( task -- addr-of-task-before )
  \ Find the task that has the desired one in its next field
  >r next-task begin dup @ r@ <> while @ repeat rdrop ;

: insert ( task -- ) \ Insert a task into the round-robin list
  dup task-in-list?  \ Is the desired task currently linked into ?
  if drop else next-task @ over ! next-task ! then ;

: remove ( task -- ) \ Remove a task from the round-robin list
  dup task-in-list?  \ Is the desired task currently linked into ?
  if dup @ ( task next )
     swap previous ( next previous ) !
  else drop then ;

\ -----------------------------------------
\ Create a new task - do not use in IRQ !
\ -----------------------------------------

: task: ( "name" -- )  stackspace @ cell+ 2*  4 cells +  buffer: ;

: preparetask ( task continue -- )
  swap >r ( continue R: task )

    \ true  r@ 1 cells + ! \ Currently running
      false r@ 3 cells + ! \ No handler

    r@ 4 cells + stackspace @ + ( continue start-of-pstack )
      dup   r@ 2 cells + ! \ Start of parameter stack

    dup stackspace @ + ( continue start-of-pstack start-of-rstack )
    tuck      ( continue start-of-rstack start-of-pstack start-of-rstack )
    2 cells - ( continue start-of-rstack start-of-pstack start-of-rstack* )
\ Adjust for saved loop index and limit
    swap  !   ( continue start-of-rstack )
\ Store the adjusted return stack pointer into the parameter stack
    !
\ Store the desired entry address at top of the tasks return stack
  r> insert ;

: activate ( task --   R: continue -- )
  true over 1 cells + ! \ Currently running
  r> preparetask ;

: background ( task --   R: continue -- )
  false over 1 cells + ! \ Currently idling
  r> preparetask ;

\ --------------------------------------------------
\  Multitasking insight
\ --------------------------------------------------

: tasks ( -- ) \ Show tasks currently in round-robin list
  hook-pause @ singletask \ Stop multitasking as this list may be changed during printout.
  \ Start with current task.
  next-task cr
  begin
    ( Task-Address )
    dup             ." Task @ " hex.
    dup           @ ." Next: " hex.
    dup 1 cells + @ ." State: " hex.
    dup 2 cells + @ ." Stack: " hex.
    dup 3 cells + @ ." Handler: " hex. cr
    @ dup next-task = \ Stop when end of circular list is reached
  until
  drop
  hook-pause ! \ Restore old state of multitasking
;

\ --------------------------------------------------
\  Exception handling
\ --------------------------------------------------

: catch ( x1 .. xn xt -- y1 .. yn throwcode / z1 .. zm 0 )
    [ $B430 h, ]  \ push { r4  r5 } to save I and I'
    sp@ >r handler @ >r rp@ handler !  execute
    r> handler !  rdrop  0 unloop ;

: throw ( throwcode -- )  dup if
  handler @ 0= if false task-state ! then \ unhandled error: stop task
    handler @ rp! r> handler ! r> swap >r sp! drop r>
    unloop  exit
    else  drop  then ;

\ --------------------------------------------------
\  Lowpower mode
\ --------------------------------------------------

\ : up-alone? ( -- ? ) \ Checks if all other tasks are currently in idle state
  \ next-task @ \ Current task is in UP. Start with the next one.
  \ begin
    \ dup up @ <> \ Scan the whole round-robin list until back to current task.
  \ while
    \ dup 1 cells + @ if drop false exit then
    \ \ Check state of this task and exit if it is active
    \ @ \ Next task in list
  \ repeat
  \ drop true ;
\ 
\ : sleep ( -- ) [ $BF30 h, ] inline ; \ WFI Opcode, enters sleep mode
\ 
\ task: lowpower-task
\ 
\ : lowpower& ( -- )
  \ lowpower-task activate
    \ begin
      \ eint? if \ Only enter sleep mode if interrupts have been enabled
        \ dint up-alone? if ( ."  Sleep " ) sleep then eint
      \ then
      \ pause
    \ again ;

\ --------------------------------------------------
\  Examples
\ --------------------------------------------------

\ compiletoram eint multitask

\ 0 variable seconds
\ task: timetask

\ : time& ( -- )
\   timetask background
\     begin
\       key? if boot-task wake then
\       1 seconds +!
\       seconds @ . cr
\       stop
\     again ;

\ time& lowpower& tasks

\ : tick ( -- ) timetask wake ;

\  ' tick irq-systick !
\  16000000 $E000E014 ! \ How many ticks between interrupts ?
\         7 $E000E010 ! \ Enable the systick interrupt.

\ stop \ Idle the boot task
