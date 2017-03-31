\ We can blink forever with something like
: bb begin led.on 100 ms led.off 200 ms again ;
\ The problem is, it never returns and we never get back to the console
\  until you reset the device.  That's sub-optimal.
\ The Forthy solution?  Multitasking!

\ Multitasking in Forth is really just saving some pointers and the 
\  contents of the stack, and switching between these contexts.
\ The "pause" word lets one task give up execution to the next,
\  and then they can take turns. 
\ The "ms" delay word already has a pause built in, so what was a blocking 
\  wait in single-task mode becomes instantly non-blocking in multi.

\ This defines a task's context, and reserves some memory
task: blinktask

\ Create a wrapper function to run the task
: blink&  \ & means background-task in Unix, handy mnemonic
    blinktask activate \ sets up the context, running
    begin led.on 100 ms led.off 200 ms again
    \ our non-returning loop function, with pauses sprinkled in
;

multitask  \ turn multitasking on 
	   \ I'll often add this in the init function
blink&     \ start background task

\ You can then turn the task on and off with 
\ blinktask idle and blinktask wake
\ tasks list all the tasks, but by address, so it's not so useful

