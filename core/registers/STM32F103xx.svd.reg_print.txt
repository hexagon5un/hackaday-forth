\ STM32F103xx Register Print file for Mecrisp-Stellaris Forth by Matthias Koch
\ By Terry Porter "terry@tjporter.com.au"

: FSMC. cr
." FSMC_BCR1: " FSMC_BCR1 @ hex. cr
." FSMC_BTR1: " FSMC_BTR1 @ hex. cr
." FSMC_BCR2: " FSMC_BCR2 @ hex. cr
." FSMC_BTR2: " FSMC_BTR2 @ hex. cr
." FSMC_BCR3: " FSMC_BCR3 @ hex. cr
." FSMC_BTR3: " FSMC_BTR3 @ hex. cr
." FSMC_BCR4: " FSMC_BCR4 @ hex. cr
." FSMC_BTR4: " FSMC_BTR4 @ hex. cr
." FSMC_PCR2: " FSMC_PCR2 @ hex. cr
." FSMC_SR2: " FSMC_SR2 @ hex. cr
." FSMC_PMEM2: " FSMC_PMEM2 @ hex. cr
." FSMC_PATT2: " FSMC_PATT2 @ hex. cr
." FSMC_ECCR2: " FSMC_ECCR2 @ hex. cr
." FSMC_PCR3: " FSMC_PCR3 @ hex. cr
." FSMC_SR3: " FSMC_SR3 @ hex. cr
." FSMC_PMEM3: " FSMC_PMEM3 @ hex. cr
." FSMC_PATT3: " FSMC_PATT3 @ hex. cr
." FSMC_ECCR3: " FSMC_ECCR3 @ hex. cr
." FSMC_PCR4: " FSMC_PCR4 @ hex. cr
." FSMC_SR4: " FSMC_SR4 @ hex. cr
." FSMC_PMEM4: " FSMC_PMEM4 @ hex. cr
." FSMC_PATT4: " FSMC_PATT4 @ hex. cr
." FSMC_PIO4: " FSMC_PIO4 @ hex. cr
." FSMC_BWTR1: " FSMC_BWTR1 @ hex. cr
." FSMC_BWTR2: " FSMC_BWTR2 @ hex. cr
." FSMC_BWTR3: " FSMC_BWTR3 @ hex. cr
." FSMC_BWTR4: " FSMC_BWTR4 @ hex. cr
;

: PWR. cr
." PWR_CR: " PWR_CR @ hex. cr
." PWR_CSR: " PWR_CSR @ hex. cr
;

: RCC. cr
." RCC_CR: " RCC_CR @ hex. cr
." RCC_CFGR: " RCC_CFGR @ hex. cr
." RCC_CIR: " RCC_CIR @ hex. cr
." RCC_APB2RSTR: " RCC_APB2RSTR @ hex. cr
." RCC_APB1RSTR: " RCC_APB1RSTR @ hex. cr
." RCC_AHBENR: " RCC_AHBENR @ hex. cr
." RCC_APB2ENR: " RCC_APB2ENR @ hex. cr
." RCC_APB1ENR: " RCC_APB1ENR @ hex. cr
." RCC_BDCR: " RCC_BDCR @ hex. cr
." RCC_CSR: " RCC_CSR @ hex. cr
;

: GPIOA. cr
." GPIOA_CRL: " GPIOA_CRL @ hex. cr
." GPIOA_CRH: " GPIOA_CRH @ hex. cr
." GPIOA_IDR: " GPIOA_IDR @ hex. cr
." GPIOA_ODR: " GPIOA_ODR @ hex. cr
." GPIOA_BSRR: " GPIOA_BSRR @ hex. cr
." GPIOA_BRR: " GPIOA_BRR @ hex. cr
." GPIOA_LCKR: " GPIOA_LCKR @ hex. cr
;

: GPIOB. cr
;

: GPIOC. cr
;

: GPIOD. cr
;

: GPIOE. cr
;

: GPIOF. cr
;

: GPIOG. cr
;

: AFIO. cr
." AFIO_EVCR: " AFIO_EVCR @ hex. cr
." AFIO_MAPR: " AFIO_MAPR @ hex. cr
." AFIO_EXTICR1: " AFIO_EXTICR1 @ hex. cr
." AFIO_EXTICR2: " AFIO_EXTICR2 @ hex. cr
." AFIO_EXTICR3: " AFIO_EXTICR3 @ hex. cr
." AFIO_EXTICR4: " AFIO_EXTICR4 @ hex. cr
." AFIO_MAPR2: " AFIO_MAPR2 @ hex. cr
;

: EXTI. cr
." EXTI_IMR: " EXTI_IMR @ hex. cr
." EXTI_EMR: " EXTI_EMR @ hex. cr
." EXTI_RTSR: " EXTI_RTSR @ hex. cr
." EXTI_FTSR: " EXTI_FTSR @ hex. cr
." EXTI_SWIER: " EXTI_SWIER @ hex. cr
." EXTI_PR: " EXTI_PR @ hex. cr
;

: DMA1. cr
." DMA1_ISR: " DMA1_ISR @ hex. cr
." DMA1_IFCR: " DMA1_IFCR @ hex. cr
." DMA1_CCR1: " DMA1_CCR1 @ hex. cr
." DMA1_CNDTR1: " DMA1_CNDTR1 @ hex. cr
." DMA1_CPAR1: " DMA1_CPAR1 @ hex. cr
." DMA1_CMAR1: " DMA1_CMAR1 @ hex. cr
." DMA1_CCR2: " DMA1_CCR2 @ hex. cr
." DMA1_CNDTR2: " DMA1_CNDTR2 @ hex. cr
." DMA1_CPAR2: " DMA1_CPAR2 @ hex. cr
." DMA1_CMAR2: " DMA1_CMAR2 @ hex. cr
." DMA1_CCR3: " DMA1_CCR3 @ hex. cr
." DMA1_CNDTR3: " DMA1_CNDTR3 @ hex. cr
." DMA1_CPAR3: " DMA1_CPAR3 @ hex. cr
." DMA1_CMAR3: " DMA1_CMAR3 @ hex. cr
." DMA1_CCR4: " DMA1_CCR4 @ hex. cr
." DMA1_CNDTR4: " DMA1_CNDTR4 @ hex. cr
." DMA1_CPAR4: " DMA1_CPAR4 @ hex. cr
." DMA1_CMAR4: " DMA1_CMAR4 @ hex. cr
." DMA1_CCR5: " DMA1_CCR5 @ hex. cr
." DMA1_CNDTR5: " DMA1_CNDTR5 @ hex. cr
." DMA1_CPAR5: " DMA1_CPAR5 @ hex. cr
." DMA1_CMAR5: " DMA1_CMAR5 @ hex. cr
." DMA1_CCR6: " DMA1_CCR6 @ hex. cr
." DMA1_CNDTR6: " DMA1_CNDTR6 @ hex. cr
." DMA1_CPAR6: " DMA1_CPAR6 @ hex. cr
." DMA1_CMAR6: " DMA1_CMAR6 @ hex. cr
." DMA1_CCR7: " DMA1_CCR7 @ hex. cr
." DMA1_CNDTR7: " DMA1_CNDTR7 @ hex. cr
." DMA1_CPAR7: " DMA1_CPAR7 @ hex. cr
." DMA1_CMAR7: " DMA1_CMAR7 @ hex. cr
;

: DMA2. cr
;

: SDIO. cr
." SDIO_POWER: " SDIO_POWER @ hex. cr
." SDIO_CLKCR: " SDIO_CLKCR @ hex. cr
." SDIO_ARG: " SDIO_ARG @ hex. cr
." SDIO_CMD: " SDIO_CMD @ hex. cr
." SDIO_RESPCMD: " SDIO_RESPCMD @ hex. cr
." SDIO_RESPI1: " SDIO_RESPI1 @ hex. cr
." SDIO_RESP2: " SDIO_RESP2 @ hex. cr
." SDIO_RESP3: " SDIO_RESP3 @ hex. cr
." SDIO_RESP4: " SDIO_RESP4 @ hex. cr
." SDIO_DTIMER: " SDIO_DTIMER @ hex. cr
." SDIO_DLEN: " SDIO_DLEN @ hex. cr
." SDIO_DCTRL: " SDIO_DCTRL @ hex. cr
." SDIO_DCOUNT: " SDIO_DCOUNT @ hex. cr
." SDIO_STA: " SDIO_STA @ hex. cr
." SDIO_ICR: " SDIO_ICR @ hex. cr
." SDIO_MASK: " SDIO_MASK @ hex. cr
." SDIO_FIFOCNT: " SDIO_FIFOCNT @ hex. cr
." SDIO_FIFO: " SDIO_FIFO @ hex. cr
;

: RTC. cr
." RTC_CRH: " RTC_CRH @ hex. cr
." RTC_CRL: " RTC_CRL @ hex. cr
." RTC_PRLH: " RTC_PRLH @ hex. cr
." RTC_PRLL: " RTC_PRLL @ hex. cr
." RTC_DIVH: " RTC_DIVH @ hex. cr
." RTC_DIVL: " RTC_DIVL @ hex. cr
." RTC_CNTH: " RTC_CNTH @ hex. cr
." RTC_CNTL: " RTC_CNTL @ hex. cr
." RTC_ALRH: " RTC_ALRH @ hex. cr
." RTC_ALRL: " RTC_ALRL @ hex. cr
;

: BKP. cr
." BKP_DR1: " BKP_DR1 @ hex. cr
." BKP_DR2: " BKP_DR2 @ hex. cr
." BKP_DR3: " BKP_DR3 @ hex. cr
." BKP_DR4: " BKP_DR4 @ hex. cr
." BKP_DR5: " BKP_DR5 @ hex. cr
." BKP_DR6: " BKP_DR6 @ hex. cr
." BKP_DR7: " BKP_DR7 @ hex. cr
." BKP_DR8: " BKP_DR8 @ hex. cr
." BKP_DR9: " BKP_DR9 @ hex. cr
." BKP_DR10: " BKP_DR10 @ hex. cr
." BKP_DR11: " BKP_DR11 @ hex. cr
." BKP_DR12: " BKP_DR12 @ hex. cr
." BKP_DR13: " BKP_DR13 @ hex. cr
." BKP_DR14: " BKP_DR14 @ hex. cr
." BKP_DR15: " BKP_DR15 @ hex. cr
." BKP_DR16: " BKP_DR16 @ hex. cr
." BKP_DR17: " BKP_DR17 @ hex. cr
." BKP_DR18: " BKP_DR18 @ hex. cr
." BKP_DR19: " BKP_DR19 @ hex. cr
." BKP_DR20: " BKP_DR20 @ hex. cr
." BKP_DR21: " BKP_DR21 @ hex. cr
." BKP_DR22: " BKP_DR22 @ hex. cr
." BKP_DR23: " BKP_DR23 @ hex. cr
." BKP_DR24: " BKP_DR24 @ hex. cr
." BKP_DR25: " BKP_DR25 @ hex. cr
." BKP_DR26: " BKP_DR26 @ hex. cr
." BKP_DR27: " BKP_DR27 @ hex. cr
." BKP_DR28: " BKP_DR28 @ hex. cr
." BKP_DR29: " BKP_DR29 @ hex. cr
." BKP_DR30: " BKP_DR30 @ hex. cr
." BKP_DR31: " BKP_DR31 @ hex. cr
." BKP_DR32: " BKP_DR32 @ hex. cr
." BKP_DR33: " BKP_DR33 @ hex. cr
." BKP_DR34: " BKP_DR34 @ hex. cr
." BKP_DR35: " BKP_DR35 @ hex. cr
." BKP_DR36: " BKP_DR36 @ hex. cr
." BKP_DR37: " BKP_DR37 @ hex. cr
." BKP_DR38: " BKP_DR38 @ hex. cr
." BKP_DR39: " BKP_DR39 @ hex. cr
." BKP_DR40: " BKP_DR40 @ hex. cr
." BKP_DR41: " BKP_DR41 @ hex. cr
." BKP_DR42: " BKP_DR42 @ hex. cr
." BKP_RTCCR: " BKP_RTCCR @ hex. cr
." BKP_CR: " BKP_CR @ hex. cr
." BKP_CSR: " BKP_CSR @ hex. cr
;

: IWDG. cr
." IWDG_KR: " IWDG_KR @ hex. cr
." IWDG_PR: " IWDG_PR @ hex. cr
." IWDG_RLR: " IWDG_RLR @ hex. cr
." IWDG_SR: " IWDG_SR @ hex. cr
;

: WWDG. cr
." WWDG_CR: " WWDG_CR @ hex. cr
." WWDG_CFR: " WWDG_CFR @ hex. cr
." WWDG_SR: " WWDG_SR @ hex. cr
;

: TIM1. cr
." TIM1_CR1: " TIM1_CR1 @ hex. cr
." TIM1_CR2: " TIM1_CR2 @ hex. cr
." TIM1_SMCR: " TIM1_SMCR @ hex. cr
." TIM1_DIER: " TIM1_DIER @ hex. cr
." TIM1_SR: " TIM1_SR @ hex. cr
." TIM1_EGR: " TIM1_EGR @ hex. cr
." TIM1_CCMR1_Output: " TIM1_CCMR1_Output @ hex. cr
." TIM1_CCMR1_Input: " TIM1_CCMR1_Input @ hex. cr
." TIM1_CCMR2_Output: " TIM1_CCMR2_Output @ hex. cr
." TIM1_CCMR2_Input: " TIM1_CCMR2_Input @ hex. cr
." TIM1_CCER: " TIM1_CCER @ hex. cr
." TIM1_CNT: " TIM1_CNT @ hex. cr
." TIM1_PSC: " TIM1_PSC @ hex. cr
." TIM1_ARR: " TIM1_ARR @ hex. cr
." TIM1_CCR1: " TIM1_CCR1 @ hex. cr
." TIM1_CCR2: " TIM1_CCR2 @ hex. cr
." TIM1_CCR3: " TIM1_CCR3 @ hex. cr
." TIM1_CCR4: " TIM1_CCR4 @ hex. cr
." TIM1_DCR: " TIM1_DCR @ hex. cr
." TIM1_DMAR: " TIM1_DMAR @ hex. cr
." TIM1_RCR: " TIM1_RCR @ hex. cr
." TIM1_BDTR: " TIM1_BDTR @ hex. cr
;

: TIM8. cr
;

: TIM2. cr
." TIM2_CR1: " TIM2_CR1 @ hex. cr
." TIM2_CR2: " TIM2_CR2 @ hex. cr
." TIM2_SMCR: " TIM2_SMCR @ hex. cr
." TIM2_DIER: " TIM2_DIER @ hex. cr
." TIM2_SR: " TIM2_SR @ hex. cr
." TIM2_EGR: " TIM2_EGR @ hex. cr
." TIM2_CCMR1_Output: " TIM2_CCMR1_Output @ hex. cr
." TIM2_CCMR1_Input: " TIM2_CCMR1_Input @ hex. cr
." TIM2_CCMR2_Output: " TIM2_CCMR2_Output @ hex. cr
." TIM2_CCMR2_Input: " TIM2_CCMR2_Input @ hex. cr
." TIM2_CCER: " TIM2_CCER @ hex. cr
." TIM2_CNT: " TIM2_CNT @ hex. cr
." TIM2_PSC: " TIM2_PSC @ hex. cr
." TIM2_ARR: " TIM2_ARR @ hex. cr
." TIM2_CCR1: " TIM2_CCR1 @ hex. cr
." TIM2_CCR2: " TIM2_CCR2 @ hex. cr
." TIM2_CCR3: " TIM2_CCR3 @ hex. cr
." TIM2_CCR4: " TIM2_CCR4 @ hex. cr
." TIM2_DCR: " TIM2_DCR @ hex. cr
." TIM2_DMAR: " TIM2_DMAR @ hex. cr
;

: TIM3. cr
;

: TIM4. cr
;

: TIM5. cr
;

: TIM9. cr
." TIM9_CR1: " TIM9_CR1 @ hex. cr
." TIM9_CR2: " TIM9_CR2 @ hex. cr
." TIM9_SMCR: " TIM9_SMCR @ hex. cr
." TIM9_DIER: " TIM9_DIER @ hex. cr
." TIM9_SR: " TIM9_SR @ hex. cr
." TIM9_EGR: " TIM9_EGR @ hex. cr
." TIM9_CCMR1_Output: " TIM9_CCMR1_Output @ hex. cr
." TIM9_CCMR1_Input: " TIM9_CCMR1_Input @ hex. cr
." TIM9_CCER: " TIM9_CCER @ hex. cr
." TIM9_CNT: " TIM9_CNT @ hex. cr
." TIM9_PSC: " TIM9_PSC @ hex. cr
." TIM9_ARR: " TIM9_ARR @ hex. cr
." TIM9_CCR1: " TIM9_CCR1 @ hex. cr
." TIM9_CCR2: " TIM9_CCR2 @ hex. cr
;

: TIM12. cr
;

: TIM10. cr
." TIM10_CR1: " TIM10_CR1 @ hex. cr
." TIM10_CR2: " TIM10_CR2 @ hex. cr
." TIM10_DIER: " TIM10_DIER @ hex. cr
." TIM10_SR: " TIM10_SR @ hex. cr
." TIM10_EGR: " TIM10_EGR @ hex. cr
." TIM10_CCMR1_Output: " TIM10_CCMR1_Output @ hex. cr
." TIM10_CCMR1_Input: " TIM10_CCMR1_Input @ hex. cr
." TIM10_CCER: " TIM10_CCER @ hex. cr
." TIM10_CNT: " TIM10_CNT @ hex. cr
." TIM10_PSC: " TIM10_PSC @ hex. cr
." TIM10_ARR: " TIM10_ARR @ hex. cr
." TIM10_CCR1: " TIM10_CCR1 @ hex. cr
;

: TIM11. cr
;

: TIM13. cr
;

: TIM14. cr
;

: TIM6. cr
." TIM6_CR1: " TIM6_CR1 @ hex. cr
." TIM6_CR2: " TIM6_CR2 @ hex. cr
." TIM6_DIER: " TIM6_DIER @ hex. cr
." TIM6_SR: " TIM6_SR @ hex. cr
." TIM6_EGR: " TIM6_EGR @ hex. cr
." TIM6_CNT: " TIM6_CNT @ hex. cr
." TIM6_PSC: " TIM6_PSC @ hex. cr
." TIM6_ARR: " TIM6_ARR @ hex. cr
;

: TIM7. cr
;

: I2C1. cr
." I2C1_CR1: " I2C1_CR1 @ hex. cr
." I2C1_CR2: " I2C1_CR2 @ hex. cr
." I2C1_OAR1: " I2C1_OAR1 @ hex. cr
." I2C1_OAR2: " I2C1_OAR2 @ hex. cr
." I2C1_DR: " I2C1_DR @ hex. cr
." I2C1_SR1: " I2C1_SR1 @ hex. cr
." I2C1_SR2: " I2C1_SR2 @ hex. cr
." I2C1_CCR: " I2C1_CCR @ hex. cr
." I2C1_TRISE: " I2C1_TRISE @ hex. cr
;

: I2C2. cr
;

: SPI1. cr
." SPI1_CR1: " SPI1_CR1 @ hex. cr
." SPI1_CR2: " SPI1_CR2 @ hex. cr
." SPI1_SR: " SPI1_SR @ hex. cr
." SPI1_DR: " SPI1_DR @ hex. cr
." SPI1_CRCPR: " SPI1_CRCPR @ hex. cr
." SPI1_RXCRCR: " SPI1_RXCRCR @ hex. cr
." SPI1_TXCRCR: " SPI1_TXCRCR @ hex. cr
." SPI1_I2SCFGR: " SPI1_I2SCFGR @ hex. cr
." SPI1_I2SPR: " SPI1_I2SPR @ hex. cr
;

: SPI2. cr
;

: SPI3. cr
;

: USART1. cr
." USART1_SR: " USART1_SR @ hex. cr
." USART1_DR: " USART1_DR @ hex. cr
." USART1_BRR: " USART1_BRR @ hex. cr
." USART1_CR1: " USART1_CR1 @ hex. cr
." USART1_CR2: " USART1_CR2 @ hex. cr
." USART1_CR3: " USART1_CR3 @ hex. cr
." USART1_GTPR: " USART1_GTPR @ hex. cr
;

: USART2. cr
;

: USART3. cr
;

: ADC1. cr
." ADC1_SR: " ADC1_SR @ hex. cr
." ADC1_CR1: " ADC1_CR1 @ hex. cr
." ADC1_CR2: " ADC1_CR2 @ hex. cr
." ADC1_SMPR1: " ADC1_SMPR1 @ hex. cr
." ADC1_SMPR2: " ADC1_SMPR2 @ hex. cr
." ADC1_JOFR1: " ADC1_JOFR1 @ hex. cr
." ADC1_JOFR2: " ADC1_JOFR2 @ hex. cr
." ADC1_JOFR3: " ADC1_JOFR3 @ hex. cr
." ADC1_JOFR4: " ADC1_JOFR4 @ hex. cr
." ADC1_HTR: " ADC1_HTR @ hex. cr
." ADC1_LTR: " ADC1_LTR @ hex. cr
." ADC1_SQR1: " ADC1_SQR1 @ hex. cr
." ADC1_SQR2: " ADC1_SQR2 @ hex. cr
." ADC1_SQR3: " ADC1_SQR3 @ hex. cr
." ADC1_JSQR: " ADC1_JSQR @ hex. cr
." ADC1_JDR1: " ADC1_JDR1 @ hex. cr
." ADC1_JDR2: " ADC1_JDR2 @ hex. cr
." ADC1_JDR3: " ADC1_JDR3 @ hex. cr
." ADC1_JDR4: " ADC1_JDR4 @ hex. cr
." ADC1_DR: " ADC1_DR @ hex. cr
;

: ADC2. cr
." ADC2_SR: " ADC2_SR @ hex. cr
." ADC2_CR1: " ADC2_CR1 @ hex. cr
." ADC2_CR2: " ADC2_CR2 @ hex. cr
." ADC2_SMPR1: " ADC2_SMPR1 @ hex. cr
." ADC2_SMPR2: " ADC2_SMPR2 @ hex. cr
." ADC2_JOFR1: " ADC2_JOFR1 @ hex. cr
." ADC2_JOFR2: " ADC2_JOFR2 @ hex. cr
." ADC2_JOFR3: " ADC2_JOFR3 @ hex. cr
." ADC2_JOFR4: " ADC2_JOFR4 @ hex. cr
." ADC2_HTR: " ADC2_HTR @ hex. cr
." ADC2_LTR: " ADC2_LTR @ hex. cr
." ADC2_SQR1: " ADC2_SQR1 @ hex. cr
." ADC2_SQR2: " ADC2_SQR2 @ hex. cr
." ADC2_SQR3: " ADC2_SQR3 @ hex. cr
." ADC2_JSQR: " ADC2_JSQR @ hex. cr
." ADC2_JDR1: " ADC2_JDR1 @ hex. cr
." ADC2_JDR2: " ADC2_JDR2 @ hex. cr
." ADC2_JDR3: " ADC2_JDR3 @ hex. cr
." ADC2_JDR4: " ADC2_JDR4 @ hex. cr
." ADC2_DR: " ADC2_DR @ hex. cr
;

: ADC3. cr
;

: CAN. cr
." CAN_CAN_MCR: " CAN_CAN_MCR @ hex. cr
." CAN_CAN_MSR: " CAN_CAN_MSR @ hex. cr
." CAN_CAN_TSR: " CAN_CAN_TSR @ hex. cr
." CAN_CAN_RF0R: " CAN_CAN_RF0R @ hex. cr
." CAN_CAN_RF1R: " CAN_CAN_RF1R @ hex. cr
." CAN_CAN_IER: " CAN_CAN_IER @ hex. cr
." CAN_CAN_ESR: " CAN_CAN_ESR @ hex. cr
." CAN_CAN_BTR: " CAN_CAN_BTR @ hex. cr
." CAN_CAN_TI0R: " CAN_CAN_TI0R @ hex. cr
." CAN_CAN_TDT0R: " CAN_CAN_TDT0R @ hex. cr
." CAN_CAN_TDL0R: " CAN_CAN_TDL0R @ hex. cr
." CAN_CAN_TDH0R: " CAN_CAN_TDH0R @ hex. cr
." CAN_CAN_TI1R: " CAN_CAN_TI1R @ hex. cr
." CAN_CAN_TDT1R: " CAN_CAN_TDT1R @ hex. cr
." CAN_CAN_TDL1R: " CAN_CAN_TDL1R @ hex. cr
." CAN_CAN_TDH1R: " CAN_CAN_TDH1R @ hex. cr
." CAN_CAN_TI2R: " CAN_CAN_TI2R @ hex. cr
." CAN_CAN_TDT2R: " CAN_CAN_TDT2R @ hex. cr
." CAN_CAN_TDL2R: " CAN_CAN_TDL2R @ hex. cr
." CAN_CAN_TDH2R: " CAN_CAN_TDH2R @ hex. cr
." CAN_CAN_RI0R: " CAN_CAN_RI0R @ hex. cr
." CAN_CAN_RDT0R: " CAN_CAN_RDT0R @ hex. cr
." CAN_CAN_RDL0R: " CAN_CAN_RDL0R @ hex. cr
." CAN_CAN_RDH0R: " CAN_CAN_RDH0R @ hex. cr
." CAN_CAN_RI1R: " CAN_CAN_RI1R @ hex. cr
." CAN_CAN_RDT1R: " CAN_CAN_RDT1R @ hex. cr
." CAN_CAN_RDL1R: " CAN_CAN_RDL1R @ hex. cr
." CAN_CAN_RDH1R: " CAN_CAN_RDH1R @ hex. cr
." CAN_CAN_FMR: " CAN_CAN_FMR @ hex. cr
." CAN_CAN_FM1R: " CAN_CAN_FM1R @ hex. cr
." CAN_CAN_FS1R: " CAN_CAN_FS1R @ hex. cr
." CAN_CAN_FFA1R: " CAN_CAN_FFA1R @ hex. cr
." CAN_CAN_FA1R: " CAN_CAN_FA1R @ hex. cr
." CAN_F0R1: " CAN_F0R1 @ hex. cr
." CAN_F0R2: " CAN_F0R2 @ hex. cr
." CAN_F1R1: " CAN_F1R1 @ hex. cr
." CAN_F1R2: " CAN_F1R2 @ hex. cr
." CAN_F2R1: " CAN_F2R1 @ hex. cr
." CAN_F2R2: " CAN_F2R2 @ hex. cr
." CAN_F3R1: " CAN_F3R1 @ hex. cr
." CAN_F3R2: " CAN_F3R2 @ hex. cr
." CAN_F4R1: " CAN_F4R1 @ hex. cr
." CAN_F4R2: " CAN_F4R2 @ hex. cr
." CAN_F5R1: " CAN_F5R1 @ hex. cr
." CAN_F5R2: " CAN_F5R2 @ hex. cr
." CAN_F6R1: " CAN_F6R1 @ hex. cr
." CAN_F6R2: " CAN_F6R2 @ hex. cr
." CAN_F7R1: " CAN_F7R1 @ hex. cr
." CAN_F7R2: " CAN_F7R2 @ hex. cr
." CAN_F8R1: " CAN_F8R1 @ hex. cr
." CAN_F8R2: " CAN_F8R2 @ hex. cr
." CAN_F9R1: " CAN_F9R1 @ hex. cr
." CAN_F9R2: " CAN_F9R2 @ hex. cr
." CAN_F10R1: " CAN_F10R1 @ hex. cr
." CAN_F10R2: " CAN_F10R2 @ hex. cr
." CAN_F11R1: " CAN_F11R1 @ hex. cr
." CAN_F11R2: " CAN_F11R2 @ hex. cr
." CAN_F12R1: " CAN_F12R1 @ hex. cr
." CAN_F12R2: " CAN_F12R2 @ hex. cr
." CAN_F13R1: " CAN_F13R1 @ hex. cr
." CAN_F13R2: " CAN_F13R2 @ hex. cr
;

: DAC. cr
." DAC_CR: " DAC_CR @ hex. cr
." DAC_SWTRIGR: " DAC_SWTRIGR @ hex. cr
." DAC_DHR12R1: " DAC_DHR12R1 @ hex. cr
." DAC_DHR12L1: " DAC_DHR12L1 @ hex. cr
." DAC_DHR8R1: " DAC_DHR8R1 @ hex. cr
." DAC_DHR12R2: " DAC_DHR12R2 @ hex. cr
." DAC_DHR12L2: " DAC_DHR12L2 @ hex. cr
." DAC_DHR8R2: " DAC_DHR8R2 @ hex. cr
." DAC_DHR12RD: " DAC_DHR12RD @ hex. cr
." DAC_DHR12LD: " DAC_DHR12LD @ hex. cr
." DAC_DHR8RD: " DAC_DHR8RD @ hex. cr
." DAC_DOR1: " DAC_DOR1 @ hex. cr
." DAC_DOR2: " DAC_DOR2 @ hex. cr
;

: DBG. cr
." DBG_IDCODE: " DBG_IDCODE @ hex. cr
." DBG_CR: " DBG_CR @ hex. cr
;

: UART4. cr
." UART4_SR: " UART4_SR @ hex. cr
." UART4_DR: " UART4_DR @ hex. cr
." UART4_BRR: " UART4_BRR @ hex. cr
." UART4_CR1: " UART4_CR1 @ hex. cr
." UART4_CR2: " UART4_CR2 @ hex. cr
." UART4_CR3: " UART4_CR3 @ hex. cr
;

: UART5. cr
." UART5_SR: " UART5_SR @ hex. cr
." UART5_DR: " UART5_DR @ hex. cr
." UART5_BRR: " UART5_BRR @ hex. cr
." UART5_CR1: " UART5_CR1 @ hex. cr
." UART5_CR2: " UART5_CR2 @ hex. cr
." UART5_CR3: " UART5_CR3 @ hex. cr
;

: CRC. cr
." CRC_DR: " CRC_DR @ hex. cr
." CRC_IDR: " CRC_IDR @ hex. cr
." CRC_CR: " CRC_CR @ hex. cr
;

: FLASH. cr
." FLASH_ACR: " FLASH_ACR @ hex. cr
." FLASH_KEYR: " FLASH_KEYR @ hex. cr
." FLASH_OPTKEYR: " FLASH_OPTKEYR @ hex. cr
." FLASH_SR: " FLASH_SR @ hex. cr
." FLASH_CR: " FLASH_CR @ hex. cr
." FLASH_AR: " FLASH_AR @ hex. cr
." FLASH_OBR: " FLASH_OBR @ hex. cr
." FLASH_WRPR: " FLASH_WRPR @ hex. cr
;

: NVIC. cr
." NVIC_ICTR: " NVIC_ICTR @ hex. cr
." NVIC_STIR: " NVIC_STIR @ hex. cr
." NVIC_ISER0: " NVIC_ISER0 @ hex. cr
." NVIC_ISER1: " NVIC_ISER1 @ hex. cr
." NVIC_ICER0: " NVIC_ICER0 @ hex. cr
." NVIC_ICER1: " NVIC_ICER1 @ hex. cr
." NVIC_ISPR0: " NVIC_ISPR0 @ hex. cr
." NVIC_ISPR1: " NVIC_ISPR1 @ hex. cr
." NVIC_ICPR0: " NVIC_ICPR0 @ hex. cr
." NVIC_ICPR1: " NVIC_ICPR1 @ hex. cr
." NVIC_IABR0: " NVIC_IABR0 @ hex. cr
." NVIC_IABR1: " NVIC_IABR1 @ hex. cr
." NVIC_IPR0: " NVIC_IPR0 @ hex. cr
." NVIC_IPR1: " NVIC_IPR1 @ hex. cr
." NVIC_IPR2: " NVIC_IPR2 @ hex. cr
." NVIC_IPR3: " NVIC_IPR3 @ hex. cr
." NVIC_IPR4: " NVIC_IPR4 @ hex. cr
." NVIC_IPR5: " NVIC_IPR5 @ hex. cr
." NVIC_IPR6: " NVIC_IPR6 @ hex. cr
." NVIC_IPR7: " NVIC_IPR7 @ hex. cr
." NVIC_IPR8: " NVIC_IPR8 @ hex. cr
." NVIC_IPR9: " NVIC_IPR9 @ hex. cr
." NVIC_IPR10: " NVIC_IPR10 @ hex. cr
." NVIC_IPR11: " NVIC_IPR11 @ hex. cr
." NVIC_IPR12: " NVIC_IPR12 @ hex. cr
." NVIC_IPR13: " NVIC_IPR13 @ hex. cr
." NVIC_IPR14: " NVIC_IPR14 @ hex. cr
;

: USB. cr
." USB_EP0R: " USB_EP0R @ hex. cr
." USB_EP1R: " USB_EP1R @ hex. cr
." USB_EP2R: " USB_EP2R @ hex. cr
." USB_EP3R: " USB_EP3R @ hex. cr
." USB_EP4R: " USB_EP4R @ hex. cr
." USB_EP5R: " USB_EP5R @ hex. cr
." USB_EP6R: " USB_EP6R @ hex. cr
." USB_EP7R: " USB_EP7R @ hex. cr
." USB_CNTR: " USB_CNTR @ hex. cr
." USB_ISTR: " USB_ISTR @ hex. cr
." USB_FNR: " USB_FNR @ hex. cr
." USB_DADDR: " USB_DADDR @ hex. cr
." USB_BTABLE: " USB_BTABLE @ hex. cr
;

