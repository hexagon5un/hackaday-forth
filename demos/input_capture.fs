
\ GPIO Interrupt example for STM32f103 (Blue Pill)
\ Melexis 1181 Latching Hall Sensor hooked to PB4

\ EXTI registers
$40010400 constant EXTI
EXTI $00 + constant EXTI_IMR
EXTI $04 + constant EXTI_EMR
EXTI $08 + constant EXTI_RTSR
EXTI $0C + constant EXTI_FTSR
EXTI $10 + constant EXTI_SWIER
EXTI $14 + constant EXTI_PR

AFIO $0C + constant AFIO_EXTICR2

$E000E000 constant NVIC
NVIC $100 + constant NVIC_ISER0

0 variable count

: inc ( var -- )
    dup @ 1 + swap !
    ;

: handler ( -- )
    4 bit EXTI_PR bis! \ clear the interrupt flag
    led.toggle
    count inc
    ;

: pb4-init ( -- )
    0 bit RCC-APB2ENR bis! \ enable afio peripheral
    imode-pull pb4 io-mode! \ set pin mode
    -1 pb4 io! \ use internal pull-up
    ['] handler irq-exti4 ! \ set handler
    1 AFIO_EXTICR2 !     \ map input pb4 -> exti4
    4 bit EXTI_FTSR bis! \ enable falling edge
    4 bit EXTI_RTSR bis! \ enable rising edge
    4 bit EXTI_IMR bis!  \ unmask interrupt
    10 bit NVIC_ISER0 bis! \ enable interrupt
    ;

\ Start capturing - Use `count ? cr` to view count
pb4-init
