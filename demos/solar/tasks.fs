
( define a background task / context )
task: blinktask
: blink& 
  blinktask activate
  ." activating blinktask" cr
  begin 
  led.blink 1000 ms  
  again
;


task: sampletask
: sample& 
  sampletask activate
  ." activating sampletask" cr
  begin 
  button.report? if sum-both print-reading led.on 20 ms then 
  pause
  again 
;

task: nexttask
: next& 
  nexttask activate
  ." activating nexttask" cr
  begin 
  button.next? if ." ####################" cr 1000 ms then 
  pause
  again 
;




