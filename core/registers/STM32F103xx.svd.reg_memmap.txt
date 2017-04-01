\ STM32F103xx Register Memory Map for Mecrisp-Stellaris Forth by Matthias Koch
\ By Terry Porter "terry@tjporter.com.au"

$A0000000 constant FSMC  
FSMC $0 + constant FSMC_BCR1
FSMC $4 + constant FSMC_BTR1
FSMC $8 + constant FSMC_BCR2
FSMC $C + constant FSMC_BTR2
FSMC $10 + constant FSMC_BCR3
FSMC $14 + constant FSMC_BTR3
FSMC $18 + constant FSMC_BCR4
FSMC $1C + constant FSMC_BTR4
FSMC $60 + constant FSMC_PCR2
FSMC $64 + constant FSMC_SR2
FSMC $68 + constant FSMC_PMEM2
FSMC $6C + constant FSMC_PATT2
FSMC $74 + constant FSMC_ECCR2
FSMC $80 + constant FSMC_PCR3
FSMC $84 + constant FSMC_SR3
FSMC $88 + constant FSMC_PMEM3
FSMC $8C + constant FSMC_PATT3
FSMC $94 + constant FSMC_ECCR3
FSMC $A0 + constant FSMC_PCR4
FSMC $A4 + constant FSMC_SR4
FSMC $A8 + constant FSMC_PMEM4
FSMC $AC + constant FSMC_PATT4
FSMC $B0 + constant FSMC_PIO4
FSMC $104 + constant FSMC_BWTR1
FSMC $10C + constant FSMC_BWTR2
FSMC $114 + constant FSMC_BWTR3
FSMC $11C + constant FSMC_BWTR4
  
$40007000 constant PWR  
PWR $0 + constant PWR_CR
PWR $4 + constant PWR_CSR
  
$40021000 constant RCC  
RCC $0 + constant RCC_CR
RCC $4 + constant RCC_CFGR
RCC $8 + constant RCC_CIR
RCC $C + constant RCC_APB2RSTR
RCC $10 + constant RCC_APB1RSTR
RCC $14 + constant RCC_AHBENR
RCC $18 + constant RCC_APB2ENR
RCC $1C + constant RCC_APB1ENR
RCC $20 + constant RCC_BDCR
RCC $24 + constant RCC_CSR
  
$40010800 constant GPIOA  
GPIOA $0 + constant GPIOA_CRL
GPIOA $4 + constant GPIOA_CRH
GPIOA $8 + constant GPIOA_IDR
GPIOA $C + constant GPIOA_ODR
GPIOA $10 + constant GPIOA_BSRR
GPIOA $14 + constant GPIOA_BRR
GPIOA $18 + constant GPIOA_LCKR
  
$40010C00 constant GPIOB  
  
$40011000 constant GPIOC  
  
$40011400 constant GPIOD  
  
$40011800 constant GPIOE  
  
$40011C00 constant GPIOF  
  
$40012000 constant GPIOG  
  
$40010000 constant AFIO  
AFIO $0 + constant AFIO_EVCR
AFIO $4 + constant AFIO_MAPR
AFIO $8 + constant AFIO_EXTICR1
AFIO $C + constant AFIO_EXTICR2
AFIO $10 + constant AFIO_EXTICR3
AFIO $14 + constant AFIO_EXTICR4
AFIO $1C + constant AFIO_MAPR2
  
$40010400 constant EXTI  
EXTI $0 + constant EXTI_IMR
EXTI $4 + constant EXTI_EMR
EXTI $8 + constant EXTI_RTSR
EXTI $C + constant EXTI_FTSR
EXTI $10 + constant EXTI_SWIER
EXTI $14 + constant EXTI_PR
  
$40020000 constant DMA1  
DMA1 $0 + constant DMA1_ISR
DMA1 $4 + constant DMA1_IFCR
DMA1 $8 + constant DMA1_CCR1
DMA1 $C + constant DMA1_CNDTR1
DMA1 $10 + constant DMA1_CPAR1
DMA1 $14 + constant DMA1_CMAR1
DMA1 $1C + constant DMA1_CCR2
DMA1 $20 + constant DMA1_CNDTR2
DMA1 $24 + constant DMA1_CPAR2
DMA1 $28 + constant DMA1_CMAR2
DMA1 $30 + constant DMA1_CCR3
DMA1 $34 + constant DMA1_CNDTR3
DMA1 $38 + constant DMA1_CPAR3
DMA1 $3C + constant DMA1_CMAR3
DMA1 $44 + constant DMA1_CCR4
DMA1 $48 + constant DMA1_CNDTR4
DMA1 $4C + constant DMA1_CPAR4
DMA1 $50 + constant DMA1_CMAR4
DMA1 $58 + constant DMA1_CCR5
DMA1 $5C + constant DMA1_CNDTR5
DMA1 $60 + constant DMA1_CPAR5
DMA1 $64 + constant DMA1_CMAR5
DMA1 $6C + constant DMA1_CCR6
DMA1 $70 + constant DMA1_CNDTR6
DMA1 $74 + constant DMA1_CPAR6
DMA1 $78 + constant DMA1_CMAR6
DMA1 $80 + constant DMA1_CCR7
DMA1 $84 + constant DMA1_CNDTR7
DMA1 $88 + constant DMA1_CPAR7
DMA1 $8C + constant DMA1_CMAR7
  
$40020400 constant DMA2  
  
$40018000 constant SDIO  
SDIO $0 + constant SDIO_POWER
SDIO $4 + constant SDIO_CLKCR
SDIO $8 + constant SDIO_ARG
SDIO $C + constant SDIO_CMD
SDIO $10 + constant SDIO_RESPCMD
SDIO $14 + constant SDIO_RESPI1
SDIO $18 + constant SDIO_RESP2
SDIO $1C + constant SDIO_RESP3
SDIO $20 + constant SDIO_RESP4
SDIO $24 + constant SDIO_DTIMER
SDIO $28 + constant SDIO_DLEN
SDIO $2C + constant SDIO_DCTRL
SDIO $30 + constant SDIO_DCOUNT
SDIO $34 + constant SDIO_STA
SDIO $38 + constant SDIO_ICR
SDIO $3C + constant SDIO_MASK
SDIO $48 + constant SDIO_FIFOCNT
SDIO $80 + constant SDIO_FIFO
  
$40002800 constant RTC  
RTC $0 + constant RTC_CRH
RTC $4 + constant RTC_CRL
RTC $8 + constant RTC_PRLH
RTC $C + constant RTC_PRLL
RTC $10 + constant RTC_DIVH
RTC $14 + constant RTC_DIVL
RTC $18 + constant RTC_CNTH
RTC $1C + constant RTC_CNTL
RTC $20 + constant RTC_ALRH
RTC $24 + constant RTC_ALRL
  
$40006C04 constant BKP  
BKP $0 + constant BKP_DR1
BKP $4 + constant BKP_DR2
BKP $8 + constant BKP_DR3
BKP $C + constant BKP_DR4
BKP $10 + constant BKP_DR5
BKP $14 + constant BKP_DR6
BKP $18 + constant BKP_DR7
BKP $1C + constant BKP_DR8
BKP $20 + constant BKP_DR9
BKP $24 + constant BKP_DR10
BKP $3C + constant BKP_DR11
BKP $40 + constant BKP_DR12
BKP $44 + constant BKP_DR13
BKP $48 + constant BKP_DR14
BKP $4C + constant BKP_DR15
BKP $50 + constant BKP_DR16
BKP $54 + constant BKP_DR17
BKP $58 + constant BKP_DR18
BKP $5C + constant BKP_DR19
BKP $60 + constant BKP_DR20
BKP $64 + constant BKP_DR21
BKP $68 + constant BKP_DR22
BKP $6C + constant BKP_DR23
BKP $70 + constant BKP_DR24
BKP $74 + constant BKP_DR25
BKP $78 + constant BKP_DR26
BKP $7C + constant BKP_DR27
BKP $80 + constant BKP_DR28
BKP $84 + constant BKP_DR29
BKP $88 + constant BKP_DR30
BKP $8C + constant BKP_DR31
BKP $90 + constant BKP_DR32
BKP $94 + constant BKP_DR33
BKP $98 + constant BKP_DR34
BKP $9C + constant BKP_DR35
BKP $A0 + constant BKP_DR36
BKP $A4 + constant BKP_DR37
BKP $A8 + constant BKP_DR38
BKP $AC + constant BKP_DR39
BKP $B0 + constant BKP_DR40
BKP $B4 + constant BKP_DR41
BKP $B8 + constant BKP_DR42
BKP $28 + constant BKP_RTCCR
BKP $2C + constant BKP_CR
BKP $30 + constant BKP_CSR
  
$40003000 constant IWDG  
IWDG $0 + constant IWDG_KR
IWDG $4 + constant IWDG_PR
IWDG $8 + constant IWDG_RLR
IWDG $C + constant IWDG_SR
  
$40002C00 constant WWDG  
WWDG $0 + constant WWDG_CR
WWDG $4 + constant WWDG_CFR
WWDG $8 + constant WWDG_SR
  
$40012C00 constant TIM1  
TIM1 $0 + constant TIM1_CR1
TIM1 $4 + constant TIM1_CR2
TIM1 $8 + constant TIM1_SMCR
TIM1 $C + constant TIM1_DIER
TIM1 $10 + constant TIM1_SR
TIM1 $14 + constant TIM1_EGR
TIM1 $18 + constant TIM1_CCMR1_Output
TIM1 $18 + constant TIM1_CCMR1_Input
TIM1 $1C + constant TIM1_CCMR2_Output
TIM1 $1C + constant TIM1_CCMR2_Input
TIM1 $20 + constant TIM1_CCER
TIM1 $24 + constant TIM1_CNT
TIM1 $28 + constant TIM1_PSC
TIM1 $2C + constant TIM1_ARR
TIM1 $34 + constant TIM1_CCR1
TIM1 $38 + constant TIM1_CCR2
TIM1 $3C + constant TIM1_CCR3
TIM1 $40 + constant TIM1_CCR4
TIM1 $48 + constant TIM1_DCR
TIM1 $4C + constant TIM1_DMAR
TIM1 $30 + constant TIM1_RCR
TIM1 $44 + constant TIM1_BDTR
  
$40013400 constant TIM8  
  
$40000000 constant TIM2  
TIM2 $0 + constant TIM2_CR1
TIM2 $4 + constant TIM2_CR2
TIM2 $8 + constant TIM2_SMCR
TIM2 $C + constant TIM2_DIER
TIM2 $10 + constant TIM2_SR
TIM2 $14 + constant TIM2_EGR
TIM2 $18 + constant TIM2_CCMR1_Output
TIM2 $18 + constant TIM2_CCMR1_Input
TIM2 $1C + constant TIM2_CCMR2_Output
TIM2 $1C + constant TIM2_CCMR2_Input
TIM2 $20 + constant TIM2_CCER
TIM2 $24 + constant TIM2_CNT
TIM2 $28 + constant TIM2_PSC
TIM2 $2C + constant TIM2_ARR
TIM2 $34 + constant TIM2_CCR1
TIM2 $38 + constant TIM2_CCR2
TIM2 $3C + constant TIM2_CCR3
TIM2 $40 + constant TIM2_CCR4
TIM2 $48 + constant TIM2_DCR
TIM2 $4C + constant TIM2_DMAR
  
$40000400 constant TIM3  
  
$40000800 constant TIM4  
  
$40000C00 constant TIM5  
  
$40014C00 constant TIM9  
TIM9 $0 + constant TIM9_CR1
TIM9 $4 + constant TIM9_CR2
TIM9 $8 + constant TIM9_SMCR
TIM9 $C + constant TIM9_DIER
TIM9 $10 + constant TIM9_SR
TIM9 $14 + constant TIM9_EGR
TIM9 $18 + constant TIM9_CCMR1_Output
TIM9 $18 + constant TIM9_CCMR1_Input
TIM9 $20 + constant TIM9_CCER
TIM9 $24 + constant TIM9_CNT
TIM9 $28 + constant TIM9_PSC
TIM9 $2C + constant TIM9_ARR
TIM9 $34 + constant TIM9_CCR1
TIM9 $38 + constant TIM9_CCR2
  
$40001800 constant TIM12  
  
$40015000 constant TIM10  
TIM10 $0 + constant TIM10_CR1
TIM10 $4 + constant TIM10_CR2
TIM10 $C + constant TIM10_DIER
TIM10 $10 + constant TIM10_SR
TIM10 $14 + constant TIM10_EGR
TIM10 $18 + constant TIM10_CCMR1_Output
TIM10 $18 + constant TIM10_CCMR1_Input
TIM10 $20 + constant TIM10_CCER
TIM10 $24 + constant TIM10_CNT
TIM10 $28 + constant TIM10_PSC
TIM10 $2C + constant TIM10_ARR
TIM10 $34 + constant TIM10_CCR1
  
$40015400 constant TIM11  
  
$40001C00 constant TIM13  
  
$40002000 constant TIM14  
  
$40001000 constant TIM6  
TIM6 $0 + constant TIM6_CR1
TIM6 $4 + constant TIM6_CR2
TIM6 $C + constant TIM6_DIER
TIM6 $10 + constant TIM6_SR
TIM6 $14 + constant TIM6_EGR
TIM6 $24 + constant TIM6_CNT
TIM6 $28 + constant TIM6_PSC
TIM6 $2C + constant TIM6_ARR
  
$40001400 constant TIM7  
  
$40005400 constant I2C1  
I2C1 $0 + constant I2C1_CR1
I2C1 $4 + constant I2C1_CR2
I2C1 $8 + constant I2C1_OAR1
I2C1 $C + constant I2C1_OAR2
I2C1 $10 + constant I2C1_DR
I2C1 $14 + constant I2C1_SR1
I2C1 $18 + constant I2C1_SR2
I2C1 $1C + constant I2C1_CCR
I2C1 $20 + constant I2C1_TRISE
  
$40005800 constant I2C2  
  
$40013000 constant SPI1  
SPI1 $0 + constant SPI1_CR1
SPI1 $4 + constant SPI1_CR2
SPI1 $8 + constant SPI1_SR
SPI1 $C + constant SPI1_DR
SPI1 $10 + constant SPI1_CRCPR
SPI1 $14 + constant SPI1_RXCRCR
SPI1 $18 + constant SPI1_TXCRCR
SPI1 $1C + constant SPI1_I2SCFGR
SPI1 $20 + constant SPI1_I2SPR
  
$40003800 constant SPI2  
  
$40003C00 constant SPI3  
  
$40013800 constant USART1  
USART1 $0 + constant USART1_SR
USART1 $4 + constant USART1_DR
USART1 $8 + constant USART1_BRR
USART1 $C + constant USART1_CR1
USART1 $10 + constant USART1_CR2
USART1 $14 + constant USART1_CR3
USART1 $18 + constant USART1_GTPR
  
$40004400 constant USART2  
  
$40004800 constant USART3  
  
$40012400 constant ADC1  
ADC1 $0 + constant ADC1_SR
ADC1 $4 + constant ADC1_CR1
ADC1 $8 + constant ADC1_CR2
ADC1 $C + constant ADC1_SMPR1
ADC1 $10 + constant ADC1_SMPR2
ADC1 $14 + constant ADC1_JOFR1
ADC1 $18 + constant ADC1_JOFR2
ADC1 $1C + constant ADC1_JOFR3
ADC1 $20 + constant ADC1_JOFR4
ADC1 $24 + constant ADC1_HTR
ADC1 $28 + constant ADC1_LTR
ADC1 $2C + constant ADC1_SQR1
ADC1 $30 + constant ADC1_SQR2
ADC1 $34 + constant ADC1_SQR3
ADC1 $38 + constant ADC1_JSQR
ADC1 $3C + constant ADC1_JDR1
ADC1 $40 + constant ADC1_JDR2
ADC1 $44 + constant ADC1_JDR3
ADC1 $48 + constant ADC1_JDR4
ADC1 $4C + constant ADC1_DR
  
$40012800 constant ADC2  
ADC2 $0 + constant ADC2_SR
ADC2 $4 + constant ADC2_CR1
ADC2 $8 + constant ADC2_CR2
ADC2 $C + constant ADC2_SMPR1
ADC2 $10 + constant ADC2_SMPR2
ADC2 $14 + constant ADC2_JOFR1
ADC2 $18 + constant ADC2_JOFR2
ADC2 $1C + constant ADC2_JOFR3
ADC2 $20 + constant ADC2_JOFR4
ADC2 $24 + constant ADC2_HTR
ADC2 $28 + constant ADC2_LTR
ADC2 $2C + constant ADC2_SQR1
ADC2 $30 + constant ADC2_SQR2
ADC2 $34 + constant ADC2_SQR3
ADC2 $38 + constant ADC2_JSQR
ADC2 $3C + constant ADC2_JDR1
ADC2 $40 + constant ADC2_JDR2
ADC2 $44 + constant ADC2_JDR3
ADC2 $48 + constant ADC2_JDR4
ADC2 $4C + constant ADC2_DR
  
$40013C00 constant ADC3  
  
$40006400 constant CAN  
CAN $0 + constant CAN_CAN_MCR
CAN $4 + constant CAN_CAN_MSR
CAN $8 + constant CAN_CAN_TSR
CAN $C + constant CAN_CAN_RF0R
CAN $10 + constant CAN_CAN_RF1R
CAN $14 + constant CAN_CAN_IER
CAN $18 + constant CAN_CAN_ESR
CAN $1C + constant CAN_CAN_BTR
CAN $180 + constant CAN_CAN_TI0R
CAN $184 + constant CAN_CAN_TDT0R
CAN $188 + constant CAN_CAN_TDL0R
CAN $18C + constant CAN_CAN_TDH0R
CAN $190 + constant CAN_CAN_TI1R
CAN $194 + constant CAN_CAN_TDT1R
CAN $198 + constant CAN_CAN_TDL1R
CAN $19C + constant CAN_CAN_TDH1R
CAN $1A0 + constant CAN_CAN_TI2R
CAN $1A4 + constant CAN_CAN_TDT2R
CAN $1A8 + constant CAN_CAN_TDL2R
CAN $1AC + constant CAN_CAN_TDH2R
CAN $1B0 + constant CAN_CAN_RI0R
CAN $1B4 + constant CAN_CAN_RDT0R
CAN $1B8 + constant CAN_CAN_RDL0R
CAN $1BC + constant CAN_CAN_RDH0R
CAN $1C0 + constant CAN_CAN_RI1R
CAN $1C4 + constant CAN_CAN_RDT1R
CAN $1C8 + constant CAN_CAN_RDL1R
CAN $1CC + constant CAN_CAN_RDH1R
CAN $200 + constant CAN_CAN_FMR
CAN $204 + constant CAN_CAN_FM1R
CAN $20C + constant CAN_CAN_FS1R
CAN $214 + constant CAN_CAN_FFA1R
CAN $21C + constant CAN_CAN_FA1R
CAN $240 + constant CAN_F0R1
CAN $244 + constant CAN_F0R2
CAN $248 + constant CAN_F1R1
CAN $24C + constant CAN_F1R2
CAN $250 + constant CAN_F2R1
CAN $254 + constant CAN_F2R2
CAN $258 + constant CAN_F3R1
CAN $25C + constant CAN_F3R2
CAN $260 + constant CAN_F4R1
CAN $264 + constant CAN_F4R2
CAN $268 + constant CAN_F5R1
CAN $26C + constant CAN_F5R2
CAN $270 + constant CAN_F6R1
CAN $274 + constant CAN_F6R2
CAN $278 + constant CAN_F7R1
CAN $27C + constant CAN_F7R2
CAN $280 + constant CAN_F8R1
CAN $284 + constant CAN_F8R2
CAN $288 + constant CAN_F9R1
CAN $28C + constant CAN_F9R2
CAN $290 + constant CAN_F10R1
CAN $294 + constant CAN_F10R2
CAN $298 + constant CAN_F11R1
CAN $29C + constant CAN_F11R2
CAN $2A0 + constant CAN_F12R1
CAN $2A4 + constant CAN_F12R2
CAN $2A8 + constant CAN_F13R1
CAN $2AC + constant CAN_F13R2
  
$40007400 constant DAC  
DAC $0 + constant DAC_CR
DAC $4 + constant DAC_SWTRIGR
DAC $8 + constant DAC_DHR12R1
DAC $C + constant DAC_DHR12L1
DAC $10 + constant DAC_DHR8R1
DAC $14 + constant DAC_DHR12R2
DAC $18 + constant DAC_DHR12L2
DAC $1C + constant DAC_DHR8R2
DAC $20 + constant DAC_DHR12RD
DAC $24 + constant DAC_DHR12LD
DAC $28 + constant DAC_DHR8RD
DAC $2C + constant DAC_DOR1
DAC $30 + constant DAC_DOR2
  
$E0042000 constant DBG  
DBG $0 + constant DBG_IDCODE
DBG $4 + constant DBG_CR
  
$40004C00 constant UART4  
UART4 $0 + constant UART4_SR
UART4 $4 + constant UART4_DR
UART4 $8 + constant UART4_BRR
UART4 $C + constant UART4_CR1
UART4 $10 + constant UART4_CR2
UART4 $14 + constant UART4_CR3
  
$40005000 constant UART5  
UART5 $0 + constant UART5_SR
UART5 $4 + constant UART5_DR
UART5 $8 + constant UART5_BRR
UART5 $C + constant UART5_CR1
UART5 $10 + constant UART5_CR2
UART5 $14 + constant UART5_CR3
  
$40023000 constant CRC  
CRC $0 + constant CRC_DR
CRC $4 + constant CRC_IDR
CRC $8 + constant CRC_CR
  
$40022000 constant FLASH  
FLASH $0 + constant FLASH_ACR
FLASH $4 + constant FLASH_KEYR
FLASH $8 + constant FLASH_OPTKEYR
FLASH $C + constant FLASH_SR
FLASH $10 + constant FLASH_CR
FLASH $14 + constant FLASH_AR
FLASH $1C + constant FLASH_OBR
FLASH $20 + constant FLASH_WRPR
  
$E000E000 constant NVIC  
NVIC $4 + constant NVIC_ICTR
NVIC $F00 + constant NVIC_STIR
NVIC $100 + constant NVIC_ISER0
NVIC $104 + constant NVIC_ISER1
NVIC $180 + constant NVIC_ICER0
NVIC $184 + constant NVIC_ICER1
NVIC $200 + constant NVIC_ISPR0
NVIC $204 + constant NVIC_ISPR1
NVIC $280 + constant NVIC_ICPR0
NVIC $284 + constant NVIC_ICPR1
NVIC $300 + constant NVIC_IABR0
NVIC $304 + constant NVIC_IABR1
NVIC $400 + constant NVIC_IPR0
NVIC $404 + constant NVIC_IPR1
NVIC $408 + constant NVIC_IPR2
NVIC $40C + constant NVIC_IPR3
NVIC $410 + constant NVIC_IPR4
NVIC $414 + constant NVIC_IPR5
NVIC $418 + constant NVIC_IPR6
NVIC $41C + constant NVIC_IPR7
NVIC $420 + constant NVIC_IPR8
NVIC $424 + constant NVIC_IPR9
NVIC $428 + constant NVIC_IPR10
NVIC $42C + constant NVIC_IPR11
NVIC $430 + constant NVIC_IPR12
NVIC $434 + constant NVIC_IPR13
NVIC $438 + constant NVIC_IPR14
  
$40005C00 constant USB  
USB $0 + constant USB_EP0R
USB $4 + constant USB_EP1R
USB $8 + constant USB_EP2R
USB $C + constant USB_EP3R
USB $10 + constant USB_EP4R
USB $14 + constant USB_EP5R
USB $18 + constant USB_EP6R
USB $1C + constant USB_EP7R
USB $40 + constant USB_CNTR
USB $44 + constant USB_ISTR
USB $48 + constant USB_FNR
USB $4C + constant USB_DADDR
USB $50 + constant USB_BTABLE
  
