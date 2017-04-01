\ STM32F103xx Register Bitfields for Mecrisp-Stellaris Forth by Matthias Koch
\ By Terry Porter "terry@tjporter.com.au"
\ x = 0 or 1. Use as templates i.e.   "  %01  18 lshift GPIOC_MODER   bis!     \ GPIOC_MODER9  set  PC9 as output  " 

\ FSMC
\ FSMC_BCR1 read-write
$000030D0 CONSTANT RESET_FSMC_BCR1 
\ %1  19 lshift FSMC_BCR1        \ FSMC_CBURSTRW	Bit Offset:19	Bit Width:1
\ %1  15 lshift FSMC_BCR1        \ FSMC_ASYNCWAIT	Bit Offset:15	Bit Width:1
\ %1  14 lshift FSMC_BCR1        \ FSMC_EXTMOD	Bit Offset:14	Bit Width:1
\ %1  13 lshift FSMC_BCR1        \ FSMC_WAITEN	Bit Offset:13	Bit Width:1
\ %1  12 lshift FSMC_BCR1        \ FSMC_WREN	Bit Offset:12	Bit Width:1
\ %1  11 lshift FSMC_BCR1        \ FSMC_WAITCFG	Bit Offset:11	Bit Width:1
\ %1  9 lshift FSMC_BCR1        \ FSMC_WAITPOL	Bit Offset:9	Bit Width:1
\ %1  8 lshift FSMC_BCR1        \ FSMC_BURSTEN	Bit Offset:8	Bit Width:1
\ %1  6 lshift FSMC_BCR1        \ FSMC_FACCEN	Bit Offset:6	Bit Width:1
\ %xx  4 lshift FSMC_BCR1        \ FSMC_MWID	Bit Offset:4	Bit Width:2
\ %xx  2 lshift FSMC_BCR1        \ FSMC_MTYP	Bit Offset:2	Bit Width:2
\ %1  1 lshift FSMC_BCR1        \ FSMC_MUXEN	Bit Offset:1	Bit Width:1
\ %1  0 lshift FSMC_BCR1        \ FSMC_MBKEN	Bit Offset:0	Bit Width:1

\ FSMC_BTR1 read-write
$FFFFFFFF CONSTANT RESET_FSMC_BTR1 
\ %xx  28 lshift FSMC_BTR1        \ FSMC_ACCMOD	Bit Offset:28	Bit Width:2
\ %xxxx  24 lshift FSMC_BTR1        \ FSMC_DATLAT	Bit Offset:24	Bit Width:4
\ %xxxx  20 lshift FSMC_BTR1        \ FSMC_CLKDIV	Bit Offset:20	Bit Width:4
\ %xxxx  16 lshift FSMC_BTR1        \ FSMC_BUSTURN	Bit Offset:16	Bit Width:4
\ %xxxxxxxx  8 lshift FSMC_BTR1        \ FSMC_DATAST	Bit Offset:8	Bit Width:8
\ %xxxx  4 lshift FSMC_BTR1        \ FSMC_ADDHLD	Bit Offset:4	Bit Width:4
\ %xxxx  0 lshift FSMC_BTR1        \ FSMC_ADDSET	Bit Offset:0	Bit Width:4

\ FSMC_BCR2 read-write
$000030D0 CONSTANT RESET_FSMC_BCR2 
\ %1  19 lshift FSMC_BCR2        \ FSMC_CBURSTRW	Bit Offset:19	Bit Width:1
\ %1  15 lshift FSMC_BCR2        \ FSMC_ASYNCWAIT	Bit Offset:15	Bit Width:1
\ %1  14 lshift FSMC_BCR2        \ FSMC_EXTMOD	Bit Offset:14	Bit Width:1
\ %1  13 lshift FSMC_BCR2        \ FSMC_WAITEN	Bit Offset:13	Bit Width:1
\ %1  12 lshift FSMC_BCR2        \ FSMC_WREN	Bit Offset:12	Bit Width:1
\ %1  11 lshift FSMC_BCR2        \ FSMC_WAITCFG	Bit Offset:11	Bit Width:1
\ %1  10 lshift FSMC_BCR2        \ FSMC_WRAPMOD	Bit Offset:10	Bit Width:1
\ %1  9 lshift FSMC_BCR2        \ FSMC_WAITPOL	Bit Offset:9	Bit Width:1
\ %1  8 lshift FSMC_BCR2        \ FSMC_BURSTEN	Bit Offset:8	Bit Width:1
\ %1  6 lshift FSMC_BCR2        \ FSMC_FACCEN	Bit Offset:6	Bit Width:1
\ %xx  4 lshift FSMC_BCR2        \ FSMC_MWID	Bit Offset:4	Bit Width:2
\ %xx  2 lshift FSMC_BCR2        \ FSMC_MTYP	Bit Offset:2	Bit Width:2
\ %1  1 lshift FSMC_BCR2        \ FSMC_MUXEN	Bit Offset:1	Bit Width:1
\ %1  0 lshift FSMC_BCR2        \ FSMC_MBKEN	Bit Offset:0	Bit Width:1

\ FSMC_BTR2 read-write
$FFFFFFFF CONSTANT RESET_FSMC_BTR2 
\ %xx  28 lshift FSMC_BTR2        \ FSMC_ACCMOD	Bit Offset:28	Bit Width:2
\ %xxxx  24 lshift FSMC_BTR2        \ FSMC_DATLAT	Bit Offset:24	Bit Width:4
\ %xxxx  20 lshift FSMC_BTR2        \ FSMC_CLKDIV	Bit Offset:20	Bit Width:4
\ %xxxx  16 lshift FSMC_BTR2        \ FSMC_BUSTURN	Bit Offset:16	Bit Width:4
\ %xxxxxxxx  8 lshift FSMC_BTR2        \ FSMC_DATAST	Bit Offset:8	Bit Width:8
\ %xxxx  4 lshift FSMC_BTR2        \ FSMC_ADDHLD	Bit Offset:4	Bit Width:4
\ %xxxx  0 lshift FSMC_BTR2        \ FSMC_ADDSET	Bit Offset:0	Bit Width:4

\ FSMC_BCR3 read-write
$000030D0 CONSTANT RESET_FSMC_BCR3 
\ %1  19 lshift FSMC_BCR3        \ FSMC_CBURSTRW	Bit Offset:19	Bit Width:1
\ %1  15 lshift FSMC_BCR3        \ FSMC_ASYNCWAIT	Bit Offset:15	Bit Width:1
\ %1  14 lshift FSMC_BCR3        \ FSMC_EXTMOD	Bit Offset:14	Bit Width:1
\ %1  13 lshift FSMC_BCR3        \ FSMC_WAITEN	Bit Offset:13	Bit Width:1
\ %1  12 lshift FSMC_BCR3        \ FSMC_WREN	Bit Offset:12	Bit Width:1
\ %1  11 lshift FSMC_BCR3        \ FSMC_WAITCFG	Bit Offset:11	Bit Width:1
\ %1  10 lshift FSMC_BCR3        \ FSMC_WRAPMOD	Bit Offset:10	Bit Width:1
\ %1  9 lshift FSMC_BCR3        \ FSMC_WAITPOL	Bit Offset:9	Bit Width:1
\ %1  8 lshift FSMC_BCR3        \ FSMC_BURSTEN	Bit Offset:8	Bit Width:1
\ %1  6 lshift FSMC_BCR3        \ FSMC_FACCEN	Bit Offset:6	Bit Width:1
\ %xx  4 lshift FSMC_BCR3        \ FSMC_MWID	Bit Offset:4	Bit Width:2
\ %xx  2 lshift FSMC_BCR3        \ FSMC_MTYP	Bit Offset:2	Bit Width:2
\ %1  1 lshift FSMC_BCR3        \ FSMC_MUXEN	Bit Offset:1	Bit Width:1
\ %1  0 lshift FSMC_BCR3        \ FSMC_MBKEN	Bit Offset:0	Bit Width:1

\ FSMC_BTR3 read-write
$FFFFFFFF CONSTANT RESET_FSMC_BTR3 
\ %xx  28 lshift FSMC_BTR3        \ FSMC_ACCMOD	Bit Offset:28	Bit Width:2
\ %xxxx  24 lshift FSMC_BTR3        \ FSMC_DATLAT	Bit Offset:24	Bit Width:4
\ %xxxx  20 lshift FSMC_BTR3        \ FSMC_CLKDIV	Bit Offset:20	Bit Width:4
\ %xxxx  16 lshift FSMC_BTR3        \ FSMC_BUSTURN	Bit Offset:16	Bit Width:4
\ %xxxxxxxx  8 lshift FSMC_BTR3        \ FSMC_DATAST	Bit Offset:8	Bit Width:8
\ %xxxx  4 lshift FSMC_BTR3        \ FSMC_ADDHLD	Bit Offset:4	Bit Width:4
\ %xxxx  0 lshift FSMC_BTR3        \ FSMC_ADDSET	Bit Offset:0	Bit Width:4

\ FSMC_BCR4 read-write
$000030D0 CONSTANT RESET_FSMC_BCR4 
\ %1  19 lshift FSMC_BCR4        \ FSMC_CBURSTRW	Bit Offset:19	Bit Width:1
\ %1  15 lshift FSMC_BCR4        \ FSMC_ASYNCWAIT	Bit Offset:15	Bit Width:1
\ %1  14 lshift FSMC_BCR4        \ FSMC_EXTMOD	Bit Offset:14	Bit Width:1
\ %1  13 lshift FSMC_BCR4        \ FSMC_WAITEN	Bit Offset:13	Bit Width:1
\ %1  12 lshift FSMC_BCR4        \ FSMC_WREN	Bit Offset:12	Bit Width:1
\ %1  11 lshift FSMC_BCR4        \ FSMC_WAITCFG	Bit Offset:11	Bit Width:1
\ %1  10 lshift FSMC_BCR4        \ FSMC_WRAPMOD	Bit Offset:10	Bit Width:1
\ %1  9 lshift FSMC_BCR4        \ FSMC_WAITPOL	Bit Offset:9	Bit Width:1
\ %1  8 lshift FSMC_BCR4        \ FSMC_BURSTEN	Bit Offset:8	Bit Width:1
\ %1  6 lshift FSMC_BCR4        \ FSMC_FACCEN	Bit Offset:6	Bit Width:1
\ %xx  4 lshift FSMC_BCR4        \ FSMC_MWID	Bit Offset:4	Bit Width:2
\ %xx  2 lshift FSMC_BCR4        \ FSMC_MTYP	Bit Offset:2	Bit Width:2
\ %1  1 lshift FSMC_BCR4        \ FSMC_MUXEN	Bit Offset:1	Bit Width:1
\ %1  0 lshift FSMC_BCR4        \ FSMC_MBKEN	Bit Offset:0	Bit Width:1

\ FSMC_BTR4 read-write
$FFFFFFFF CONSTANT RESET_FSMC_BTR4 
\ %xx  28 lshift FSMC_BTR4        \ FSMC_ACCMOD	Bit Offset:28	Bit Width:2
\ %xxxx  24 lshift FSMC_BTR4        \ FSMC_DATLAT	Bit Offset:24	Bit Width:4
\ %xxxx  20 lshift FSMC_BTR4        \ FSMC_CLKDIV	Bit Offset:20	Bit Width:4
\ %xxxx  16 lshift FSMC_BTR4        \ FSMC_BUSTURN	Bit Offset:16	Bit Width:4
\ %xxxxxxxx  8 lshift FSMC_BTR4        \ FSMC_DATAST	Bit Offset:8	Bit Width:8
\ %xxxx  4 lshift FSMC_BTR4        \ FSMC_ADDHLD	Bit Offset:4	Bit Width:4
\ %xxxx  0 lshift FSMC_BTR4        \ FSMC_ADDSET	Bit Offset:0	Bit Width:4

\ FSMC_PCR2 read-write
$00000018 CONSTANT RESET_FSMC_PCR2 
\ %xxx  17 lshift FSMC_PCR2        \ FSMC_ECCPS	Bit Offset:17	Bit Width:3
\ %xxxx  13 lshift FSMC_PCR2        \ FSMC_TAR	Bit Offset:13	Bit Width:4
\ %xxxx  9 lshift FSMC_PCR2        \ FSMC_TCLR	Bit Offset:9	Bit Width:4
\ %1  6 lshift FSMC_PCR2        \ FSMC_ECCEN	Bit Offset:6	Bit Width:1
\ %xx  4 lshift FSMC_PCR2        \ FSMC_PWID	Bit Offset:4	Bit Width:2
\ %1  3 lshift FSMC_PCR2        \ FSMC_PTYP	Bit Offset:3	Bit Width:1
\ %1  2 lshift FSMC_PCR2        \ FSMC_PBKEN	Bit Offset:2	Bit Width:1
\ %1  1 lshift FSMC_PCR2        \ FSMC_PWAITEN	Bit Offset:1	Bit Width:1

\ FSMC_SR2 
$00000040 CONSTANT RESET_FSMC_SR2 
\ %1  6 lshift FSMC_SR2        \ FSMC_FEMPT	Bit Offset:6	Bit Width:1
\ %1  5 lshift FSMC_SR2        \ FSMC_IFEN	Bit Offset:5	Bit Width:1
\ %1  4 lshift FSMC_SR2        \ FSMC_ILEN	Bit Offset:4	Bit Width:1
\ %1  3 lshift FSMC_SR2        \ FSMC_IREN	Bit Offset:3	Bit Width:1
\ %1  2 lshift FSMC_SR2        \ FSMC_IFS	Bit Offset:2	Bit Width:1
\ %1  1 lshift FSMC_SR2        \ FSMC_ILS	Bit Offset:1	Bit Width:1
\ %1  0 lshift FSMC_SR2        \ FSMC_IRS	Bit Offset:0	Bit Width:1

\ FSMC_PMEM2 read-write
$FCFCFCFC CONSTANT RESET_FSMC_PMEM2 
\ %xxxxxxxx  24 lshift FSMC_PMEM2        \ FSMC_MEMHIZx	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift FSMC_PMEM2        \ FSMC_MEMHOLDx	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift FSMC_PMEM2        \ FSMC_MEMWAITx	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift FSMC_PMEM2        \ FSMC_MEMSETx	Bit Offset:0	Bit Width:8

\ FSMC_PATT2 read-write
$FCFCFCFC CONSTANT RESET_FSMC_PATT2 
\ %xxxxxxxx  24 lshift FSMC_PATT2        \ FSMC_ATTHIZx	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift FSMC_PATT2        \ FSMC_ATTHOLDx	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift FSMC_PATT2        \ FSMC_ATTWAITx	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift FSMC_PATT2        \ FSMC_ATTSETx	Bit Offset:0	Bit Width:8

\ FSMC_ECCR2 read-only
$00000000 CONSTANT RESET_FSMC_ECCR2 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift FSMC_ECCR2        \ FSMC_ECCx	Bit Offset:0	Bit Width:32

\ FSMC_PCR3 read-write
$00000018 CONSTANT RESET_FSMC_PCR3 
\ %xxx  17 lshift FSMC_PCR3        \ FSMC_ECCPS	Bit Offset:17	Bit Width:3
\ %xxxx  13 lshift FSMC_PCR3        \ FSMC_TAR	Bit Offset:13	Bit Width:4
\ %xxxx  9 lshift FSMC_PCR3        \ FSMC_TCLR	Bit Offset:9	Bit Width:4
\ %1  6 lshift FSMC_PCR3        \ FSMC_ECCEN	Bit Offset:6	Bit Width:1
\ %xx  4 lshift FSMC_PCR3        \ FSMC_PWID	Bit Offset:4	Bit Width:2
\ %1  3 lshift FSMC_PCR3        \ FSMC_PTYP	Bit Offset:3	Bit Width:1
\ %1  2 lshift FSMC_PCR3        \ FSMC_PBKEN	Bit Offset:2	Bit Width:1
\ %1  1 lshift FSMC_PCR3        \ FSMC_PWAITEN	Bit Offset:1	Bit Width:1

\ FSMC_SR3 
$00000040 CONSTANT RESET_FSMC_SR3 
\ %1  6 lshift FSMC_SR3        \ FSMC_FEMPT	Bit Offset:6	Bit Width:1
\ %1  5 lshift FSMC_SR3        \ FSMC_IFEN	Bit Offset:5	Bit Width:1
\ %1  4 lshift FSMC_SR3        \ FSMC_ILEN	Bit Offset:4	Bit Width:1
\ %1  3 lshift FSMC_SR3        \ FSMC_IREN	Bit Offset:3	Bit Width:1
\ %1  2 lshift FSMC_SR3        \ FSMC_IFS	Bit Offset:2	Bit Width:1
\ %1  1 lshift FSMC_SR3        \ FSMC_ILS	Bit Offset:1	Bit Width:1
\ %1  0 lshift FSMC_SR3        \ FSMC_IRS	Bit Offset:0	Bit Width:1

\ FSMC_PMEM3 read-write
$FCFCFCFC CONSTANT RESET_FSMC_PMEM3 
\ %xxxxxxxx  24 lshift FSMC_PMEM3        \ FSMC_MEMHIZx	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift FSMC_PMEM3        \ FSMC_MEMHOLDx	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift FSMC_PMEM3        \ FSMC_MEMWAITx	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift FSMC_PMEM3        \ FSMC_MEMSETx	Bit Offset:0	Bit Width:8

\ FSMC_PATT3 read-write
$FCFCFCFC CONSTANT RESET_FSMC_PATT3 
\ %xxxxxxxx  24 lshift FSMC_PATT3        \ FSMC_ATTHIZx	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift FSMC_PATT3        \ FSMC_ATTHOLDx	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift FSMC_PATT3        \ FSMC_ATTWAITx	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift FSMC_PATT3        \ FSMC_ATTSETx	Bit Offset:0	Bit Width:8

\ FSMC_ECCR3 read-only
$00000000 CONSTANT RESET_FSMC_ECCR3 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift FSMC_ECCR3        \ FSMC_ECCx	Bit Offset:0	Bit Width:32

\ FSMC_PCR4 read-write
$00000018 CONSTANT RESET_FSMC_PCR4 
\ %xxx  17 lshift FSMC_PCR4        \ FSMC_ECCPS	Bit Offset:17	Bit Width:3
\ %xxxx  13 lshift FSMC_PCR4        \ FSMC_TAR	Bit Offset:13	Bit Width:4
\ %xxxx  9 lshift FSMC_PCR4        \ FSMC_TCLR	Bit Offset:9	Bit Width:4
\ %1  6 lshift FSMC_PCR4        \ FSMC_ECCEN	Bit Offset:6	Bit Width:1
\ %xx  4 lshift FSMC_PCR4        \ FSMC_PWID	Bit Offset:4	Bit Width:2
\ %1  3 lshift FSMC_PCR4        \ FSMC_PTYP	Bit Offset:3	Bit Width:1
\ %1  2 lshift FSMC_PCR4        \ FSMC_PBKEN	Bit Offset:2	Bit Width:1
\ %1  1 lshift FSMC_PCR4        \ FSMC_PWAITEN	Bit Offset:1	Bit Width:1

\ FSMC_SR4 
$00000040 CONSTANT RESET_FSMC_SR4 
\ %1  6 lshift FSMC_SR4        \ FSMC_FEMPT	Bit Offset:6	Bit Width:1
\ %1  5 lshift FSMC_SR4        \ FSMC_IFEN	Bit Offset:5	Bit Width:1
\ %1  4 lshift FSMC_SR4        \ FSMC_ILEN	Bit Offset:4	Bit Width:1
\ %1  3 lshift FSMC_SR4        \ FSMC_IREN	Bit Offset:3	Bit Width:1
\ %1  2 lshift FSMC_SR4        \ FSMC_IFS	Bit Offset:2	Bit Width:1
\ %1  1 lshift FSMC_SR4        \ FSMC_ILS	Bit Offset:1	Bit Width:1
\ %1  0 lshift FSMC_SR4        \ FSMC_IRS	Bit Offset:0	Bit Width:1

\ FSMC_PMEM4 read-write
$FCFCFCFC CONSTANT RESET_FSMC_PMEM4 
\ %xxxxxxxx  24 lshift FSMC_PMEM4        \ FSMC_MEMHIZx	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift FSMC_PMEM4        \ FSMC_MEMHOLDx	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift FSMC_PMEM4        \ FSMC_MEMWAITx	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift FSMC_PMEM4        \ FSMC_MEMSETx	Bit Offset:0	Bit Width:8

\ FSMC_PATT4 read-write
$FCFCFCFC CONSTANT RESET_FSMC_PATT4 
\ %xxxxxxxx  24 lshift FSMC_PATT4        \ FSMC_ATTHIZx	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift FSMC_PATT4        \ FSMC_ATTHOLDx	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift FSMC_PATT4        \ FSMC_ATTWAITx	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift FSMC_PATT4        \ FSMC_ATTSETx	Bit Offset:0	Bit Width:8

\ FSMC_PIO4 read-write
$FCFCFCFC CONSTANT RESET_FSMC_PIO4 
\ %xxxxxxxx  24 lshift FSMC_PIO4        \ FSMC_IOHIZx	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift FSMC_PIO4        \ FSMC_IOHOLDx	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift FSMC_PIO4        \ FSMC_IOWAITx	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift FSMC_PIO4        \ FSMC_IOSETx	Bit Offset:0	Bit Width:8

\ FSMC_BWTR1 read-write
$0FFFFFFF CONSTANT RESET_FSMC_BWTR1 
\ %xx  28 lshift FSMC_BWTR1        \ FSMC_ACCMOD	Bit Offset:28	Bit Width:2
\ %xxxx  24 lshift FSMC_BWTR1        \ FSMC_DATLAT	Bit Offset:24	Bit Width:4
\ %xxxx  20 lshift FSMC_BWTR1        \ FSMC_CLKDIV	Bit Offset:20	Bit Width:4
\ %xxxxxxxx  8 lshift FSMC_BWTR1        \ FSMC_DATAST	Bit Offset:8	Bit Width:8
\ %xxxx  4 lshift FSMC_BWTR1        \ FSMC_ADDHLD	Bit Offset:4	Bit Width:4
\ %xxxx  0 lshift FSMC_BWTR1        \ FSMC_ADDSET	Bit Offset:0	Bit Width:4

\ FSMC_BWTR2 read-write
$0FFFFFFF CONSTANT RESET_FSMC_BWTR2 
\ %xx  28 lshift FSMC_BWTR2        \ FSMC_ACCMOD	Bit Offset:28	Bit Width:2
\ %xxxx  24 lshift FSMC_BWTR2        \ FSMC_DATLAT	Bit Offset:24	Bit Width:4
\ %xxxx  20 lshift FSMC_BWTR2        \ FSMC_CLKDIV	Bit Offset:20	Bit Width:4
\ %xxxxxxxx  8 lshift FSMC_BWTR2        \ FSMC_DATAST	Bit Offset:8	Bit Width:8
\ %xxxx  4 lshift FSMC_BWTR2        \ FSMC_ADDHLD	Bit Offset:4	Bit Width:4
\ %xxxx  0 lshift FSMC_BWTR2        \ FSMC_ADDSET	Bit Offset:0	Bit Width:4

\ FSMC_BWTR3 read-write
$0FFFFFFF CONSTANT RESET_FSMC_BWTR3 
\ %xx  28 lshift FSMC_BWTR3        \ FSMC_ACCMOD	Bit Offset:28	Bit Width:2
\ %xxxx  24 lshift FSMC_BWTR3        \ FSMC_DATLAT	Bit Offset:24	Bit Width:4
\ %xxxx  20 lshift FSMC_BWTR3        \ FSMC_CLKDIV	Bit Offset:20	Bit Width:4
\ %xxxxxxxx  8 lshift FSMC_BWTR3        \ FSMC_DATAST	Bit Offset:8	Bit Width:8
\ %xxxx  4 lshift FSMC_BWTR3        \ FSMC_ADDHLD	Bit Offset:4	Bit Width:4
\ %xxxx  0 lshift FSMC_BWTR3        \ FSMC_ADDSET	Bit Offset:0	Bit Width:4

\ FSMC_BWTR4 read-write
$0FFFFFFF CONSTANT RESET_FSMC_BWTR4 
\ %xx  28 lshift FSMC_BWTR4        \ FSMC_ACCMOD	Bit Offset:28	Bit Width:2
\ %xxxx  24 lshift FSMC_BWTR4        \ FSMC_DATLAT	Bit Offset:24	Bit Width:4
\ %xxxx  20 lshift FSMC_BWTR4        \ FSMC_CLKDIV	Bit Offset:20	Bit Width:4
\ %xxxxxxxx  8 lshift FSMC_BWTR4        \ FSMC_DATAST	Bit Offset:8	Bit Width:8
\ %xxxx  4 lshift FSMC_BWTR4        \ FSMC_ADDHLD	Bit Offset:4	Bit Width:4
\ %xxxx  0 lshift FSMC_BWTR4        \ FSMC_ADDSET	Bit Offset:0	Bit Width:4

  
\ PWR
\ PWR_CR read-write
$00000000 CONSTANT RESET_PWR_CR 
\ %1  0 lshift PWR_CR        \ PWR_LPDS	Bit Offset:0	Bit Width:1
\ %1  1 lshift PWR_CR        \ PWR_PDDS	Bit Offset:1	Bit Width:1
\ %1  2 lshift PWR_CR        \ PWR_CWUF	Bit Offset:2	Bit Width:1
\ %1  3 lshift PWR_CR        \ PWR_CSBF	Bit Offset:3	Bit Width:1
\ %1  4 lshift PWR_CR        \ PWR_PVDE	Bit Offset:4	Bit Width:1
\ %xxx  5 lshift PWR_CR        \ PWR_PLS	Bit Offset:5	Bit Width:3
\ %1  8 lshift PWR_CR        \ PWR_DBP	Bit Offset:8	Bit Width:1

\ PWR_CSR 
$00000000 CONSTANT RESET_PWR_CSR 
\ %1  0 lshift PWR_CSR        \ PWR_WUF	Bit Offset:0	Bit Width:1
\ %1  1 lshift PWR_CSR        \ PWR_SBF	Bit Offset:1	Bit Width:1
\ %1  2 lshift PWR_CSR        \ PWR_PVDO	Bit Offset:2	Bit Width:1
\ %1  8 lshift PWR_CSR        \ PWR_EWUP	Bit Offset:8	Bit Width:1

  
\ RCC
\ RCC_CR 
$00000083 CONSTANT RESET_RCC_CR 
\ %1  0 lshift RCC_CR        \ RCC_HSION	Bit Offset:0	Bit Width:1
\ %1  1 lshift RCC_CR        \ RCC_HSIRDY	Bit Offset:1	Bit Width:1
\ %xxxxx  3 lshift RCC_CR        \ RCC_HSITRIM	Bit Offset:3	Bit Width:5
\ %xxxxxxxx  8 lshift RCC_CR        \ RCC_HSICAL	Bit Offset:8	Bit Width:8
\ %1  16 lshift RCC_CR        \ RCC_HSEON	Bit Offset:16	Bit Width:1
\ %1  17 lshift RCC_CR        \ RCC_HSERDY	Bit Offset:17	Bit Width:1
\ %1  18 lshift RCC_CR        \ RCC_HSEBYP	Bit Offset:18	Bit Width:1
\ %1  19 lshift RCC_CR        \ RCC_CSSON	Bit Offset:19	Bit Width:1
\ %1  24 lshift RCC_CR        \ RCC_PLLON	Bit Offset:24	Bit Width:1
\ %1  25 lshift RCC_CR        \ RCC_PLLRDY	Bit Offset:25	Bit Width:1

\ RCC_CFGR 
$00000000 CONSTANT RESET_RCC_CFGR 
\ %xx  0 lshift RCC_CFGR        \ RCC_SW	Bit Offset:0	Bit Width:2
\ %xx  2 lshift RCC_CFGR        \ RCC_SWS	Bit Offset:2	Bit Width:2
\ %xxxx  4 lshift RCC_CFGR        \ RCC_HPRE	Bit Offset:4	Bit Width:4
\ %xxx  8 lshift RCC_CFGR        \ RCC_PPRE1	Bit Offset:8	Bit Width:3
\ %xxx  11 lshift RCC_CFGR        \ RCC_PPRE2	Bit Offset:11	Bit Width:3
\ %xx  14 lshift RCC_CFGR        \ RCC_ADCPRE	Bit Offset:14	Bit Width:2
\ %1  16 lshift RCC_CFGR        \ RCC_PLLSRC	Bit Offset:16	Bit Width:1
\ %1  17 lshift RCC_CFGR        \ RCC_PLLXTPRE	Bit Offset:17	Bit Width:1
\ %xxxx  18 lshift RCC_CFGR        \ RCC_PLLMUL	Bit Offset:18	Bit Width:4
\ %1  22 lshift RCC_CFGR        \ RCC_OTGFSPRE	Bit Offset:22	Bit Width:1
\ %xxx  24 lshift RCC_CFGR        \ RCC_MCO	Bit Offset:24	Bit Width:3

\ RCC_CIR 
$00000000 CONSTANT RESET_RCC_CIR 
\ %1  0 lshift RCC_CIR        \ RCC_LSIRDYF	Bit Offset:0	Bit Width:1
\ %1  1 lshift RCC_CIR        \ RCC_LSERDYF	Bit Offset:1	Bit Width:1
\ %1  2 lshift RCC_CIR        \ RCC_HSIRDYF	Bit Offset:2	Bit Width:1
\ %1  3 lshift RCC_CIR        \ RCC_HSERDYF	Bit Offset:3	Bit Width:1
\ %1  4 lshift RCC_CIR        \ RCC_PLLRDYF	Bit Offset:4	Bit Width:1
\ %1  7 lshift RCC_CIR        \ RCC_CSSF	Bit Offset:7	Bit Width:1
\ %1  8 lshift RCC_CIR        \ RCC_LSIRDYIE	Bit Offset:8	Bit Width:1
\ %1  9 lshift RCC_CIR        \ RCC_LSERDYIE	Bit Offset:9	Bit Width:1
\ %1  10 lshift RCC_CIR        \ RCC_HSIRDYIE	Bit Offset:10	Bit Width:1
\ %1  11 lshift RCC_CIR        \ RCC_HSERDYIE	Bit Offset:11	Bit Width:1
\ %1  12 lshift RCC_CIR        \ RCC_PLLRDYIE	Bit Offset:12	Bit Width:1
\ %1  16 lshift RCC_CIR        \ RCC_LSIRDYC	Bit Offset:16	Bit Width:1
\ %1  17 lshift RCC_CIR        \ RCC_LSERDYC	Bit Offset:17	Bit Width:1
\ %1  18 lshift RCC_CIR        \ RCC_HSIRDYC	Bit Offset:18	Bit Width:1
\ %1  19 lshift RCC_CIR        \ RCC_HSERDYC	Bit Offset:19	Bit Width:1
\ %1  20 lshift RCC_CIR        \ RCC_PLLRDYC	Bit Offset:20	Bit Width:1
\ %1  23 lshift RCC_CIR        \ RCC_CSSC	Bit Offset:23	Bit Width:1

\ RCC_APB2RSTR read-write
$000000000 CONSTANT RESET_RCC_APB2RSTR 
\ %1  0 lshift RCC_APB2RSTR        \ RCC_AFIORST	Bit Offset:0	Bit Width:1
\ %1  2 lshift RCC_APB2RSTR        \ RCC_IOPARST	Bit Offset:2	Bit Width:1
\ %1  3 lshift RCC_APB2RSTR        \ RCC_IOPBRST	Bit Offset:3	Bit Width:1
\ %1  4 lshift RCC_APB2RSTR        \ RCC_IOPCRST	Bit Offset:4	Bit Width:1
\ %1  5 lshift RCC_APB2RSTR        \ RCC_IOPDRST	Bit Offset:5	Bit Width:1
\ %1  6 lshift RCC_APB2RSTR        \ RCC_IOPERST	Bit Offset:6	Bit Width:1
\ %1  7 lshift RCC_APB2RSTR        \ RCC_IOPFRST	Bit Offset:7	Bit Width:1
\ %1  8 lshift RCC_APB2RSTR        \ RCC_IOPGRST	Bit Offset:8	Bit Width:1
\ %1  9 lshift RCC_APB2RSTR        \ RCC_ADC1RST	Bit Offset:9	Bit Width:1
\ %1  10 lshift RCC_APB2RSTR        \ RCC_ADC2RST	Bit Offset:10	Bit Width:1
\ %1  11 lshift RCC_APB2RSTR        \ RCC_TIM1RST	Bit Offset:11	Bit Width:1
\ %1  12 lshift RCC_APB2RSTR        \ RCC_SPI1RST	Bit Offset:12	Bit Width:1
\ %1  13 lshift RCC_APB2RSTR        \ RCC_TIM8RST	Bit Offset:13	Bit Width:1
\ %1  14 lshift RCC_APB2RSTR        \ RCC_USART1RST	Bit Offset:14	Bit Width:1
\ %1  15 lshift RCC_APB2RSTR        \ RCC_ADC3RST	Bit Offset:15	Bit Width:1
\ %1  19 lshift RCC_APB2RSTR        \ RCC_TIM9RST	Bit Offset:19	Bit Width:1
\ %1  20 lshift RCC_APB2RSTR        \ RCC_TIM10RST	Bit Offset:20	Bit Width:1
\ %1  21 lshift RCC_APB2RSTR        \ RCC_TIM11RST	Bit Offset:21	Bit Width:1

\ RCC_APB1RSTR read-write
$00000000 CONSTANT RESET_RCC_APB1RSTR 
\ %1  0 lshift RCC_APB1RSTR        \ RCC_TIM2RST	Bit Offset:0	Bit Width:1
\ %1  1 lshift RCC_APB1RSTR        \ RCC_TIM3RST	Bit Offset:1	Bit Width:1
\ %1  2 lshift RCC_APB1RSTR        \ RCC_TIM4RST	Bit Offset:2	Bit Width:1
\ %1  3 lshift RCC_APB1RSTR        \ RCC_TIM5RST	Bit Offset:3	Bit Width:1
\ %1  4 lshift RCC_APB1RSTR        \ RCC_TIM6RST	Bit Offset:4	Bit Width:1
\ %1  5 lshift RCC_APB1RSTR        \ RCC_TIM7RST	Bit Offset:5	Bit Width:1
\ %1  6 lshift RCC_APB1RSTR        \ RCC_TIM12RST	Bit Offset:6	Bit Width:1
\ %1  7 lshift RCC_APB1RSTR        \ RCC_TIM13RST	Bit Offset:7	Bit Width:1
\ %1  8 lshift RCC_APB1RSTR        \ RCC_TIM14RST	Bit Offset:8	Bit Width:1
\ %1  11 lshift RCC_APB1RSTR        \ RCC_WWDGRST	Bit Offset:11	Bit Width:1
\ %1  14 lshift RCC_APB1RSTR        \ RCC_SPI2RST	Bit Offset:14	Bit Width:1
\ %1  15 lshift RCC_APB1RSTR        \ RCC_SPI3RST	Bit Offset:15	Bit Width:1
\ %1  17 lshift RCC_APB1RSTR        \ RCC_USART2RST	Bit Offset:17	Bit Width:1
\ %1  18 lshift RCC_APB1RSTR        \ RCC_USART3RST	Bit Offset:18	Bit Width:1
\ %1  19 lshift RCC_APB1RSTR        \ RCC_UART4RST	Bit Offset:19	Bit Width:1
\ %1  20 lshift RCC_APB1RSTR        \ RCC_UART5RST	Bit Offset:20	Bit Width:1
\ %1  21 lshift RCC_APB1RSTR        \ RCC_I2C1RST	Bit Offset:21	Bit Width:1
\ %1  22 lshift RCC_APB1RSTR        \ RCC_I2C2RST	Bit Offset:22	Bit Width:1
\ %1  23 lshift RCC_APB1RSTR        \ RCC_USBRST	Bit Offset:23	Bit Width:1
\ %1  25 lshift RCC_APB1RSTR        \ RCC_CANRST	Bit Offset:25	Bit Width:1
\ %1  27 lshift RCC_APB1RSTR        \ RCC_BKPRST	Bit Offset:27	Bit Width:1
\ %1  28 lshift RCC_APB1RSTR        \ RCC_PWRRST	Bit Offset:28	Bit Width:1
\ %1  29 lshift RCC_APB1RSTR        \ RCC_DACRST	Bit Offset:29	Bit Width:1

\ RCC_AHBENR read-write
$00000014 CONSTANT RESET_RCC_AHBENR 
\ %1  0 lshift RCC_AHBENR        \ RCC_DMA1EN	Bit Offset:0	Bit Width:1
\ %1  1 lshift RCC_AHBENR        \ RCC_DMA2EN	Bit Offset:1	Bit Width:1
\ %1  2 lshift RCC_AHBENR        \ RCC_SRAMEN	Bit Offset:2	Bit Width:1
\ %1  4 lshift RCC_AHBENR        \ RCC_FLITFEN	Bit Offset:4	Bit Width:1
\ %1  6 lshift RCC_AHBENR        \ RCC_CRCEN	Bit Offset:6	Bit Width:1
\ %1  8 lshift RCC_AHBENR        \ RCC_FSMCEN	Bit Offset:8	Bit Width:1
\ %1  10 lshift RCC_AHBENR        \ RCC_SDIOEN	Bit Offset:10	Bit Width:1

\ RCC_APB2ENR read-write
$00000000 CONSTANT RESET_RCC_APB2ENR 
\ %1  0 lshift RCC_APB2ENR        \ RCC_AFIOEN	Bit Offset:0	Bit Width:1
\ %1  2 lshift RCC_APB2ENR        \ RCC_IOPAEN	Bit Offset:2	Bit Width:1
\ %1  3 lshift RCC_APB2ENR        \ RCC_IOPBEN	Bit Offset:3	Bit Width:1
\ %1  4 lshift RCC_APB2ENR        \ RCC_IOPCEN	Bit Offset:4	Bit Width:1
\ %1  5 lshift RCC_APB2ENR        \ RCC_IOPDEN	Bit Offset:5	Bit Width:1
\ %1  6 lshift RCC_APB2ENR        \ RCC_IOPEEN	Bit Offset:6	Bit Width:1
\ %1  7 lshift RCC_APB2ENR        \ RCC_IOPFEN	Bit Offset:7	Bit Width:1
\ %1  8 lshift RCC_APB2ENR        \ RCC_IOPGEN	Bit Offset:8	Bit Width:1
\ %1  9 lshift RCC_APB2ENR        \ RCC_ADC1EN	Bit Offset:9	Bit Width:1
\ %1  10 lshift RCC_APB2ENR        \ RCC_ADC2EN	Bit Offset:10	Bit Width:1
\ %1  11 lshift RCC_APB2ENR        \ RCC_TIM1EN	Bit Offset:11	Bit Width:1
\ %1  12 lshift RCC_APB2ENR        \ RCC_SPI1EN	Bit Offset:12	Bit Width:1
\ %1  13 lshift RCC_APB2ENR        \ RCC_TIM8EN	Bit Offset:13	Bit Width:1
\ %1  14 lshift RCC_APB2ENR        \ RCC_USART1EN	Bit Offset:14	Bit Width:1
\ %1  15 lshift RCC_APB2ENR        \ RCC_ADC3EN	Bit Offset:15	Bit Width:1
\ %1  19 lshift RCC_APB2ENR        \ RCC_TIM9EN	Bit Offset:19	Bit Width:1
\ %1  20 lshift RCC_APB2ENR        \ RCC_TIM10EN	Bit Offset:20	Bit Width:1
\ %1  21 lshift RCC_APB2ENR        \ RCC_TIM11EN	Bit Offset:21	Bit Width:1

\ RCC_APB1ENR read-write
$00000000 CONSTANT RESET_RCC_APB1ENR 
\ %1  0 lshift RCC_APB1ENR        \ RCC_TIM2EN	Bit Offset:0	Bit Width:1
\ %1  1 lshift RCC_APB1ENR        \ RCC_TIM3EN	Bit Offset:1	Bit Width:1
\ %1  2 lshift RCC_APB1ENR        \ RCC_TIM4EN	Bit Offset:2	Bit Width:1
\ %1  3 lshift RCC_APB1ENR        \ RCC_TIM5EN	Bit Offset:3	Bit Width:1
\ %1  4 lshift RCC_APB1ENR        \ RCC_TIM6EN	Bit Offset:4	Bit Width:1
\ %1  5 lshift RCC_APB1ENR        \ RCC_TIM7EN	Bit Offset:5	Bit Width:1
\ %1  6 lshift RCC_APB1ENR        \ RCC_TIM12EN	Bit Offset:6	Bit Width:1
\ %1  7 lshift RCC_APB1ENR        \ RCC_TIM13EN	Bit Offset:7	Bit Width:1
\ %1  8 lshift RCC_APB1ENR        \ RCC_TIM14EN	Bit Offset:8	Bit Width:1
\ %1  11 lshift RCC_APB1ENR        \ RCC_WWDGEN	Bit Offset:11	Bit Width:1
\ %1  14 lshift RCC_APB1ENR        \ RCC_SPI2EN	Bit Offset:14	Bit Width:1
\ %1  15 lshift RCC_APB1ENR        \ RCC_SPI3EN	Bit Offset:15	Bit Width:1
\ %1  17 lshift RCC_APB1ENR        \ RCC_USART2EN	Bit Offset:17	Bit Width:1
\ %1  18 lshift RCC_APB1ENR        \ RCC_USART3EN	Bit Offset:18	Bit Width:1
\ %1  19 lshift RCC_APB1ENR        \ RCC_UART4EN	Bit Offset:19	Bit Width:1
\ %1  20 lshift RCC_APB1ENR        \ RCC_UART5EN	Bit Offset:20	Bit Width:1
\ %1  21 lshift RCC_APB1ENR        \ RCC_I2C1EN	Bit Offset:21	Bit Width:1
\ %1  22 lshift RCC_APB1ENR        \ RCC_I2C2EN	Bit Offset:22	Bit Width:1
\ %1  23 lshift RCC_APB1ENR        \ RCC_USBEN	Bit Offset:23	Bit Width:1
\ %1  25 lshift RCC_APB1ENR        \ RCC_CANEN	Bit Offset:25	Bit Width:1
\ %1  27 lshift RCC_APB1ENR        \ RCC_BKPEN	Bit Offset:27	Bit Width:1
\ %1  28 lshift RCC_APB1ENR        \ RCC_PWREN	Bit Offset:28	Bit Width:1
\ %1  29 lshift RCC_APB1ENR        \ RCC_DACEN	Bit Offset:29	Bit Width:1

\ RCC_BDCR 
$00000000 CONSTANT RESET_RCC_BDCR 
\ %1  0 lshift RCC_BDCR        \ RCC_LSEON	Bit Offset:0	Bit Width:1
\ %1  1 lshift RCC_BDCR        \ RCC_LSERDY	Bit Offset:1	Bit Width:1
\ %1  2 lshift RCC_BDCR        \ RCC_LSEBYP	Bit Offset:2	Bit Width:1
\ %xx  8 lshift RCC_BDCR        \ RCC_RTCSEL	Bit Offset:8	Bit Width:2
\ %1  15 lshift RCC_BDCR        \ RCC_RTCEN	Bit Offset:15	Bit Width:1
\ %1  16 lshift RCC_BDCR        \ RCC_BDRST	Bit Offset:16	Bit Width:1

\ RCC_CSR 
$0C000000 CONSTANT RESET_RCC_CSR 
\ %1  0 lshift RCC_CSR        \ RCC_LSION	Bit Offset:0	Bit Width:1
\ %1  1 lshift RCC_CSR        \ RCC_LSIRDY	Bit Offset:1	Bit Width:1
\ %1  24 lshift RCC_CSR        \ RCC_RMVF	Bit Offset:24	Bit Width:1
\ %1  26 lshift RCC_CSR        \ RCC_PINRSTF	Bit Offset:26	Bit Width:1
\ %1  27 lshift RCC_CSR        \ RCC_PORRSTF	Bit Offset:27	Bit Width:1
\ %1  28 lshift RCC_CSR        \ RCC_SFTRSTF	Bit Offset:28	Bit Width:1
\ %1  29 lshift RCC_CSR        \ RCC_IWDGRSTF	Bit Offset:29	Bit Width:1
\ %1  30 lshift RCC_CSR        \ RCC_WWDGRSTF	Bit Offset:30	Bit Width:1
\ %1  31 lshift RCC_CSR        \ RCC_LPWRRSTF	Bit Offset:31	Bit Width:1

  
\ GPIOA
\ GPIOA_CRL read-write
$44444444 CONSTANT RESET_GPIOA_CRL 
\ %xx  0 lshift GPIOA_CRL        \ GPIOA_MODE0	Bit Offset:0	Bit Width:2
\ %xx  2 lshift GPIOA_CRL        \ GPIOA_CNF0	Bit Offset:2	Bit Width:2
\ %xx  4 lshift GPIOA_CRL        \ GPIOA_MODE1	Bit Offset:4	Bit Width:2
\ %xx  6 lshift GPIOA_CRL        \ GPIOA_CNF1	Bit Offset:6	Bit Width:2
\ %xx  8 lshift GPIOA_CRL        \ GPIOA_MODE2	Bit Offset:8	Bit Width:2
\ %xx  10 lshift GPIOA_CRL        \ GPIOA_CNF2	Bit Offset:10	Bit Width:2
\ %xx  12 lshift GPIOA_CRL        \ GPIOA_MODE3	Bit Offset:12	Bit Width:2
\ %xx  14 lshift GPIOA_CRL        \ GPIOA_CNF3	Bit Offset:14	Bit Width:2
\ %xx  16 lshift GPIOA_CRL        \ GPIOA_MODE4	Bit Offset:16	Bit Width:2
\ %xx  18 lshift GPIOA_CRL        \ GPIOA_CNF4	Bit Offset:18	Bit Width:2
\ %xx  20 lshift GPIOA_CRL        \ GPIOA_MODE5	Bit Offset:20	Bit Width:2
\ %xx  22 lshift GPIOA_CRL        \ GPIOA_CNF5	Bit Offset:22	Bit Width:2
\ %xx  24 lshift GPIOA_CRL        \ GPIOA_MODE6	Bit Offset:24	Bit Width:2
\ %xx  26 lshift GPIOA_CRL        \ GPIOA_CNF6	Bit Offset:26	Bit Width:2
\ %xx  28 lshift GPIOA_CRL        \ GPIOA_MODE7	Bit Offset:28	Bit Width:2
\ %xx  30 lshift GPIOA_CRL        \ GPIOA_CNF7	Bit Offset:30	Bit Width:2

\ GPIOA_CRH read-write
$44444444 CONSTANT RESET_GPIOA_CRH 
\ %xx  0 lshift GPIOA_CRH        \ GPIOA_MODE8	Bit Offset:0	Bit Width:2
\ %xx  2 lshift GPIOA_CRH        \ GPIOA_CNF8	Bit Offset:2	Bit Width:2
\ %xx  4 lshift GPIOA_CRH        \ GPIOA_MODE9	Bit Offset:4	Bit Width:2
\ %xx  6 lshift GPIOA_CRH        \ GPIOA_CNF9	Bit Offset:6	Bit Width:2
\ %xx  8 lshift GPIOA_CRH        \ GPIOA_MODE10	Bit Offset:8	Bit Width:2
\ %xx  10 lshift GPIOA_CRH        \ GPIOA_CNF10	Bit Offset:10	Bit Width:2
\ %xx  12 lshift GPIOA_CRH        \ GPIOA_MODE11	Bit Offset:12	Bit Width:2
\ %xx  14 lshift GPIOA_CRH        \ GPIOA_CNF11	Bit Offset:14	Bit Width:2
\ %xx  16 lshift GPIOA_CRH        \ GPIOA_MODE12	Bit Offset:16	Bit Width:2
\ %xx  18 lshift GPIOA_CRH        \ GPIOA_CNF12	Bit Offset:18	Bit Width:2
\ %xx  20 lshift GPIOA_CRH        \ GPIOA_MODE13	Bit Offset:20	Bit Width:2
\ %xx  22 lshift GPIOA_CRH        \ GPIOA_CNF13	Bit Offset:22	Bit Width:2
\ %xx  24 lshift GPIOA_CRH        \ GPIOA_MODE14	Bit Offset:24	Bit Width:2
\ %xx  26 lshift GPIOA_CRH        \ GPIOA_CNF14	Bit Offset:26	Bit Width:2
\ %xx  28 lshift GPIOA_CRH        \ GPIOA_MODE15	Bit Offset:28	Bit Width:2
\ %xx  30 lshift GPIOA_CRH        \ GPIOA_CNF15	Bit Offset:30	Bit Width:2

\ GPIOA_IDR read-only
$00000000 CONSTANT RESET_GPIOA_IDR 
\ %1  0 lshift GPIOA_IDR        \ GPIOA_IDR0	Bit Offset:0	Bit Width:1
\ %1  1 lshift GPIOA_IDR        \ GPIOA_IDR1	Bit Offset:1	Bit Width:1
\ %1  2 lshift GPIOA_IDR        \ GPIOA_IDR2	Bit Offset:2	Bit Width:1
\ %1  3 lshift GPIOA_IDR        \ GPIOA_IDR3	Bit Offset:3	Bit Width:1
\ %1  4 lshift GPIOA_IDR        \ GPIOA_IDR4	Bit Offset:4	Bit Width:1
\ %1  5 lshift GPIOA_IDR        \ GPIOA_IDR5	Bit Offset:5	Bit Width:1
\ %1  6 lshift GPIOA_IDR        \ GPIOA_IDR6	Bit Offset:6	Bit Width:1
\ %1  7 lshift GPIOA_IDR        \ GPIOA_IDR7	Bit Offset:7	Bit Width:1
\ %1  8 lshift GPIOA_IDR        \ GPIOA_IDR8	Bit Offset:8	Bit Width:1
\ %1  9 lshift GPIOA_IDR        \ GPIOA_IDR9	Bit Offset:9	Bit Width:1
\ %1  10 lshift GPIOA_IDR        \ GPIOA_IDR10	Bit Offset:10	Bit Width:1
\ %1  11 lshift GPIOA_IDR        \ GPIOA_IDR11	Bit Offset:11	Bit Width:1
\ %1  12 lshift GPIOA_IDR        \ GPIOA_IDR12	Bit Offset:12	Bit Width:1
\ %1  13 lshift GPIOA_IDR        \ GPIOA_IDR13	Bit Offset:13	Bit Width:1
\ %1  14 lshift GPIOA_IDR        \ GPIOA_IDR14	Bit Offset:14	Bit Width:1
\ %1  15 lshift GPIOA_IDR        \ GPIOA_IDR15	Bit Offset:15	Bit Width:1

\ GPIOA_ODR read-write
$00000000 CONSTANT RESET_GPIOA_ODR 
\ %1  0 lshift GPIOA_ODR        \ GPIOA_ODR0	Bit Offset:0	Bit Width:1
\ %1  1 lshift GPIOA_ODR        \ GPIOA_ODR1	Bit Offset:1	Bit Width:1
\ %1  2 lshift GPIOA_ODR        \ GPIOA_ODR2	Bit Offset:2	Bit Width:1
\ %1  3 lshift GPIOA_ODR        \ GPIOA_ODR3	Bit Offset:3	Bit Width:1
\ %1  4 lshift GPIOA_ODR        \ GPIOA_ODR4	Bit Offset:4	Bit Width:1
\ %1  5 lshift GPIOA_ODR        \ GPIOA_ODR5	Bit Offset:5	Bit Width:1
\ %1  6 lshift GPIOA_ODR        \ GPIOA_ODR6	Bit Offset:6	Bit Width:1
\ %1  7 lshift GPIOA_ODR        \ GPIOA_ODR7	Bit Offset:7	Bit Width:1
\ %1  8 lshift GPIOA_ODR        \ GPIOA_ODR8	Bit Offset:8	Bit Width:1
\ %1  9 lshift GPIOA_ODR        \ GPIOA_ODR9	Bit Offset:9	Bit Width:1
\ %1  10 lshift GPIOA_ODR        \ GPIOA_ODR10	Bit Offset:10	Bit Width:1
\ %1  11 lshift GPIOA_ODR        \ GPIOA_ODR11	Bit Offset:11	Bit Width:1
\ %1  12 lshift GPIOA_ODR        \ GPIOA_ODR12	Bit Offset:12	Bit Width:1
\ %1  13 lshift GPIOA_ODR        \ GPIOA_ODR13	Bit Offset:13	Bit Width:1
\ %1  14 lshift GPIOA_ODR        \ GPIOA_ODR14	Bit Offset:14	Bit Width:1
\ %1  15 lshift GPIOA_ODR        \ GPIOA_ODR15	Bit Offset:15	Bit Width:1

\ GPIOA_BSRR write-only
$00000000 CONSTANT RESET_GPIOA_BSRR 
\ %1  0 lshift GPIOA_BSRR        \ GPIOA_BS0	Bit Offset:0	Bit Width:1
\ %1  1 lshift GPIOA_BSRR        \ GPIOA_BS1	Bit Offset:1	Bit Width:1
\ %1  2 lshift GPIOA_BSRR        \ GPIOA_BS2	Bit Offset:2	Bit Width:1
\ %1  3 lshift GPIOA_BSRR        \ GPIOA_BS3	Bit Offset:3	Bit Width:1
\ %1  4 lshift GPIOA_BSRR        \ GPIOA_BS4	Bit Offset:4	Bit Width:1
\ %1  5 lshift GPIOA_BSRR        \ GPIOA_BS5	Bit Offset:5	Bit Width:1
\ %1  6 lshift GPIOA_BSRR        \ GPIOA_BS6	Bit Offset:6	Bit Width:1
\ %1  7 lshift GPIOA_BSRR        \ GPIOA_BS7	Bit Offset:7	Bit Width:1
\ %1  8 lshift GPIOA_BSRR        \ GPIOA_BS8	Bit Offset:8	Bit Width:1
\ %1  9 lshift GPIOA_BSRR        \ GPIOA_BS9	Bit Offset:9	Bit Width:1
\ %1  10 lshift GPIOA_BSRR        \ GPIOA_BS10	Bit Offset:10	Bit Width:1
\ %1  11 lshift GPIOA_BSRR        \ GPIOA_BS11	Bit Offset:11	Bit Width:1
\ %1  12 lshift GPIOA_BSRR        \ GPIOA_BS12	Bit Offset:12	Bit Width:1
\ %1  13 lshift GPIOA_BSRR        \ GPIOA_BS13	Bit Offset:13	Bit Width:1
\ %1  14 lshift GPIOA_BSRR        \ GPIOA_BS14	Bit Offset:14	Bit Width:1
\ %1  15 lshift GPIOA_BSRR        \ GPIOA_BS15	Bit Offset:15	Bit Width:1
\ %1  16 lshift GPIOA_BSRR        \ GPIOA_BR0	Bit Offset:16	Bit Width:1
\ %1  17 lshift GPIOA_BSRR        \ GPIOA_BR1	Bit Offset:17	Bit Width:1
\ %1  18 lshift GPIOA_BSRR        \ GPIOA_BR2	Bit Offset:18	Bit Width:1
\ %1  19 lshift GPIOA_BSRR        \ GPIOA_BR3	Bit Offset:19	Bit Width:1
\ %1  20 lshift GPIOA_BSRR        \ GPIOA_BR4	Bit Offset:20	Bit Width:1
\ %1  21 lshift GPIOA_BSRR        \ GPIOA_BR5	Bit Offset:21	Bit Width:1
\ %1  22 lshift GPIOA_BSRR        \ GPIOA_BR6	Bit Offset:22	Bit Width:1
\ %1  23 lshift GPIOA_BSRR        \ GPIOA_BR7	Bit Offset:23	Bit Width:1
\ %1  24 lshift GPIOA_BSRR        \ GPIOA_BR8	Bit Offset:24	Bit Width:1
\ %1  25 lshift GPIOA_BSRR        \ GPIOA_BR9	Bit Offset:25	Bit Width:1
\ %1  26 lshift GPIOA_BSRR        \ GPIOA_BR10	Bit Offset:26	Bit Width:1
\ %1  27 lshift GPIOA_BSRR        \ GPIOA_BR11	Bit Offset:27	Bit Width:1
\ %1  28 lshift GPIOA_BSRR        \ GPIOA_BR12	Bit Offset:28	Bit Width:1
\ %1  29 lshift GPIOA_BSRR        \ GPIOA_BR13	Bit Offset:29	Bit Width:1
\ %1  30 lshift GPIOA_BSRR        \ GPIOA_BR14	Bit Offset:30	Bit Width:1
\ %1  31 lshift GPIOA_BSRR        \ GPIOA_BR15	Bit Offset:31	Bit Width:1

\ GPIOA_BRR write-only
$00000000 CONSTANT RESET_GPIOA_BRR 
\ %1  0 lshift GPIOA_BRR        \ GPIOA_BR0	Bit Offset:0	Bit Width:1
\ %1  1 lshift GPIOA_BRR        \ GPIOA_BR1	Bit Offset:1	Bit Width:1
\ %1  2 lshift GPIOA_BRR        \ GPIOA_BR2	Bit Offset:2	Bit Width:1
\ %1  3 lshift GPIOA_BRR        \ GPIOA_BR3	Bit Offset:3	Bit Width:1
\ %1  4 lshift GPIOA_BRR        \ GPIOA_BR4	Bit Offset:4	Bit Width:1
\ %1  5 lshift GPIOA_BRR        \ GPIOA_BR5	Bit Offset:5	Bit Width:1
\ %1  6 lshift GPIOA_BRR        \ GPIOA_BR6	Bit Offset:6	Bit Width:1
\ %1  7 lshift GPIOA_BRR        \ GPIOA_BR7	Bit Offset:7	Bit Width:1
\ %1  8 lshift GPIOA_BRR        \ GPIOA_BR8	Bit Offset:8	Bit Width:1
\ %1  9 lshift GPIOA_BRR        \ GPIOA_BR9	Bit Offset:9	Bit Width:1
\ %1  10 lshift GPIOA_BRR        \ GPIOA_BR10	Bit Offset:10	Bit Width:1
\ %1  11 lshift GPIOA_BRR        \ GPIOA_BR11	Bit Offset:11	Bit Width:1
\ %1  12 lshift GPIOA_BRR        \ GPIOA_BR12	Bit Offset:12	Bit Width:1
\ %1  13 lshift GPIOA_BRR        \ GPIOA_BR13	Bit Offset:13	Bit Width:1
\ %1  14 lshift GPIOA_BRR        \ GPIOA_BR14	Bit Offset:14	Bit Width:1
\ %1  15 lshift GPIOA_BRR        \ GPIOA_BR15	Bit Offset:15	Bit Width:1

\ GPIOA_LCKR read-write
$00000000 CONSTANT RESET_GPIOA_LCKR 
\ %1  0 lshift GPIOA_LCKR        \ GPIOA_LCK0	Bit Offset:0	Bit Width:1
\ %1  1 lshift GPIOA_LCKR        \ GPIOA_LCK1	Bit Offset:1	Bit Width:1
\ %1  2 lshift GPIOA_LCKR        \ GPIOA_LCK2	Bit Offset:2	Bit Width:1
\ %1  3 lshift GPIOA_LCKR        \ GPIOA_LCK3	Bit Offset:3	Bit Width:1
\ %1  4 lshift GPIOA_LCKR        \ GPIOA_LCK4	Bit Offset:4	Bit Width:1
\ %1  5 lshift GPIOA_LCKR        \ GPIOA_LCK5	Bit Offset:5	Bit Width:1
\ %1  6 lshift GPIOA_LCKR        \ GPIOA_LCK6	Bit Offset:6	Bit Width:1
\ %1  7 lshift GPIOA_LCKR        \ GPIOA_LCK7	Bit Offset:7	Bit Width:1
\ %1  8 lshift GPIOA_LCKR        \ GPIOA_LCK8	Bit Offset:8	Bit Width:1
\ %1  9 lshift GPIOA_LCKR        \ GPIOA_LCK9	Bit Offset:9	Bit Width:1
\ %1  10 lshift GPIOA_LCKR        \ GPIOA_LCK10	Bit Offset:10	Bit Width:1
\ %1  11 lshift GPIOA_LCKR        \ GPIOA_LCK11	Bit Offset:11	Bit Width:1
\ %1  12 lshift GPIOA_LCKR        \ GPIOA_LCK12	Bit Offset:12	Bit Width:1
\ %1  13 lshift GPIOA_LCKR        \ GPIOA_LCK13	Bit Offset:13	Bit Width:1
\ %1  14 lshift GPIOA_LCKR        \ GPIOA_LCK14	Bit Offset:14	Bit Width:1
\ %1  15 lshift GPIOA_LCKR        \ GPIOA_LCK15	Bit Offset:15	Bit Width:1
\ %1  16 lshift GPIOA_LCKR        \ GPIOA_LCKK	Bit Offset:16	Bit Width:1

  
\ GPIOB
  
\ GPIOC
  
\ GPIOD
  
\ GPIOE
  
\ GPIOF
  
\ GPIOG
  
\ AFIO
\ AFIO_EVCR read-write
$00000000 CONSTANT RESET_AFIO_EVCR 
\ %xxxx  0 lshift AFIO_EVCR        \ AFIO_PIN	Bit Offset:0	Bit Width:4
\ %xxx  4 lshift AFIO_EVCR        \ AFIO_PORT	Bit Offset:4	Bit Width:3
\ %1  7 lshift AFIO_EVCR        \ AFIO_EVOE	Bit Offset:7	Bit Width:1

\ AFIO_MAPR 
$00000000 CONSTANT RESET_AFIO_MAPR 
\ %1  0 lshift AFIO_MAPR        \ AFIO_SPI1_REMAP	Bit Offset:0	Bit Width:1
\ %1  1 lshift AFIO_MAPR        \ AFIO_I2C1_REMAP	Bit Offset:1	Bit Width:1
\ %1  2 lshift AFIO_MAPR        \ AFIO_USART1_REMAP	Bit Offset:2	Bit Width:1
\ %1  3 lshift AFIO_MAPR        \ AFIO_USART2_REMAP	Bit Offset:3	Bit Width:1
\ %xx  4 lshift AFIO_MAPR        \ AFIO_USART3_REMAP	Bit Offset:4	Bit Width:2
\ %xx  6 lshift AFIO_MAPR        \ AFIO_TIM1_REMAP	Bit Offset:6	Bit Width:2
\ %xx  8 lshift AFIO_MAPR        \ AFIO_TIM2_REMAP	Bit Offset:8	Bit Width:2
\ %xx  10 lshift AFIO_MAPR        \ AFIO_TIM3_REMAP	Bit Offset:10	Bit Width:2
\ %1  12 lshift AFIO_MAPR        \ AFIO_TIM4_REMAP	Bit Offset:12	Bit Width:1
\ %xx  13 lshift AFIO_MAPR        \ AFIO_CAN_REMAP	Bit Offset:13	Bit Width:2
\ %1  15 lshift AFIO_MAPR        \ AFIO_PD01_REMAP	Bit Offset:15	Bit Width:1
\ %1  16 lshift AFIO_MAPR        \ AFIO_TIM5CH4_IREMAP	Bit Offset:16	Bit Width:1
\ %1  17 lshift AFIO_MAPR        \ AFIO_ADC1_ETRGINJ_REMAP	Bit Offset:17	Bit Width:1
\ %1  18 lshift AFIO_MAPR        \ AFIO_ADC1_ETRGREG_REMAP	Bit Offset:18	Bit Width:1
\ %1  19 lshift AFIO_MAPR        \ AFIO_ADC2_ETRGINJ_REMAP	Bit Offset:19	Bit Width:1
\ %1  20 lshift AFIO_MAPR        \ AFIO_ADC2_ETRGREG_REMAP	Bit Offset:20	Bit Width:1
\ %xxx  24 lshift AFIO_MAPR        \ AFIO_SWJ_CFG	Bit Offset:24	Bit Width:3

\ AFIO_EXTICR1 read-write
$00000000 CONSTANT RESET_AFIO_EXTICR1 
\ %xxxx  0 lshift AFIO_EXTICR1        \ AFIO_EXTI0	Bit Offset:0	Bit Width:4
\ %xxxx  4 lshift AFIO_EXTICR1        \ AFIO_EXTI1	Bit Offset:4	Bit Width:4
\ %xxxx  8 lshift AFIO_EXTICR1        \ AFIO_EXTI2	Bit Offset:8	Bit Width:4
\ %xxxx  12 lshift AFIO_EXTICR1        \ AFIO_EXTI3	Bit Offset:12	Bit Width:4

\ AFIO_EXTICR2 read-write
$00000000 CONSTANT RESET_AFIO_EXTICR2 
\ %xxxx  0 lshift AFIO_EXTICR2        \ AFIO_EXTI4	Bit Offset:0	Bit Width:4
\ %xxxx  4 lshift AFIO_EXTICR2        \ AFIO_EXTI5	Bit Offset:4	Bit Width:4
\ %xxxx  8 lshift AFIO_EXTICR2        \ AFIO_EXTI6	Bit Offset:8	Bit Width:4
\ %xxxx  12 lshift AFIO_EXTICR2        \ AFIO_EXTI7	Bit Offset:12	Bit Width:4

\ AFIO_EXTICR3 read-write
$00000000 CONSTANT RESET_AFIO_EXTICR3 
\ %xxxx  0 lshift AFIO_EXTICR3        \ AFIO_EXTI8	Bit Offset:0	Bit Width:4
\ %xxxx  4 lshift AFIO_EXTICR3        \ AFIO_EXTI9	Bit Offset:4	Bit Width:4
\ %xxxx  8 lshift AFIO_EXTICR3        \ AFIO_EXTI10	Bit Offset:8	Bit Width:4
\ %xxxx  12 lshift AFIO_EXTICR3        \ AFIO_EXTI11	Bit Offset:12	Bit Width:4

\ AFIO_EXTICR4 read-write
$00000000 CONSTANT RESET_AFIO_EXTICR4 
\ %xxxx  0 lshift AFIO_EXTICR4        \ AFIO_EXTI12	Bit Offset:0	Bit Width:4
\ %xxxx  4 lshift AFIO_EXTICR4        \ AFIO_EXTI13	Bit Offset:4	Bit Width:4
\ %xxxx  8 lshift AFIO_EXTICR4        \ AFIO_EXTI14	Bit Offset:8	Bit Width:4
\ %xxxx  12 lshift AFIO_EXTICR4        \ AFIO_EXTI15	Bit Offset:12	Bit Width:4

\ AFIO_MAPR2 read-write
$00000000 CONSTANT RESET_AFIO_MAPR2 
\ %1  5 lshift AFIO_MAPR2        \ AFIO_TIM9_REMAP	Bit Offset:5	Bit Width:1
\ %1  6 lshift AFIO_MAPR2        \ AFIO_TIM10_REMAP	Bit Offset:6	Bit Width:1
\ %1  7 lshift AFIO_MAPR2        \ AFIO_TIM11_REMAP	Bit Offset:7	Bit Width:1
\ %1  8 lshift AFIO_MAPR2        \ AFIO_TIM13_REMAP	Bit Offset:8	Bit Width:1
\ %1  9 lshift AFIO_MAPR2        \ AFIO_TIM14_REMAP	Bit Offset:9	Bit Width:1
\ %1  10 lshift AFIO_MAPR2        \ AFIO_FSMC_NADV	Bit Offset:10	Bit Width:1

  
\ EXTI
\ EXTI_IMR read-write
$00000000 CONSTANT RESET_EXTI_IMR 
\ %1  0 lshift EXTI_IMR        \ EXTI_MR0	Bit Offset:0	Bit Width:1
\ %1  1 lshift EXTI_IMR        \ EXTI_MR1	Bit Offset:1	Bit Width:1
\ %1  2 lshift EXTI_IMR        \ EXTI_MR2	Bit Offset:2	Bit Width:1
\ %1  3 lshift EXTI_IMR        \ EXTI_MR3	Bit Offset:3	Bit Width:1
\ %1  4 lshift EXTI_IMR        \ EXTI_MR4	Bit Offset:4	Bit Width:1
\ %1  5 lshift EXTI_IMR        \ EXTI_MR5	Bit Offset:5	Bit Width:1
\ %1  6 lshift EXTI_IMR        \ EXTI_MR6	Bit Offset:6	Bit Width:1
\ %1  7 lshift EXTI_IMR        \ EXTI_MR7	Bit Offset:7	Bit Width:1
\ %1  8 lshift EXTI_IMR        \ EXTI_MR8	Bit Offset:8	Bit Width:1
\ %1  9 lshift EXTI_IMR        \ EXTI_MR9	Bit Offset:9	Bit Width:1
\ %1  10 lshift EXTI_IMR        \ EXTI_MR10	Bit Offset:10	Bit Width:1
\ %1  11 lshift EXTI_IMR        \ EXTI_MR11	Bit Offset:11	Bit Width:1
\ %1  12 lshift EXTI_IMR        \ EXTI_MR12	Bit Offset:12	Bit Width:1
\ %1  13 lshift EXTI_IMR        \ EXTI_MR13	Bit Offset:13	Bit Width:1
\ %1  14 lshift EXTI_IMR        \ EXTI_MR14	Bit Offset:14	Bit Width:1
\ %1  15 lshift EXTI_IMR        \ EXTI_MR15	Bit Offset:15	Bit Width:1
\ %1  16 lshift EXTI_IMR        \ EXTI_MR16	Bit Offset:16	Bit Width:1
\ %1  17 lshift EXTI_IMR        \ EXTI_MR17	Bit Offset:17	Bit Width:1
\ %1  18 lshift EXTI_IMR        \ EXTI_MR18	Bit Offset:18	Bit Width:1

\ EXTI_EMR read-write
$00000000 CONSTANT RESET_EXTI_EMR 
\ %1  0 lshift EXTI_EMR        \ EXTI_MR0	Bit Offset:0	Bit Width:1
\ %1  1 lshift EXTI_EMR        \ EXTI_MR1	Bit Offset:1	Bit Width:1
\ %1  2 lshift EXTI_EMR        \ EXTI_MR2	Bit Offset:2	Bit Width:1
\ %1  3 lshift EXTI_EMR        \ EXTI_MR3	Bit Offset:3	Bit Width:1
\ %1  4 lshift EXTI_EMR        \ EXTI_MR4	Bit Offset:4	Bit Width:1
\ %1  5 lshift EXTI_EMR        \ EXTI_MR5	Bit Offset:5	Bit Width:1
\ %1  6 lshift EXTI_EMR        \ EXTI_MR6	Bit Offset:6	Bit Width:1
\ %1  7 lshift EXTI_EMR        \ EXTI_MR7	Bit Offset:7	Bit Width:1
\ %1  8 lshift EXTI_EMR        \ EXTI_MR8	Bit Offset:8	Bit Width:1
\ %1  9 lshift EXTI_EMR        \ EXTI_MR9	Bit Offset:9	Bit Width:1
\ %1  10 lshift EXTI_EMR        \ EXTI_MR10	Bit Offset:10	Bit Width:1
\ %1  11 lshift EXTI_EMR        \ EXTI_MR11	Bit Offset:11	Bit Width:1
\ %1  12 lshift EXTI_EMR        \ EXTI_MR12	Bit Offset:12	Bit Width:1
\ %1  13 lshift EXTI_EMR        \ EXTI_MR13	Bit Offset:13	Bit Width:1
\ %1  14 lshift EXTI_EMR        \ EXTI_MR14	Bit Offset:14	Bit Width:1
\ %1  15 lshift EXTI_EMR        \ EXTI_MR15	Bit Offset:15	Bit Width:1
\ %1  16 lshift EXTI_EMR        \ EXTI_MR16	Bit Offset:16	Bit Width:1
\ %1  17 lshift EXTI_EMR        \ EXTI_MR17	Bit Offset:17	Bit Width:1
\ %1  18 lshift EXTI_EMR        \ EXTI_MR18	Bit Offset:18	Bit Width:1

\ EXTI_RTSR read-write
$00000000 CONSTANT RESET_EXTI_RTSR 
\ %1  0 lshift EXTI_RTSR        \ EXTI_TR0	Bit Offset:0	Bit Width:1
\ %1  1 lshift EXTI_RTSR        \ EXTI_TR1	Bit Offset:1	Bit Width:1
\ %1  2 lshift EXTI_RTSR        \ EXTI_TR2	Bit Offset:2	Bit Width:1
\ %1  3 lshift EXTI_RTSR        \ EXTI_TR3	Bit Offset:3	Bit Width:1
\ %1  4 lshift EXTI_RTSR        \ EXTI_TR4	Bit Offset:4	Bit Width:1
\ %1  5 lshift EXTI_RTSR        \ EXTI_TR5	Bit Offset:5	Bit Width:1
\ %1  6 lshift EXTI_RTSR        \ EXTI_TR6	Bit Offset:6	Bit Width:1
\ %1  7 lshift EXTI_RTSR        \ EXTI_TR7	Bit Offset:7	Bit Width:1
\ %1  8 lshift EXTI_RTSR        \ EXTI_TR8	Bit Offset:8	Bit Width:1
\ %1  9 lshift EXTI_RTSR        \ EXTI_TR9	Bit Offset:9	Bit Width:1
\ %1  10 lshift EXTI_RTSR        \ EXTI_TR10	Bit Offset:10	Bit Width:1
\ %1  11 lshift EXTI_RTSR        \ EXTI_TR11	Bit Offset:11	Bit Width:1
\ %1  12 lshift EXTI_RTSR        \ EXTI_TR12	Bit Offset:12	Bit Width:1
\ %1  13 lshift EXTI_RTSR        \ EXTI_TR13	Bit Offset:13	Bit Width:1
\ %1  14 lshift EXTI_RTSR        \ EXTI_TR14	Bit Offset:14	Bit Width:1
\ %1  15 lshift EXTI_RTSR        \ EXTI_TR15	Bit Offset:15	Bit Width:1
\ %1  16 lshift EXTI_RTSR        \ EXTI_TR16	Bit Offset:16	Bit Width:1
\ %1  17 lshift EXTI_RTSR        \ EXTI_TR17	Bit Offset:17	Bit Width:1
\ %1  18 lshift EXTI_RTSR        \ EXTI_TR18	Bit Offset:18	Bit Width:1

\ EXTI_FTSR read-write
$00000000 CONSTANT RESET_EXTI_FTSR 
\ %1  0 lshift EXTI_FTSR        \ EXTI_TR0	Bit Offset:0	Bit Width:1
\ %1  1 lshift EXTI_FTSR        \ EXTI_TR1	Bit Offset:1	Bit Width:1
\ %1  2 lshift EXTI_FTSR        \ EXTI_TR2	Bit Offset:2	Bit Width:1
\ %1  3 lshift EXTI_FTSR        \ EXTI_TR3	Bit Offset:3	Bit Width:1
\ %1  4 lshift EXTI_FTSR        \ EXTI_TR4	Bit Offset:4	Bit Width:1
\ %1  5 lshift EXTI_FTSR        \ EXTI_TR5	Bit Offset:5	Bit Width:1
\ %1  6 lshift EXTI_FTSR        \ EXTI_TR6	Bit Offset:6	Bit Width:1
\ %1  7 lshift EXTI_FTSR        \ EXTI_TR7	Bit Offset:7	Bit Width:1
\ %1  8 lshift EXTI_FTSR        \ EXTI_TR8	Bit Offset:8	Bit Width:1
\ %1  9 lshift EXTI_FTSR        \ EXTI_TR9	Bit Offset:9	Bit Width:1
\ %1  10 lshift EXTI_FTSR        \ EXTI_TR10	Bit Offset:10	Bit Width:1
\ %1  11 lshift EXTI_FTSR        \ EXTI_TR11	Bit Offset:11	Bit Width:1
\ %1  12 lshift EXTI_FTSR        \ EXTI_TR12	Bit Offset:12	Bit Width:1
\ %1  13 lshift EXTI_FTSR        \ EXTI_TR13	Bit Offset:13	Bit Width:1
\ %1  14 lshift EXTI_FTSR        \ EXTI_TR14	Bit Offset:14	Bit Width:1
\ %1  15 lshift EXTI_FTSR        \ EXTI_TR15	Bit Offset:15	Bit Width:1
\ %1  16 lshift EXTI_FTSR        \ EXTI_TR16	Bit Offset:16	Bit Width:1
\ %1  17 lshift EXTI_FTSR        \ EXTI_TR17	Bit Offset:17	Bit Width:1
\ %1  18 lshift EXTI_FTSR        \ EXTI_TR18	Bit Offset:18	Bit Width:1

\ EXTI_SWIER read-write
$00000000 CONSTANT RESET_EXTI_SWIER 
\ %1  0 lshift EXTI_SWIER        \ EXTI_SWIER0	Bit Offset:0	Bit Width:1
\ %1  1 lshift EXTI_SWIER        \ EXTI_SWIER1	Bit Offset:1	Bit Width:1
\ %1  2 lshift EXTI_SWIER        \ EXTI_SWIER2	Bit Offset:2	Bit Width:1
\ %1  3 lshift EXTI_SWIER        \ EXTI_SWIER3	Bit Offset:3	Bit Width:1
\ %1  4 lshift EXTI_SWIER        \ EXTI_SWIER4	Bit Offset:4	Bit Width:1
\ %1  5 lshift EXTI_SWIER        \ EXTI_SWIER5	Bit Offset:5	Bit Width:1
\ %1  6 lshift EXTI_SWIER        \ EXTI_SWIER6	Bit Offset:6	Bit Width:1
\ %1  7 lshift EXTI_SWIER        \ EXTI_SWIER7	Bit Offset:7	Bit Width:1
\ %1  8 lshift EXTI_SWIER        \ EXTI_SWIER8	Bit Offset:8	Bit Width:1
\ %1  9 lshift EXTI_SWIER        \ EXTI_SWIER9	Bit Offset:9	Bit Width:1
\ %1  10 lshift EXTI_SWIER        \ EXTI_SWIER10	Bit Offset:10	Bit Width:1
\ %1  11 lshift EXTI_SWIER        \ EXTI_SWIER11	Bit Offset:11	Bit Width:1
\ %1  12 lshift EXTI_SWIER        \ EXTI_SWIER12	Bit Offset:12	Bit Width:1
\ %1  13 lshift EXTI_SWIER        \ EXTI_SWIER13	Bit Offset:13	Bit Width:1
\ %1  14 lshift EXTI_SWIER        \ EXTI_SWIER14	Bit Offset:14	Bit Width:1
\ %1  15 lshift EXTI_SWIER        \ EXTI_SWIER15	Bit Offset:15	Bit Width:1
\ %1  16 lshift EXTI_SWIER        \ EXTI_SWIER16	Bit Offset:16	Bit Width:1
\ %1  17 lshift EXTI_SWIER        \ EXTI_SWIER17	Bit Offset:17	Bit Width:1
\ %1  18 lshift EXTI_SWIER        \ EXTI_SWIER18	Bit Offset:18	Bit Width:1

\ EXTI_PR read-write
$00000000 CONSTANT RESET_EXTI_PR 
\ %1  0 lshift EXTI_PR        \ EXTI_PR0	Bit Offset:0	Bit Width:1
\ %1  1 lshift EXTI_PR        \ EXTI_PR1	Bit Offset:1	Bit Width:1
\ %1  2 lshift EXTI_PR        \ EXTI_PR2	Bit Offset:2	Bit Width:1
\ %1  3 lshift EXTI_PR        \ EXTI_PR3	Bit Offset:3	Bit Width:1
\ %1  4 lshift EXTI_PR        \ EXTI_PR4	Bit Offset:4	Bit Width:1
\ %1  5 lshift EXTI_PR        \ EXTI_PR5	Bit Offset:5	Bit Width:1
\ %1  6 lshift EXTI_PR        \ EXTI_PR6	Bit Offset:6	Bit Width:1
\ %1  7 lshift EXTI_PR        \ EXTI_PR7	Bit Offset:7	Bit Width:1
\ %1  8 lshift EXTI_PR        \ EXTI_PR8	Bit Offset:8	Bit Width:1
\ %1  9 lshift EXTI_PR        \ EXTI_PR9	Bit Offset:9	Bit Width:1
\ %1  10 lshift EXTI_PR        \ EXTI_PR10	Bit Offset:10	Bit Width:1
\ %1  11 lshift EXTI_PR        \ EXTI_PR11	Bit Offset:11	Bit Width:1
\ %1  12 lshift EXTI_PR        \ EXTI_PR12	Bit Offset:12	Bit Width:1
\ %1  13 lshift EXTI_PR        \ EXTI_PR13	Bit Offset:13	Bit Width:1
\ %1  14 lshift EXTI_PR        \ EXTI_PR14	Bit Offset:14	Bit Width:1
\ %1  15 lshift EXTI_PR        \ EXTI_PR15	Bit Offset:15	Bit Width:1
\ %1  16 lshift EXTI_PR        \ EXTI_PR16	Bit Offset:16	Bit Width:1
\ %1  17 lshift EXTI_PR        \ EXTI_PR17	Bit Offset:17	Bit Width:1
\ %1  18 lshift EXTI_PR        \ EXTI_PR18	Bit Offset:18	Bit Width:1

  
\ DMA1
\ DMA1_ISR read-only
$00000000 CONSTANT RESET_DMA1_ISR 
\ %1  0 lshift DMA1_ISR        \ DMA1_GIF1	Bit Offset:0	Bit Width:1
\ %1  1 lshift DMA1_ISR        \ DMA1_TCIF1	Bit Offset:1	Bit Width:1
\ %1  2 lshift DMA1_ISR        \ DMA1_HTIF1	Bit Offset:2	Bit Width:1
\ %1  3 lshift DMA1_ISR        \ DMA1_TEIF1	Bit Offset:3	Bit Width:1
\ %1  4 lshift DMA1_ISR        \ DMA1_GIF2	Bit Offset:4	Bit Width:1
\ %1  5 lshift DMA1_ISR        \ DMA1_TCIF2	Bit Offset:5	Bit Width:1
\ %1  6 lshift DMA1_ISR        \ DMA1_HTIF2	Bit Offset:6	Bit Width:1
\ %1  7 lshift DMA1_ISR        \ DMA1_TEIF2	Bit Offset:7	Bit Width:1
\ %1  8 lshift DMA1_ISR        \ DMA1_GIF3	Bit Offset:8	Bit Width:1
\ %1  9 lshift DMA1_ISR        \ DMA1_TCIF3	Bit Offset:9	Bit Width:1
\ %1  10 lshift DMA1_ISR        \ DMA1_HTIF3	Bit Offset:10	Bit Width:1
\ %1  11 lshift DMA1_ISR        \ DMA1_TEIF3	Bit Offset:11	Bit Width:1
\ %1  12 lshift DMA1_ISR        \ DMA1_GIF4	Bit Offset:12	Bit Width:1
\ %1  13 lshift DMA1_ISR        \ DMA1_TCIF4	Bit Offset:13	Bit Width:1
\ %1  14 lshift DMA1_ISR        \ DMA1_HTIF4	Bit Offset:14	Bit Width:1
\ %1  15 lshift DMA1_ISR        \ DMA1_TEIF4	Bit Offset:15	Bit Width:1
\ %1  16 lshift DMA1_ISR        \ DMA1_GIF5	Bit Offset:16	Bit Width:1
\ %1  17 lshift DMA1_ISR        \ DMA1_TCIF5	Bit Offset:17	Bit Width:1
\ %1  18 lshift DMA1_ISR        \ DMA1_HTIF5	Bit Offset:18	Bit Width:1
\ %1  19 lshift DMA1_ISR        \ DMA1_TEIF5	Bit Offset:19	Bit Width:1
\ %1  20 lshift DMA1_ISR        \ DMA1_GIF6	Bit Offset:20	Bit Width:1
\ %1  21 lshift DMA1_ISR        \ DMA1_TCIF6	Bit Offset:21	Bit Width:1
\ %1  22 lshift DMA1_ISR        \ DMA1_HTIF6	Bit Offset:22	Bit Width:1
\ %1  23 lshift DMA1_ISR        \ DMA1_TEIF6	Bit Offset:23	Bit Width:1
\ %1  24 lshift DMA1_ISR        \ DMA1_GIF7	Bit Offset:24	Bit Width:1
\ %1  25 lshift DMA1_ISR        \ DMA1_TCIF7	Bit Offset:25	Bit Width:1
\ %1  26 lshift DMA1_ISR        \ DMA1_HTIF7	Bit Offset:26	Bit Width:1
\ %1  27 lshift DMA1_ISR        \ DMA1_TEIF7	Bit Offset:27	Bit Width:1

\ DMA1_IFCR write-only
$00000000 CONSTANT RESET_DMA1_IFCR 
\ %1  0 lshift DMA1_IFCR        \ DMA1_CGIF1	Bit Offset:0	Bit Width:1
\ %1  4 lshift DMA1_IFCR        \ DMA1_CGIF2	Bit Offset:4	Bit Width:1
\ %1  8 lshift DMA1_IFCR        \ DMA1_CGIF3	Bit Offset:8	Bit Width:1
\ %1  12 lshift DMA1_IFCR        \ DMA1_CGIF4	Bit Offset:12	Bit Width:1
\ %1  16 lshift DMA1_IFCR        \ DMA1_CGIF5	Bit Offset:16	Bit Width:1
\ %1  20 lshift DMA1_IFCR        \ DMA1_CGIF6	Bit Offset:20	Bit Width:1
\ %1  24 lshift DMA1_IFCR        \ DMA1_CGIF7	Bit Offset:24	Bit Width:1
\ %1  1 lshift DMA1_IFCR        \ DMA1_CTCIF1	Bit Offset:1	Bit Width:1
\ %1  5 lshift DMA1_IFCR        \ DMA1_CTCIF2	Bit Offset:5	Bit Width:1
\ %1  9 lshift DMA1_IFCR        \ DMA1_CTCIF3	Bit Offset:9	Bit Width:1
\ %1  13 lshift DMA1_IFCR        \ DMA1_CTCIF4	Bit Offset:13	Bit Width:1
\ %1  17 lshift DMA1_IFCR        \ DMA1_CTCIF5	Bit Offset:17	Bit Width:1
\ %1  21 lshift DMA1_IFCR        \ DMA1_CTCIF6	Bit Offset:21	Bit Width:1
\ %1  25 lshift DMA1_IFCR        \ DMA1_CTCIF7	Bit Offset:25	Bit Width:1
\ %1  2 lshift DMA1_IFCR        \ DMA1_CHTIF1	Bit Offset:2	Bit Width:1
\ %1  6 lshift DMA1_IFCR        \ DMA1_CHTIF2	Bit Offset:6	Bit Width:1
\ %1  10 lshift DMA1_IFCR        \ DMA1_CHTIF3	Bit Offset:10	Bit Width:1
\ %1  14 lshift DMA1_IFCR        \ DMA1_CHTIF4	Bit Offset:14	Bit Width:1
\ %1  18 lshift DMA1_IFCR        \ DMA1_CHTIF5	Bit Offset:18	Bit Width:1
\ %1  22 lshift DMA1_IFCR        \ DMA1_CHTIF6	Bit Offset:22	Bit Width:1
\ %1  26 lshift DMA1_IFCR        \ DMA1_CHTIF7	Bit Offset:26	Bit Width:1
\ %1  3 lshift DMA1_IFCR        \ DMA1_CTEIF1	Bit Offset:3	Bit Width:1
\ %1  7 lshift DMA1_IFCR        \ DMA1_CTEIF2	Bit Offset:7	Bit Width:1
\ %1  11 lshift DMA1_IFCR        \ DMA1_CTEIF3	Bit Offset:11	Bit Width:1
\ %1  15 lshift DMA1_IFCR        \ DMA1_CTEIF4	Bit Offset:15	Bit Width:1
\ %1  19 lshift DMA1_IFCR        \ DMA1_CTEIF5	Bit Offset:19	Bit Width:1
\ %1  23 lshift DMA1_IFCR        \ DMA1_CTEIF6	Bit Offset:23	Bit Width:1
\ %1  27 lshift DMA1_IFCR        \ DMA1_CTEIF7	Bit Offset:27	Bit Width:1

\ DMA1_CCR1 read-write
$00000000 CONSTANT RESET_DMA1_CCR1 
\ %1  0 lshift DMA1_CCR1        \ DMA1_EN	Bit Offset:0	Bit Width:1
\ %1  1 lshift DMA1_CCR1        \ DMA1_TCIE	Bit Offset:1	Bit Width:1
\ %1  2 lshift DMA1_CCR1        \ DMA1_HTIE	Bit Offset:2	Bit Width:1
\ %1  3 lshift DMA1_CCR1        \ DMA1_TEIE	Bit Offset:3	Bit Width:1
\ %1  4 lshift DMA1_CCR1        \ DMA1_DIR	Bit Offset:4	Bit Width:1
\ %1  5 lshift DMA1_CCR1        \ DMA1_CIRC	Bit Offset:5	Bit Width:1
\ %1  6 lshift DMA1_CCR1        \ DMA1_PINC	Bit Offset:6	Bit Width:1
\ %1  7 lshift DMA1_CCR1        \ DMA1_MINC	Bit Offset:7	Bit Width:1
\ %xx  8 lshift DMA1_CCR1        \ DMA1_PSIZE	Bit Offset:8	Bit Width:2
\ %xx  10 lshift DMA1_CCR1        \ DMA1_MSIZE	Bit Offset:10	Bit Width:2
\ %xx  12 lshift DMA1_CCR1        \ DMA1_PL	Bit Offset:12	Bit Width:2
\ %1  14 lshift DMA1_CCR1        \ DMA1_MEM2MEM	Bit Offset:14	Bit Width:1

\ DMA1_CNDTR1 read-write
$00000000 CONSTANT RESET_DMA1_CNDTR1 
\ %xxxxxxxxxxxxxxxx  0 lshift DMA1_CNDTR1        \ DMA1_NDT	Bit Offset:0	Bit Width:16

\ DMA1_CPAR1 read-write
$00000000 CONSTANT RESET_DMA1_CPAR1 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA1_CPAR1        \ DMA1_PA	Bit Offset:0	Bit Width:32

\ DMA1_CMAR1 read-write
$00000000 CONSTANT RESET_DMA1_CMAR1 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA1_CMAR1        \ DMA1_MA	Bit Offset:0	Bit Width:32

\ DMA1_CCR2 read-write
$00000000 CONSTANT RESET_DMA1_CCR2 
\ %1  0 lshift DMA1_CCR2        \ DMA1_EN	Bit Offset:0	Bit Width:1
\ %1  1 lshift DMA1_CCR2        \ DMA1_TCIE	Bit Offset:1	Bit Width:1
\ %1  2 lshift DMA1_CCR2        \ DMA1_HTIE	Bit Offset:2	Bit Width:1
\ %1  3 lshift DMA1_CCR2        \ DMA1_TEIE	Bit Offset:3	Bit Width:1
\ %1  4 lshift DMA1_CCR2        \ DMA1_DIR	Bit Offset:4	Bit Width:1
\ %1  5 lshift DMA1_CCR2        \ DMA1_CIRC	Bit Offset:5	Bit Width:1
\ %1  6 lshift DMA1_CCR2        \ DMA1_PINC	Bit Offset:6	Bit Width:1
\ %1  7 lshift DMA1_CCR2        \ DMA1_MINC	Bit Offset:7	Bit Width:1
\ %xx  8 lshift DMA1_CCR2        \ DMA1_PSIZE	Bit Offset:8	Bit Width:2
\ %xx  10 lshift DMA1_CCR2        \ DMA1_MSIZE	Bit Offset:10	Bit Width:2
\ %xx  12 lshift DMA1_CCR2        \ DMA1_PL	Bit Offset:12	Bit Width:2
\ %1  14 lshift DMA1_CCR2        \ DMA1_MEM2MEM	Bit Offset:14	Bit Width:1

\ DMA1_CNDTR2 read-write
$00000000 CONSTANT RESET_DMA1_CNDTR2 
\ %xxxxxxxxxxxxxxxx  0 lshift DMA1_CNDTR2        \ DMA1_NDT	Bit Offset:0	Bit Width:16

\ DMA1_CPAR2 read-write
$00000000 CONSTANT RESET_DMA1_CPAR2 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA1_CPAR2        \ DMA1_PA	Bit Offset:0	Bit Width:32

\ DMA1_CMAR2 read-write
$00000000 CONSTANT RESET_DMA1_CMAR2 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA1_CMAR2        \ DMA1_MA	Bit Offset:0	Bit Width:32

\ DMA1_CCR3 read-write
$00000000 CONSTANT RESET_DMA1_CCR3 
\ %1  0 lshift DMA1_CCR3        \ DMA1_EN	Bit Offset:0	Bit Width:1
\ %1  1 lshift DMA1_CCR3        \ DMA1_TCIE	Bit Offset:1	Bit Width:1
\ %1  2 lshift DMA1_CCR3        \ DMA1_HTIE	Bit Offset:2	Bit Width:1
\ %1  3 lshift DMA1_CCR3        \ DMA1_TEIE	Bit Offset:3	Bit Width:1
\ %1  4 lshift DMA1_CCR3        \ DMA1_DIR	Bit Offset:4	Bit Width:1
\ %1  5 lshift DMA1_CCR3        \ DMA1_CIRC	Bit Offset:5	Bit Width:1
\ %1  6 lshift DMA1_CCR3        \ DMA1_PINC	Bit Offset:6	Bit Width:1
\ %1  7 lshift DMA1_CCR3        \ DMA1_MINC	Bit Offset:7	Bit Width:1
\ %xx  8 lshift DMA1_CCR3        \ DMA1_PSIZE	Bit Offset:8	Bit Width:2
\ %xx  10 lshift DMA1_CCR3        \ DMA1_MSIZE	Bit Offset:10	Bit Width:2
\ %xx  12 lshift DMA1_CCR3        \ DMA1_PL	Bit Offset:12	Bit Width:2
\ %1  14 lshift DMA1_CCR3        \ DMA1_MEM2MEM	Bit Offset:14	Bit Width:1

\ DMA1_CNDTR3 read-write
$00000000 CONSTANT RESET_DMA1_CNDTR3 
\ %xxxxxxxxxxxxxxxx  0 lshift DMA1_CNDTR3        \ DMA1_NDT	Bit Offset:0	Bit Width:16

\ DMA1_CPAR3 read-write
$00000000 CONSTANT RESET_DMA1_CPAR3 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA1_CPAR3        \ DMA1_PA	Bit Offset:0	Bit Width:32

\ DMA1_CMAR3 read-write
$00000000 CONSTANT RESET_DMA1_CMAR3 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA1_CMAR3        \ DMA1_MA	Bit Offset:0	Bit Width:32

\ DMA1_CCR4 read-write
$00000000 CONSTANT RESET_DMA1_CCR4 
\ %1  0 lshift DMA1_CCR4        \ DMA1_EN	Bit Offset:0	Bit Width:1
\ %1  1 lshift DMA1_CCR4        \ DMA1_TCIE	Bit Offset:1	Bit Width:1
\ %1  2 lshift DMA1_CCR4        \ DMA1_HTIE	Bit Offset:2	Bit Width:1
\ %1  3 lshift DMA1_CCR4        \ DMA1_TEIE	Bit Offset:3	Bit Width:1
\ %1  4 lshift DMA1_CCR4        \ DMA1_DIR	Bit Offset:4	Bit Width:1
\ %1  5 lshift DMA1_CCR4        \ DMA1_CIRC	Bit Offset:5	Bit Width:1
\ %1  6 lshift DMA1_CCR4        \ DMA1_PINC	Bit Offset:6	Bit Width:1
\ %1  7 lshift DMA1_CCR4        \ DMA1_MINC	Bit Offset:7	Bit Width:1
\ %xx  8 lshift DMA1_CCR4        \ DMA1_PSIZE	Bit Offset:8	Bit Width:2
\ %xx  10 lshift DMA1_CCR4        \ DMA1_MSIZE	Bit Offset:10	Bit Width:2
\ %xx  12 lshift DMA1_CCR4        \ DMA1_PL	Bit Offset:12	Bit Width:2
\ %1  14 lshift DMA1_CCR4        \ DMA1_MEM2MEM	Bit Offset:14	Bit Width:1

\ DMA1_CNDTR4 read-write
$00000000 CONSTANT RESET_DMA1_CNDTR4 
\ %xxxxxxxxxxxxxxxx  0 lshift DMA1_CNDTR4        \ DMA1_NDT	Bit Offset:0	Bit Width:16

\ DMA1_CPAR4 read-write
$00000000 CONSTANT RESET_DMA1_CPAR4 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA1_CPAR4        \ DMA1_PA	Bit Offset:0	Bit Width:32

\ DMA1_CMAR4 read-write
$00000000 CONSTANT RESET_DMA1_CMAR4 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA1_CMAR4        \ DMA1_MA	Bit Offset:0	Bit Width:32

\ DMA1_CCR5 read-write
$00000000 CONSTANT RESET_DMA1_CCR5 
\ %1  0 lshift DMA1_CCR5        \ DMA1_EN	Bit Offset:0	Bit Width:1
\ %1  1 lshift DMA1_CCR5        \ DMA1_TCIE	Bit Offset:1	Bit Width:1
\ %1  2 lshift DMA1_CCR5        \ DMA1_HTIE	Bit Offset:2	Bit Width:1
\ %1  3 lshift DMA1_CCR5        \ DMA1_TEIE	Bit Offset:3	Bit Width:1
\ %1  4 lshift DMA1_CCR5        \ DMA1_DIR	Bit Offset:4	Bit Width:1
\ %1  5 lshift DMA1_CCR5        \ DMA1_CIRC	Bit Offset:5	Bit Width:1
\ %1  6 lshift DMA1_CCR5        \ DMA1_PINC	Bit Offset:6	Bit Width:1
\ %1  7 lshift DMA1_CCR5        \ DMA1_MINC	Bit Offset:7	Bit Width:1
\ %xx  8 lshift DMA1_CCR5        \ DMA1_PSIZE	Bit Offset:8	Bit Width:2
\ %xx  10 lshift DMA1_CCR5        \ DMA1_MSIZE	Bit Offset:10	Bit Width:2
\ %xx  12 lshift DMA1_CCR5        \ DMA1_PL	Bit Offset:12	Bit Width:2
\ %1  14 lshift DMA1_CCR5        \ DMA1_MEM2MEM	Bit Offset:14	Bit Width:1

\ DMA1_CNDTR5 read-write
$00000000 CONSTANT RESET_DMA1_CNDTR5 
\ %xxxxxxxxxxxxxxxx  0 lshift DMA1_CNDTR5        \ DMA1_NDT	Bit Offset:0	Bit Width:16

\ DMA1_CPAR5 read-write
$00000000 CONSTANT RESET_DMA1_CPAR5 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA1_CPAR5        \ DMA1_PA	Bit Offset:0	Bit Width:32

\ DMA1_CMAR5 read-write
$00000000 CONSTANT RESET_DMA1_CMAR5 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA1_CMAR5        \ DMA1_MA	Bit Offset:0	Bit Width:32

\ DMA1_CCR6 read-write
$00000000 CONSTANT RESET_DMA1_CCR6 
\ %1  0 lshift DMA1_CCR6        \ DMA1_EN	Bit Offset:0	Bit Width:1
\ %1  1 lshift DMA1_CCR6        \ DMA1_TCIE	Bit Offset:1	Bit Width:1
\ %1  2 lshift DMA1_CCR6        \ DMA1_HTIE	Bit Offset:2	Bit Width:1
\ %1  3 lshift DMA1_CCR6        \ DMA1_TEIE	Bit Offset:3	Bit Width:1
\ %1  4 lshift DMA1_CCR6        \ DMA1_DIR	Bit Offset:4	Bit Width:1
\ %1  5 lshift DMA1_CCR6        \ DMA1_CIRC	Bit Offset:5	Bit Width:1
\ %1  6 lshift DMA1_CCR6        \ DMA1_PINC	Bit Offset:6	Bit Width:1
\ %1  7 lshift DMA1_CCR6        \ DMA1_MINC	Bit Offset:7	Bit Width:1
\ %xx  8 lshift DMA1_CCR6        \ DMA1_PSIZE	Bit Offset:8	Bit Width:2
\ %xx  10 lshift DMA1_CCR6        \ DMA1_MSIZE	Bit Offset:10	Bit Width:2
\ %xx  12 lshift DMA1_CCR6        \ DMA1_PL	Bit Offset:12	Bit Width:2
\ %1  14 lshift DMA1_CCR6        \ DMA1_MEM2MEM	Bit Offset:14	Bit Width:1

\ DMA1_CNDTR6 read-write
$00000000 CONSTANT RESET_DMA1_CNDTR6 
\ %xxxxxxxxxxxxxxxx  0 lshift DMA1_CNDTR6        \ DMA1_NDT	Bit Offset:0	Bit Width:16

\ DMA1_CPAR6 read-write
$00000000 CONSTANT RESET_DMA1_CPAR6 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA1_CPAR6        \ DMA1_PA	Bit Offset:0	Bit Width:32

\ DMA1_CMAR6 read-write
$00000000 CONSTANT RESET_DMA1_CMAR6 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA1_CMAR6        \ DMA1_MA	Bit Offset:0	Bit Width:32

\ DMA1_CCR7 read-write
$00000000 CONSTANT RESET_DMA1_CCR7 
\ %1  0 lshift DMA1_CCR7        \ DMA1_EN	Bit Offset:0	Bit Width:1
\ %1  1 lshift DMA1_CCR7        \ DMA1_TCIE	Bit Offset:1	Bit Width:1
\ %1  2 lshift DMA1_CCR7        \ DMA1_HTIE	Bit Offset:2	Bit Width:1
\ %1  3 lshift DMA1_CCR7        \ DMA1_TEIE	Bit Offset:3	Bit Width:1
\ %1  4 lshift DMA1_CCR7        \ DMA1_DIR	Bit Offset:4	Bit Width:1
\ %1  5 lshift DMA1_CCR7        \ DMA1_CIRC	Bit Offset:5	Bit Width:1
\ %1  6 lshift DMA1_CCR7        \ DMA1_PINC	Bit Offset:6	Bit Width:1
\ %1  7 lshift DMA1_CCR7        \ DMA1_MINC	Bit Offset:7	Bit Width:1
\ %xx  8 lshift DMA1_CCR7        \ DMA1_PSIZE	Bit Offset:8	Bit Width:2
\ %xx  10 lshift DMA1_CCR7        \ DMA1_MSIZE	Bit Offset:10	Bit Width:2
\ %xx  12 lshift DMA1_CCR7        \ DMA1_PL	Bit Offset:12	Bit Width:2
\ %1  14 lshift DMA1_CCR7        \ DMA1_MEM2MEM	Bit Offset:14	Bit Width:1

\ DMA1_CNDTR7 read-write
$00000000 CONSTANT RESET_DMA1_CNDTR7 
\ %xxxxxxxxxxxxxxxx  0 lshift DMA1_CNDTR7        \ DMA1_NDT	Bit Offset:0	Bit Width:16

\ DMA1_CPAR7 read-write
$00000000 CONSTANT RESET_DMA1_CPAR7 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA1_CPAR7        \ DMA1_PA	Bit Offset:0	Bit Width:32

\ DMA1_CMAR7 read-write
$00000000 CONSTANT RESET_DMA1_CMAR7 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift DMA1_CMAR7        \ DMA1_MA	Bit Offset:0	Bit Width:32

  
\ DMA2
  
\ SDIO
\ SDIO_POWER read-write
$00000000 CONSTANT RESET_SDIO_POWER 
\ %xx  0 lshift SDIO_POWER        \ SDIO_PWRCTRL	Bit Offset:0	Bit Width:2

\ SDIO_CLKCR read-write
$00000000 CONSTANT RESET_SDIO_CLKCR 
\ %xxxxxxxx  0 lshift SDIO_CLKCR        \ SDIO_CLKDIV	Bit Offset:0	Bit Width:8
\ %1  8 lshift SDIO_CLKCR        \ SDIO_CLKEN	Bit Offset:8	Bit Width:1
\ %1  9 lshift SDIO_CLKCR        \ SDIO_PWRSAV	Bit Offset:9	Bit Width:1
\ %1  10 lshift SDIO_CLKCR        \ SDIO_BYPASS	Bit Offset:10	Bit Width:1
\ %xx  11 lshift SDIO_CLKCR        \ SDIO_WIDBUS	Bit Offset:11	Bit Width:2
\ %1  13 lshift SDIO_CLKCR        \ SDIO_NEGEDGE	Bit Offset:13	Bit Width:1
\ %1  14 lshift SDIO_CLKCR        \ SDIO_HWFC_EN	Bit Offset:14	Bit Width:1

\ SDIO_ARG read-write
$00000000 CONSTANT RESET_SDIO_ARG 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift SDIO_ARG        \ SDIO_CMDARG	Bit Offset:0	Bit Width:32

\ SDIO_CMD read-write
$00000000 CONSTANT RESET_SDIO_CMD 
\ %xxxxxx  0 lshift SDIO_CMD        \ SDIO_CMDINDEX	Bit Offset:0	Bit Width:6
\ %xx  6 lshift SDIO_CMD        \ SDIO_WAITRESP	Bit Offset:6	Bit Width:2
\ %1  8 lshift SDIO_CMD        \ SDIO_WAITINT	Bit Offset:8	Bit Width:1
\ %1  9 lshift SDIO_CMD        \ SDIO_WAITPEND	Bit Offset:9	Bit Width:1
\ %1  10 lshift SDIO_CMD        \ SDIO_CPSMEN	Bit Offset:10	Bit Width:1
\ %1  11 lshift SDIO_CMD        \ SDIO_SDIOSuspend	Bit Offset:11	Bit Width:1
\ %1  12 lshift SDIO_CMD        \ SDIO_ENCMDcompl	Bit Offset:12	Bit Width:1
\ %1  13 lshift SDIO_CMD        \ SDIO_nIEN	Bit Offset:13	Bit Width:1
\ %1  14 lshift SDIO_CMD        \ SDIO_CE_ATACMD	Bit Offset:14	Bit Width:1

\ SDIO_RESPCMD read-only
$00000000 CONSTANT RESET_SDIO_RESPCMD 
\ %xxxxxx  0 lshift SDIO_RESPCMD        \ SDIO_RESPCMD	Bit Offset:0	Bit Width:6

\ SDIO_RESPI1 read-only
$00000000 CONSTANT RESET_SDIO_RESPI1 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift SDIO_RESPI1        \ SDIO_CARDSTATUS1	Bit Offset:0	Bit Width:32

\ SDIO_RESP2 read-only
$00000000 CONSTANT RESET_SDIO_RESP2 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift SDIO_RESP2        \ SDIO_CARDSTATUS2	Bit Offset:0	Bit Width:32

\ SDIO_RESP3 read-only
$00000000 CONSTANT RESET_SDIO_RESP3 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift SDIO_RESP3        \ SDIO_CARDSTATUS3	Bit Offset:0	Bit Width:32

\ SDIO_RESP4 read-only
$00000000 CONSTANT RESET_SDIO_RESP4 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift SDIO_RESP4        \ SDIO_CARDSTATUS4	Bit Offset:0	Bit Width:32

\ SDIO_DTIMER read-write
$00000000 CONSTANT RESET_SDIO_DTIMER 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift SDIO_DTIMER        \ SDIO_DATATIME	Bit Offset:0	Bit Width:32

\ SDIO_DLEN read-write
$00000000 CONSTANT RESET_SDIO_DLEN 
\ % 0 lshift SDIO_DLEN        \ SDIO_DATALENGTH	Bit Offset:0	Bit Width:25

\ SDIO_DCTRL read-write
$00000000 CONSTANT RESET_SDIO_DCTRL 
\ %1  0 lshift SDIO_DCTRL        \ SDIO_DTEN	Bit Offset:0	Bit Width:1
\ %1  1 lshift SDIO_DCTRL        \ SDIO_DTDIR	Bit Offset:1	Bit Width:1
\ %1  2 lshift SDIO_DCTRL        \ SDIO_DTMODE	Bit Offset:2	Bit Width:1
\ %1  3 lshift SDIO_DCTRL        \ SDIO_DMAEN	Bit Offset:3	Bit Width:1
\ %xxxx  4 lshift SDIO_DCTRL        \ SDIO_DBLOCKSIZE	Bit Offset:4	Bit Width:4
\ %1  8 lshift SDIO_DCTRL        \ SDIO_PWSTART	Bit Offset:8	Bit Width:1
\ %1  9 lshift SDIO_DCTRL        \ SDIO_PWSTOP	Bit Offset:9	Bit Width:1
\ %1  10 lshift SDIO_DCTRL        \ SDIO_RWMOD	Bit Offset:10	Bit Width:1
\ %1  11 lshift SDIO_DCTRL        \ SDIO_SDIOEN	Bit Offset:11	Bit Width:1

\ SDIO_DCOUNT read-only
$00000000 CONSTANT RESET_SDIO_DCOUNT 
\ % 0 lshift SDIO_DCOUNT        \ SDIO_DATACOUNT	Bit Offset:0	Bit Width:25

\ SDIO_STA read-only
$00000000 CONSTANT RESET_SDIO_STA 
\ %1  0 lshift SDIO_STA        \ SDIO_CCRCFAIL	Bit Offset:0	Bit Width:1
\ %1  1 lshift SDIO_STA        \ SDIO_DCRCFAIL	Bit Offset:1	Bit Width:1
\ %1  2 lshift SDIO_STA        \ SDIO_CTIMEOUT	Bit Offset:2	Bit Width:1
\ %1  3 lshift SDIO_STA        \ SDIO_DTIMEOUT	Bit Offset:3	Bit Width:1
\ %1  4 lshift SDIO_STA        \ SDIO_TXUNDERR	Bit Offset:4	Bit Width:1
\ %1  5 lshift SDIO_STA        \ SDIO_RXOVERR	Bit Offset:5	Bit Width:1
\ %1  6 lshift SDIO_STA        \ SDIO_CMDREND	Bit Offset:6	Bit Width:1
\ %1  7 lshift SDIO_STA        \ SDIO_CMDSENT	Bit Offset:7	Bit Width:1
\ %1  8 lshift SDIO_STA        \ SDIO_DATAEND	Bit Offset:8	Bit Width:1
\ %1  9 lshift SDIO_STA        \ SDIO_STBITERR	Bit Offset:9	Bit Width:1
\ %1  10 lshift SDIO_STA        \ SDIO_DBCKEND	Bit Offset:10	Bit Width:1
\ %1  11 lshift SDIO_STA        \ SDIO_CMDACT	Bit Offset:11	Bit Width:1
\ %1  12 lshift SDIO_STA        \ SDIO_TXACT	Bit Offset:12	Bit Width:1
\ %1  13 lshift SDIO_STA        \ SDIO_RXACT	Bit Offset:13	Bit Width:1
\ %1  14 lshift SDIO_STA        \ SDIO_TXFIFOHE	Bit Offset:14	Bit Width:1
\ %1  15 lshift SDIO_STA        \ SDIO_RXFIFOHF	Bit Offset:15	Bit Width:1
\ %1  16 lshift SDIO_STA        \ SDIO_TXFIFOF	Bit Offset:16	Bit Width:1
\ %1  17 lshift SDIO_STA        \ SDIO_RXFIFOF	Bit Offset:17	Bit Width:1
\ %1  18 lshift SDIO_STA        \ SDIO_TXFIFOE	Bit Offset:18	Bit Width:1
\ %1  19 lshift SDIO_STA        \ SDIO_RXFIFOE	Bit Offset:19	Bit Width:1
\ %1  20 lshift SDIO_STA        \ SDIO_TXDAVL	Bit Offset:20	Bit Width:1
\ %1  21 lshift SDIO_STA        \ SDIO_RXDAVL	Bit Offset:21	Bit Width:1
\ %1  22 lshift SDIO_STA        \ SDIO_SDIOIT	Bit Offset:22	Bit Width:1
\ %1  23 lshift SDIO_STA        \ SDIO_CEATAEND	Bit Offset:23	Bit Width:1

\ SDIO_ICR read-write
$00000000 CONSTANT RESET_SDIO_ICR 
\ %1  0 lshift SDIO_ICR        \ SDIO_CCRCFAILC	Bit Offset:0	Bit Width:1
\ %1  1 lshift SDIO_ICR        \ SDIO_DCRCFAILC	Bit Offset:1	Bit Width:1
\ %1  2 lshift SDIO_ICR        \ SDIO_CTIMEOUTC	Bit Offset:2	Bit Width:1
\ %1  3 lshift SDIO_ICR        \ SDIO_DTIMEOUTC	Bit Offset:3	Bit Width:1
\ %1  4 lshift SDIO_ICR        \ SDIO_TXUNDERRC	Bit Offset:4	Bit Width:1
\ %1  5 lshift SDIO_ICR        \ SDIO_RXOVERRC	Bit Offset:5	Bit Width:1
\ %1  6 lshift SDIO_ICR        \ SDIO_CMDRENDC	Bit Offset:6	Bit Width:1
\ %1  7 lshift SDIO_ICR        \ SDIO_CMDSENTC	Bit Offset:7	Bit Width:1
\ %1  8 lshift SDIO_ICR        \ SDIO_DATAENDC	Bit Offset:8	Bit Width:1
\ %1  9 lshift SDIO_ICR        \ SDIO_STBITERRC	Bit Offset:9	Bit Width:1
\ %1  10 lshift SDIO_ICR        \ SDIO_DBCKENDC	Bit Offset:10	Bit Width:1
\ %1  22 lshift SDIO_ICR        \ SDIO_SDIOITC	Bit Offset:22	Bit Width:1
\ %1  23 lshift SDIO_ICR        \ SDIO_CEATAENDC	Bit Offset:23	Bit Width:1

\ SDIO_MASK read-write
$00000000 CONSTANT RESET_SDIO_MASK 
\ %1  0 lshift SDIO_MASK        \ SDIO_CCRCFAILIE	Bit Offset:0	Bit Width:1
\ %1  1 lshift SDIO_MASK        \ SDIO_DCRCFAILIE	Bit Offset:1	Bit Width:1
\ %1  2 lshift SDIO_MASK        \ SDIO_CTIMEOUTIE	Bit Offset:2	Bit Width:1
\ %1  3 lshift SDIO_MASK        \ SDIO_DTIMEOUTIE	Bit Offset:3	Bit Width:1
\ %1  4 lshift SDIO_MASK        \ SDIO_TXUNDERRIE	Bit Offset:4	Bit Width:1
\ %1  5 lshift SDIO_MASK        \ SDIO_RXOVERRIE	Bit Offset:5	Bit Width:1
\ %1  6 lshift SDIO_MASK        \ SDIO_CMDRENDIE	Bit Offset:6	Bit Width:1
\ %1  7 lshift SDIO_MASK        \ SDIO_CMDSENTIE	Bit Offset:7	Bit Width:1
\ %1  8 lshift SDIO_MASK        \ SDIO_DATAENDIE	Bit Offset:8	Bit Width:1
\ %1  9 lshift SDIO_MASK        \ SDIO_STBITERRIE	Bit Offset:9	Bit Width:1
\ %1  10 lshift SDIO_MASK        \ SDIO_DBACKENDIE	Bit Offset:10	Bit Width:1
\ %1  11 lshift SDIO_MASK        \ SDIO_CMDACTIE	Bit Offset:11	Bit Width:1
\ %1  12 lshift SDIO_MASK        \ SDIO_TXACTIE	Bit Offset:12	Bit Width:1
\ %1  13 lshift SDIO_MASK        \ SDIO_RXACTIE	Bit Offset:13	Bit Width:1
\ %1  14 lshift SDIO_MASK        \ SDIO_TXFIFOHEIE	Bit Offset:14	Bit Width:1
\ %1  15 lshift SDIO_MASK        \ SDIO_RXFIFOHFIE	Bit Offset:15	Bit Width:1
\ %1  16 lshift SDIO_MASK        \ SDIO_TXFIFOFIE	Bit Offset:16	Bit Width:1
\ %1  17 lshift SDIO_MASK        \ SDIO_RXFIFOFIE	Bit Offset:17	Bit Width:1
\ %1  18 lshift SDIO_MASK        \ SDIO_TXFIFOEIE	Bit Offset:18	Bit Width:1
\ %1  19 lshift SDIO_MASK        \ SDIO_RXFIFOEIE	Bit Offset:19	Bit Width:1
\ %1  20 lshift SDIO_MASK        \ SDIO_TXDAVLIE	Bit Offset:20	Bit Width:1
\ %1  21 lshift SDIO_MASK        \ SDIO_RXDAVLIE	Bit Offset:21	Bit Width:1
\ %1  22 lshift SDIO_MASK        \ SDIO_SDIOITIE	Bit Offset:22	Bit Width:1
\ %1  23 lshift SDIO_MASK        \ SDIO_CEATENDIE	Bit Offset:23	Bit Width:1

\ SDIO_FIFOCNT read-only
$00000000 CONSTANT RESET_SDIO_FIFOCNT 
\ %xxxxxxxxxxxxxxxxxxxxxxxx  0 lshift SDIO_FIFOCNT        \ SDIO_FIF0COUNT	Bit Offset:0	Bit Width:24

\ SDIO_FIFO read-write
$00000000 CONSTANT RESET_SDIO_FIFO 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift SDIO_FIFO        \ SDIO_FIFOData	Bit Offset:0	Bit Width:32

  
\ RTC
\ RTC_CRH read-write
$00000000 CONSTANT RESET_RTC_CRH 
\ %1  0 lshift RTC_CRH        \ RTC_SECIE	Bit Offset:0	Bit Width:1
\ %1  1 lshift RTC_CRH        \ RTC_ALRIE	Bit Offset:1	Bit Width:1
\ %1  2 lshift RTC_CRH        \ RTC_OWIE	Bit Offset:2	Bit Width:1

\ RTC_CRL 
$00000020 CONSTANT RESET_RTC_CRL 
\ %1  0 lshift RTC_CRL        \ RTC_SECF	Bit Offset:0	Bit Width:1
\ %1  1 lshift RTC_CRL        \ RTC_ALRF	Bit Offset:1	Bit Width:1
\ %1  2 lshift RTC_CRL        \ RTC_OWF	Bit Offset:2	Bit Width:1
\ %1  3 lshift RTC_CRL        \ RTC_RSF	Bit Offset:3	Bit Width:1
\ %1  4 lshift RTC_CRL        \ RTC_CNF	Bit Offset:4	Bit Width:1
\ %1  5 lshift RTC_CRL        \ RTC_RTOFF	Bit Offset:5	Bit Width:1

\ RTC_PRLH write-only
$00000000 CONSTANT RESET_RTC_PRLH 
\ %xxxx  0 lshift RTC_PRLH        \ RTC_PRLH	Bit Offset:0	Bit Width:4

\ RTC_PRLL write-only
$8000 CONSTANT RESET_RTC_PRLL 
\ %xxxxxxxxxxxxxxxx  0 lshift RTC_PRLL        \ RTC_PRLL	Bit Offset:0	Bit Width:16

\ RTC_DIVH read-only
$00000000 CONSTANT RESET_RTC_DIVH 
\ %xxxx  0 lshift RTC_DIVH        \ RTC_DIVH	Bit Offset:0	Bit Width:4

\ RTC_DIVL read-only
$8000 CONSTANT RESET_RTC_DIVL 
\ %xxxxxxxxxxxxxxxx  0 lshift RTC_DIVL        \ RTC_DIVL	Bit Offset:0	Bit Width:16

\ RTC_CNTH read-write
$00000000 CONSTANT RESET_RTC_CNTH 
\ %xxxxxxxxxxxxxxxx  0 lshift RTC_CNTH        \ RTC_CNTH	Bit Offset:0	Bit Width:16

\ RTC_CNTL read-write
$00000000 CONSTANT RESET_RTC_CNTL 
\ %xxxxxxxxxxxxxxxx  0 lshift RTC_CNTL        \ RTC_CNTL	Bit Offset:0	Bit Width:16

\ RTC_ALRH write-only
$FFFF CONSTANT RESET_RTC_ALRH 
\ %xxxxxxxxxxxxxxxx  0 lshift RTC_ALRH        \ RTC_ALRH	Bit Offset:0	Bit Width:16

\ RTC_ALRL write-only
$FFFF CONSTANT RESET_RTC_ALRL 
\ %xxxxxxxxxxxxxxxx  0 lshift RTC_ALRL        \ RTC_ALRL	Bit Offset:0	Bit Width:16

  
\ BKP
\ BKP_DR1 read-write
$00000000 CONSTANT RESET_BKP_DR1 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR1        \ BKP_D1	Bit Offset:0	Bit Width:16

\ BKP_DR2 read-write
$00000000 CONSTANT RESET_BKP_DR2 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR2        \ BKP_D2	Bit Offset:0	Bit Width:16

\ BKP_DR3 read-write
$00000000 CONSTANT RESET_BKP_DR3 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR3        \ BKP_D3	Bit Offset:0	Bit Width:16

\ BKP_DR4 read-write
$00000000 CONSTANT RESET_BKP_DR4 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR4        \ BKP_D4	Bit Offset:0	Bit Width:16

\ BKP_DR5 read-write
$00000000 CONSTANT RESET_BKP_DR5 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR5        \ BKP_D5	Bit Offset:0	Bit Width:16

\ BKP_DR6 read-write
$00000000 CONSTANT RESET_BKP_DR6 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR6        \ BKP_D6	Bit Offset:0	Bit Width:16

\ BKP_DR7 read-write
$00000000 CONSTANT RESET_BKP_DR7 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR7        \ BKP_D7	Bit Offset:0	Bit Width:16

\ BKP_DR8 read-write
$00000000 CONSTANT RESET_BKP_DR8 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR8        \ BKP_D8	Bit Offset:0	Bit Width:16

\ BKP_DR9 read-write
$00000000 CONSTANT RESET_BKP_DR9 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR9        \ BKP_D9	Bit Offset:0	Bit Width:16

\ BKP_DR10 read-write
$00000000 CONSTANT RESET_BKP_DR10 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR10        \ BKP_D10	Bit Offset:0	Bit Width:16

\ BKP_DR11 read-write
$00000000 CONSTANT RESET_BKP_DR11 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR11        \ BKP_DR11	Bit Offset:0	Bit Width:16

\ BKP_DR12 read-write
$00000000 CONSTANT RESET_BKP_DR12 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR12        \ BKP_DR12	Bit Offset:0	Bit Width:16

\ BKP_DR13 read-write
$00000000 CONSTANT RESET_BKP_DR13 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR13        \ BKP_DR13	Bit Offset:0	Bit Width:16

\ BKP_DR14 read-write
$00000000 CONSTANT RESET_BKP_DR14 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR14        \ BKP_D14	Bit Offset:0	Bit Width:16

\ BKP_DR15 read-write
$00000000 CONSTANT RESET_BKP_DR15 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR15        \ BKP_D15	Bit Offset:0	Bit Width:16

\ BKP_DR16 read-write
$00000000 CONSTANT RESET_BKP_DR16 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR16        \ BKP_D16	Bit Offset:0	Bit Width:16

\ BKP_DR17 read-write
$00000000 CONSTANT RESET_BKP_DR17 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR17        \ BKP_D17	Bit Offset:0	Bit Width:16

\ BKP_DR18 read-write
$00000000 CONSTANT RESET_BKP_DR18 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR18        \ BKP_D18	Bit Offset:0	Bit Width:16

\ BKP_DR19 read-write
$00000000 CONSTANT RESET_BKP_DR19 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR19        \ BKP_D19	Bit Offset:0	Bit Width:16

\ BKP_DR20 read-write
$00000000 CONSTANT RESET_BKP_DR20 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR20        \ BKP_D20	Bit Offset:0	Bit Width:16

\ BKP_DR21 read-write
$00000000 CONSTANT RESET_BKP_DR21 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR21        \ BKP_D21	Bit Offset:0	Bit Width:16

\ BKP_DR22 read-write
$00000000 CONSTANT RESET_BKP_DR22 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR22        \ BKP_D22	Bit Offset:0	Bit Width:16

\ BKP_DR23 read-write
$00000000 CONSTANT RESET_BKP_DR23 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR23        \ BKP_D23	Bit Offset:0	Bit Width:16

\ BKP_DR24 read-write
$00000000 CONSTANT RESET_BKP_DR24 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR24        \ BKP_D24	Bit Offset:0	Bit Width:16

\ BKP_DR25 read-write
$00000000 CONSTANT RESET_BKP_DR25 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR25        \ BKP_D25	Bit Offset:0	Bit Width:16

\ BKP_DR26 read-write
$00000000 CONSTANT RESET_BKP_DR26 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR26        \ BKP_D26	Bit Offset:0	Bit Width:16

\ BKP_DR27 read-write
$00000000 CONSTANT RESET_BKP_DR27 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR27        \ BKP_D27	Bit Offset:0	Bit Width:16

\ BKP_DR28 read-write
$00000000 CONSTANT RESET_BKP_DR28 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR28        \ BKP_D28	Bit Offset:0	Bit Width:16

\ BKP_DR29 read-write
$00000000 CONSTANT RESET_BKP_DR29 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR29        \ BKP_D29	Bit Offset:0	Bit Width:16

\ BKP_DR30 read-write
$00000000 CONSTANT RESET_BKP_DR30 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR30        \ BKP_D30	Bit Offset:0	Bit Width:16

\ BKP_DR31 read-write
$00000000 CONSTANT RESET_BKP_DR31 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR31        \ BKP_D31	Bit Offset:0	Bit Width:16

\ BKP_DR32 read-write
$00000000 CONSTANT RESET_BKP_DR32 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR32        \ BKP_D32	Bit Offset:0	Bit Width:16

\ BKP_DR33 read-write
$00000000 CONSTANT RESET_BKP_DR33 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR33        \ BKP_D33	Bit Offset:0	Bit Width:16

\ BKP_DR34 read-write
$00000000 CONSTANT RESET_BKP_DR34 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR34        \ BKP_D34	Bit Offset:0	Bit Width:16

\ BKP_DR35 read-write
$00000000 CONSTANT RESET_BKP_DR35 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR35        \ BKP_D35	Bit Offset:0	Bit Width:16

\ BKP_DR36 read-write
$00000000 CONSTANT RESET_BKP_DR36 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR36        \ BKP_D36	Bit Offset:0	Bit Width:16

\ BKP_DR37 read-write
$00000000 CONSTANT RESET_BKP_DR37 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR37        \ BKP_D37	Bit Offset:0	Bit Width:16

\ BKP_DR38 read-write
$00000000 CONSTANT RESET_BKP_DR38 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR38        \ BKP_D38	Bit Offset:0	Bit Width:16

\ BKP_DR39 read-write
$00000000 CONSTANT RESET_BKP_DR39 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR39        \ BKP_D39	Bit Offset:0	Bit Width:16

\ BKP_DR40 read-write
$00000000 CONSTANT RESET_BKP_DR40 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR40        \ BKP_D40	Bit Offset:0	Bit Width:16

\ BKP_DR41 read-write
$00000000 CONSTANT RESET_BKP_DR41 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR41        \ BKP_D41	Bit Offset:0	Bit Width:16

\ BKP_DR42 read-write
$00000000 CONSTANT RESET_BKP_DR42 
\ %xxxxxxxxxxxxxxxx  0 lshift BKP_DR42        \ BKP_D42	Bit Offset:0	Bit Width:16

\ BKP_RTCCR read-write
$00000000 CONSTANT RESET_BKP_RTCCR 
\ %xxxxxxx  0 lshift BKP_RTCCR        \ BKP_CAL	Bit Offset:0	Bit Width:7
\ %1  7 lshift BKP_RTCCR        \ BKP_CCO	Bit Offset:7	Bit Width:1
\ %1  8 lshift BKP_RTCCR        \ BKP_ASOE	Bit Offset:8	Bit Width:1
\ %1  9 lshift BKP_RTCCR        \ BKP_ASOS	Bit Offset:9	Bit Width:1

\ BKP_CR read-write
$00000000 CONSTANT RESET_BKP_CR 
\ %1  0 lshift BKP_CR        \ BKP_TPE	Bit Offset:0	Bit Width:1
\ %1  1 lshift BKP_CR        \ BKP_TPAL	Bit Offset:1	Bit Width:1

\ BKP_CSR 
$00000000 CONSTANT RESET_BKP_CSR 
\ %1  0 lshift BKP_CSR        \ BKP_CTE	Bit Offset:0	Bit Width:1
\ %1  1 lshift BKP_CSR        \ BKP_CTI	Bit Offset:1	Bit Width:1
\ %1  2 lshift BKP_CSR        \ BKP_TPIE	Bit Offset:2	Bit Width:1
\ %1  8 lshift BKP_CSR        \ BKP_TEF	Bit Offset:8	Bit Width:1
\ %1  9 lshift BKP_CSR        \ BKP_TIF	Bit Offset:9	Bit Width:1

  
\ IWDG
\ IWDG_KR write-only
$00000000 CONSTANT RESET_IWDG_KR 
\ %xxxxxxxxxxxxxxxx  0 lshift IWDG_KR        \ IWDG_KEY	Bit Offset:0	Bit Width:16

\ IWDG_PR read-write
$00000000 CONSTANT RESET_IWDG_PR 
\ %xxx  0 lshift IWDG_PR        \ IWDG_PR	Bit Offset:0	Bit Width:3

\ IWDG_RLR read-write
$00000FFF CONSTANT RESET_IWDG_RLR 
\ %xxxxxxxxxxxx  0 lshift IWDG_RLR        \ IWDG_RL	Bit Offset:0	Bit Width:12

\ IWDG_SR read-only
$00000000 CONSTANT RESET_IWDG_SR 
\ %1  0 lshift IWDG_SR        \ IWDG_PVU	Bit Offset:0	Bit Width:1
\ %1  1 lshift IWDG_SR        \ IWDG_RVU	Bit Offset:1	Bit Width:1

  
\ WWDG
\ WWDG_CR read-write
$0000007F CONSTANT RESET_WWDG_CR 
\ %xxxxxxx  0 lshift WWDG_CR        \ WWDG_T	Bit Offset:0	Bit Width:7
\ %1  7 lshift WWDG_CR        \ WWDG_WDGA	Bit Offset:7	Bit Width:1

\ WWDG_CFR read-write
$0000007F CONSTANT RESET_WWDG_CFR 
\ %xxxxxxx  0 lshift WWDG_CFR        \ WWDG_W	Bit Offset:0	Bit Width:7
\ %xx  7 lshift WWDG_CFR        \ WWDG_WDGTB	Bit Offset:7	Bit Width:2
\ %1  9 lshift WWDG_CFR        \ WWDG_EWI	Bit Offset:9	Bit Width:1

\ WWDG_SR read-write
$00000000 CONSTANT RESET_WWDG_SR 
\ %1  0 lshift WWDG_SR        \ WWDG_EWI	Bit Offset:0	Bit Width:1

  
\ TIM1
\ TIM1_CR1 read-write
$0000 CONSTANT RESET_TIM1_CR1 
\ %xx  8 lshift TIM1_CR1        \ TIM1_CKD	Bit Offset:8	Bit Width:2
\ %1  7 lshift TIM1_CR1        \ TIM1_ARPE	Bit Offset:7	Bit Width:1
\ %xx  5 lshift TIM1_CR1        \ TIM1_CMS	Bit Offset:5	Bit Width:2
\ %1  4 lshift TIM1_CR1        \ TIM1_DIR	Bit Offset:4	Bit Width:1
\ %1  3 lshift TIM1_CR1        \ TIM1_OPM	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM1_CR1        \ TIM1_URS	Bit Offset:2	Bit Width:1
\ %1  1 lshift TIM1_CR1        \ TIM1_UDIS	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM1_CR1        \ TIM1_CEN	Bit Offset:0	Bit Width:1

\ TIM1_CR2 read-write
$0000 CONSTANT RESET_TIM1_CR2 
\ %1  14 lshift TIM1_CR2        \ TIM1_OIS4	Bit Offset:14	Bit Width:1
\ %1  13 lshift TIM1_CR2        \ TIM1_OIS3N	Bit Offset:13	Bit Width:1
\ %1  12 lshift TIM1_CR2        \ TIM1_OIS3	Bit Offset:12	Bit Width:1
\ %1  11 lshift TIM1_CR2        \ TIM1_OIS2N	Bit Offset:11	Bit Width:1
\ %1  10 lshift TIM1_CR2        \ TIM1_OIS2	Bit Offset:10	Bit Width:1
\ %1  9 lshift TIM1_CR2        \ TIM1_OIS1N	Bit Offset:9	Bit Width:1
\ %1  8 lshift TIM1_CR2        \ TIM1_OIS1	Bit Offset:8	Bit Width:1
\ %1  7 lshift TIM1_CR2        \ TIM1_TI1S	Bit Offset:7	Bit Width:1
\ %xxx  4 lshift TIM1_CR2        \ TIM1_MMS	Bit Offset:4	Bit Width:3
\ %1  3 lshift TIM1_CR2        \ TIM1_CCDS	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM1_CR2        \ TIM1_CCUS	Bit Offset:2	Bit Width:1
\ %1  0 lshift TIM1_CR2        \ TIM1_CCPC	Bit Offset:0	Bit Width:1

\ TIM1_SMCR read-write
$0000 CONSTANT RESET_TIM1_SMCR 
\ %1  15 lshift TIM1_SMCR        \ TIM1_ETP	Bit Offset:15	Bit Width:1
\ %1  14 lshift TIM1_SMCR        \ TIM1_ECE	Bit Offset:14	Bit Width:1
\ %xx  12 lshift TIM1_SMCR        \ TIM1_ETPS	Bit Offset:12	Bit Width:2
\ %xxxx  8 lshift TIM1_SMCR        \ TIM1_ETF	Bit Offset:8	Bit Width:4
\ %1  7 lshift TIM1_SMCR        \ TIM1_MSM	Bit Offset:7	Bit Width:1
\ %xxx  4 lshift TIM1_SMCR        \ TIM1_TS	Bit Offset:4	Bit Width:3
\ %xxx  0 lshift TIM1_SMCR        \ TIM1_SMS	Bit Offset:0	Bit Width:3

\ TIM1_DIER read-write
$0000 CONSTANT RESET_TIM1_DIER 
\ %1  14 lshift TIM1_DIER        \ TIM1_TDE	Bit Offset:14	Bit Width:1
\ %1  13 lshift TIM1_DIER        \ TIM1_COMDE	Bit Offset:13	Bit Width:1
\ %1  12 lshift TIM1_DIER        \ TIM1_CC4DE	Bit Offset:12	Bit Width:1
\ %1  11 lshift TIM1_DIER        \ TIM1_CC3DE	Bit Offset:11	Bit Width:1
\ %1  10 lshift TIM1_DIER        \ TIM1_CC2DE	Bit Offset:10	Bit Width:1
\ %1  9 lshift TIM1_DIER        \ TIM1_CC1DE	Bit Offset:9	Bit Width:1
\ %1  8 lshift TIM1_DIER        \ TIM1_UDE	Bit Offset:8	Bit Width:1
\ %1  6 lshift TIM1_DIER        \ TIM1_TIE	Bit Offset:6	Bit Width:1
\ %1  4 lshift TIM1_DIER        \ TIM1_CC4IE	Bit Offset:4	Bit Width:1
\ %1  3 lshift TIM1_DIER        \ TIM1_CC3IE	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM1_DIER        \ TIM1_CC2IE	Bit Offset:2	Bit Width:1
\ %1  1 lshift TIM1_DIER        \ TIM1_CC1IE	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM1_DIER        \ TIM1_UIE	Bit Offset:0	Bit Width:1
\ %1  7 lshift TIM1_DIER        \ TIM1_BIE	Bit Offset:7	Bit Width:1
\ %1  5 lshift TIM1_DIER        \ TIM1_COMIE	Bit Offset:5	Bit Width:1

\ TIM1_SR read-write
$0000 CONSTANT RESET_TIM1_SR 
\ %1  12 lshift TIM1_SR        \ TIM1_CC4OF	Bit Offset:12	Bit Width:1
\ %1  11 lshift TIM1_SR        \ TIM1_CC3OF	Bit Offset:11	Bit Width:1
\ %1  10 lshift TIM1_SR        \ TIM1_CC2OF	Bit Offset:10	Bit Width:1
\ %1  9 lshift TIM1_SR        \ TIM1_CC1OF	Bit Offset:9	Bit Width:1
\ %1  7 lshift TIM1_SR        \ TIM1_BIF	Bit Offset:7	Bit Width:1
\ %1  6 lshift TIM1_SR        \ TIM1_TIF	Bit Offset:6	Bit Width:1
\ %1  5 lshift TIM1_SR        \ TIM1_COMIF	Bit Offset:5	Bit Width:1
\ %1  4 lshift TIM1_SR        \ TIM1_CC4IF	Bit Offset:4	Bit Width:1
\ %1  3 lshift TIM1_SR        \ TIM1_CC3IF	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM1_SR        \ TIM1_CC2IF	Bit Offset:2	Bit Width:1
\ %1  1 lshift TIM1_SR        \ TIM1_CC1IF	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM1_SR        \ TIM1_UIF	Bit Offset:0	Bit Width:1

\ TIM1_EGR write-only
$0000 CONSTANT RESET_TIM1_EGR 
\ %1  7 lshift TIM1_EGR        \ TIM1_BG	Bit Offset:7	Bit Width:1
\ %1  6 lshift TIM1_EGR        \ TIM1_TG	Bit Offset:6	Bit Width:1
\ %1  5 lshift TIM1_EGR        \ TIM1_COMG	Bit Offset:5	Bit Width:1
\ %1  4 lshift TIM1_EGR        \ TIM1_CC4G	Bit Offset:4	Bit Width:1
\ %1  3 lshift TIM1_EGR        \ TIM1_CC3G	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM1_EGR        \ TIM1_CC2G	Bit Offset:2	Bit Width:1
\ %1  1 lshift TIM1_EGR        \ TIM1_CC1G	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM1_EGR        \ TIM1_UG	Bit Offset:0	Bit Width:1

\ TIM1_CCMR1_Output read-write
$00000000 CONSTANT RESET_TIM1_CCMR1_Output 
\ %1  15 lshift TIM1_CCMR1_Output        \ TIM1_OC2CE	Bit Offset:15	Bit Width:1
\ %xxx  12 lshift TIM1_CCMR1_Output        \ TIM1_OC2M	Bit Offset:12	Bit Width:3
\ %1  11 lshift TIM1_CCMR1_Output        \ TIM1_OC2PE	Bit Offset:11	Bit Width:1
\ %1  10 lshift TIM1_CCMR1_Output        \ TIM1_OC2FE	Bit Offset:10	Bit Width:1
\ %xx  8 lshift TIM1_CCMR1_Output        \ TIM1_CC2S	Bit Offset:8	Bit Width:2
\ %1  7 lshift TIM1_CCMR1_Output        \ TIM1_OC1CE	Bit Offset:7	Bit Width:1
\ %xxx  4 lshift TIM1_CCMR1_Output        \ TIM1_OC1M	Bit Offset:4	Bit Width:3
\ %1  3 lshift TIM1_CCMR1_Output        \ TIM1_OC1PE	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM1_CCMR1_Output        \ TIM1_OC1FE	Bit Offset:2	Bit Width:1
\ %xx  0 lshift TIM1_CCMR1_Output        \ TIM1_CC1S	Bit Offset:0	Bit Width:2

\ TIM1_CCMR1_Input read-write
$00000000 CONSTANT RESET_TIM1_CCMR1_Input 
\ %xxxx  12 lshift TIM1_CCMR1_Input        \ TIM1_IC2F	Bit Offset:12	Bit Width:4
\ %xx  10 lshift TIM1_CCMR1_Input        \ TIM1_IC2PCS	Bit Offset:10	Bit Width:2
\ %xx  8 lshift TIM1_CCMR1_Input        \ TIM1_CC2S	Bit Offset:8	Bit Width:2
\ %xxxx  4 lshift TIM1_CCMR1_Input        \ TIM1_IC1F	Bit Offset:4	Bit Width:4
\ %xx  2 lshift TIM1_CCMR1_Input        \ TIM1_ICPCS	Bit Offset:2	Bit Width:2
\ %xx  0 lshift TIM1_CCMR1_Input        \ TIM1_CC1S	Bit Offset:0	Bit Width:2

\ TIM1_CCMR2_Output read-write
$00000000 CONSTANT RESET_TIM1_CCMR2_Output 
\ %1  15 lshift TIM1_CCMR2_Output        \ TIM1_OC4CE	Bit Offset:15	Bit Width:1
\ %xxx  12 lshift TIM1_CCMR2_Output        \ TIM1_OC4M	Bit Offset:12	Bit Width:3
\ %1  11 lshift TIM1_CCMR2_Output        \ TIM1_OC4PE	Bit Offset:11	Bit Width:1
\ %1  10 lshift TIM1_CCMR2_Output        \ TIM1_OC4FE	Bit Offset:10	Bit Width:1
\ %xx  8 lshift TIM1_CCMR2_Output        \ TIM1_CC4S	Bit Offset:8	Bit Width:2
\ %1  7 lshift TIM1_CCMR2_Output        \ TIM1_OC3CE	Bit Offset:7	Bit Width:1
\ %xxx  4 lshift TIM1_CCMR2_Output        \ TIM1_OC3M	Bit Offset:4	Bit Width:3
\ %1  3 lshift TIM1_CCMR2_Output        \ TIM1_OC3PE	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM1_CCMR2_Output        \ TIM1_OC3FE	Bit Offset:2	Bit Width:1
\ %xx  0 lshift TIM1_CCMR2_Output        \ TIM1_CC3S	Bit Offset:0	Bit Width:2

\ TIM1_CCMR2_Input read-write
$00000000 CONSTANT RESET_TIM1_CCMR2_Input 
\ %xxxx  12 lshift TIM1_CCMR2_Input        \ TIM1_IC4F	Bit Offset:12	Bit Width:4
\ %xx  10 lshift TIM1_CCMR2_Input        \ TIM1_IC4PSC	Bit Offset:10	Bit Width:2
\ %xx  8 lshift TIM1_CCMR2_Input        \ TIM1_CC4S	Bit Offset:8	Bit Width:2
\ %xxxx  4 lshift TIM1_CCMR2_Input        \ TIM1_IC3F	Bit Offset:4	Bit Width:4
\ %xx  2 lshift TIM1_CCMR2_Input        \ TIM1_IC3PSC	Bit Offset:2	Bit Width:2
\ %xx  0 lshift TIM1_CCMR2_Input        \ TIM1_CC3S	Bit Offset:0	Bit Width:2

\ TIM1_CCER read-write
$0000 CONSTANT RESET_TIM1_CCER 
\ %1  13 lshift TIM1_CCER        \ TIM1_CC4P	Bit Offset:13	Bit Width:1
\ %1  12 lshift TIM1_CCER        \ TIM1_CC4E	Bit Offset:12	Bit Width:1
\ %1  11 lshift TIM1_CCER        \ TIM1_CC3NP	Bit Offset:11	Bit Width:1
\ %1  10 lshift TIM1_CCER        \ TIM1_CC3NE	Bit Offset:10	Bit Width:1
\ %1  9 lshift TIM1_CCER        \ TIM1_CC3P	Bit Offset:9	Bit Width:1
\ %1  8 lshift TIM1_CCER        \ TIM1_CC3E	Bit Offset:8	Bit Width:1
\ %1  7 lshift TIM1_CCER        \ TIM1_CC2NP	Bit Offset:7	Bit Width:1
\ %1  6 lshift TIM1_CCER        \ TIM1_CC2NE	Bit Offset:6	Bit Width:1
\ %1  5 lshift TIM1_CCER        \ TIM1_CC2P	Bit Offset:5	Bit Width:1
\ %1  4 lshift TIM1_CCER        \ TIM1_CC2E	Bit Offset:4	Bit Width:1
\ %1  3 lshift TIM1_CCER        \ TIM1_CC1NP	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM1_CCER        \ TIM1_CC1NE	Bit Offset:2	Bit Width:1
\ %1  1 lshift TIM1_CCER        \ TIM1_CC1P	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM1_CCER        \ TIM1_CC1E	Bit Offset:0	Bit Width:1

\ TIM1_CNT read-write
$00000000 CONSTANT RESET_TIM1_CNT 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM1_CNT        \ TIM1_CNT	Bit Offset:0	Bit Width:16

\ TIM1_PSC read-write
$0000 CONSTANT RESET_TIM1_PSC 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM1_PSC        \ TIM1_PSC	Bit Offset:0	Bit Width:16

\ TIM1_ARR read-write
$00000000 CONSTANT RESET_TIM1_ARR 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM1_ARR        \ TIM1_ARR	Bit Offset:0	Bit Width:16

\ TIM1_CCR1 read-write
$00000000 CONSTANT RESET_TIM1_CCR1 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM1_CCR1        \ TIM1_CCR1	Bit Offset:0	Bit Width:16

\ TIM1_CCR2 read-write
$00000000 CONSTANT RESET_TIM1_CCR2 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM1_CCR2        \ TIM1_CCR2	Bit Offset:0	Bit Width:16

\ TIM1_CCR3 read-write
$00000000 CONSTANT RESET_TIM1_CCR3 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM1_CCR3        \ TIM1_CCR3	Bit Offset:0	Bit Width:16

\ TIM1_CCR4 read-write
$00000000 CONSTANT RESET_TIM1_CCR4 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM1_CCR4        \ TIM1_CCR4	Bit Offset:0	Bit Width:16

\ TIM1_DCR read-write
$0000 CONSTANT RESET_TIM1_DCR 
\ %xxxxx  8 lshift TIM1_DCR        \ TIM1_DBL	Bit Offset:8	Bit Width:5
\ %xxxxx  0 lshift TIM1_DCR        \ TIM1_DBA	Bit Offset:0	Bit Width:5

\ TIM1_DMAR read-write
$0000 CONSTANT RESET_TIM1_DMAR 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM1_DMAR        \ TIM1_DMAB	Bit Offset:0	Bit Width:16

\ TIM1_RCR read-write
$0000 CONSTANT RESET_TIM1_RCR 
\ %xxxxxxxx  0 lshift TIM1_RCR        \ TIM1_REP	Bit Offset:0	Bit Width:8

\ TIM1_BDTR read-write
$0000 CONSTANT RESET_TIM1_BDTR 
\ %1  15 lshift TIM1_BDTR        \ TIM1_MOE	Bit Offset:15	Bit Width:1
\ %1  14 lshift TIM1_BDTR        \ TIM1_AOE	Bit Offset:14	Bit Width:1
\ %1  13 lshift TIM1_BDTR        \ TIM1_BKP	Bit Offset:13	Bit Width:1
\ %1  12 lshift TIM1_BDTR        \ TIM1_BKE	Bit Offset:12	Bit Width:1
\ %1  11 lshift TIM1_BDTR        \ TIM1_OSSR	Bit Offset:11	Bit Width:1
\ %1  10 lshift TIM1_BDTR        \ TIM1_OSSI	Bit Offset:10	Bit Width:1
\ %xx  8 lshift TIM1_BDTR        \ TIM1_LOCK	Bit Offset:8	Bit Width:2
\ %xxxxxxxx  0 lshift TIM1_BDTR        \ TIM1_DTG	Bit Offset:0	Bit Width:8

  
\ TIM8
  
\ TIM2
\ TIM2_CR1 read-write
$0000 CONSTANT RESET_TIM2_CR1 
\ %xx  8 lshift TIM2_CR1        \ TIM2_CKD	Bit Offset:8	Bit Width:2
\ %1  7 lshift TIM2_CR1        \ TIM2_ARPE	Bit Offset:7	Bit Width:1
\ %xx  5 lshift TIM2_CR1        \ TIM2_CMS	Bit Offset:5	Bit Width:2
\ %1  4 lshift TIM2_CR1        \ TIM2_DIR	Bit Offset:4	Bit Width:1
\ %1  3 lshift TIM2_CR1        \ TIM2_OPM	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM2_CR1        \ TIM2_URS	Bit Offset:2	Bit Width:1
\ %1  1 lshift TIM2_CR1        \ TIM2_UDIS	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM2_CR1        \ TIM2_CEN	Bit Offset:0	Bit Width:1

\ TIM2_CR2 read-write
$0000 CONSTANT RESET_TIM2_CR2 
\ %1  7 lshift TIM2_CR2        \ TIM2_TI1S	Bit Offset:7	Bit Width:1
\ %xxx  4 lshift TIM2_CR2        \ TIM2_MMS	Bit Offset:4	Bit Width:3
\ %1  3 lshift TIM2_CR2        \ TIM2_CCDS	Bit Offset:3	Bit Width:1

\ TIM2_SMCR read-write
$0000 CONSTANT RESET_TIM2_SMCR 
\ %1  15 lshift TIM2_SMCR        \ TIM2_ETP	Bit Offset:15	Bit Width:1
\ %1  14 lshift TIM2_SMCR        \ TIM2_ECE	Bit Offset:14	Bit Width:1
\ %xx  12 lshift TIM2_SMCR        \ TIM2_ETPS	Bit Offset:12	Bit Width:2
\ %xxxx  8 lshift TIM2_SMCR        \ TIM2_ETF	Bit Offset:8	Bit Width:4
\ %1  7 lshift TIM2_SMCR        \ TIM2_MSM	Bit Offset:7	Bit Width:1
\ %xxx  4 lshift TIM2_SMCR        \ TIM2_TS	Bit Offset:4	Bit Width:3
\ %xxx  0 lshift TIM2_SMCR        \ TIM2_SMS	Bit Offset:0	Bit Width:3

\ TIM2_DIER read-write
$0000 CONSTANT RESET_TIM2_DIER 
\ %1  14 lshift TIM2_DIER        \ TIM2_TDE	Bit Offset:14	Bit Width:1
\ %1  12 lshift TIM2_DIER        \ TIM2_CC4DE	Bit Offset:12	Bit Width:1
\ %1  11 lshift TIM2_DIER        \ TIM2_CC3DE	Bit Offset:11	Bit Width:1
\ %1  10 lshift TIM2_DIER        \ TIM2_CC2DE	Bit Offset:10	Bit Width:1
\ %1  9 lshift TIM2_DIER        \ TIM2_CC1DE	Bit Offset:9	Bit Width:1
\ %1  8 lshift TIM2_DIER        \ TIM2_UDE	Bit Offset:8	Bit Width:1
\ %1  6 lshift TIM2_DIER        \ TIM2_TIE	Bit Offset:6	Bit Width:1
\ %1  4 lshift TIM2_DIER        \ TIM2_CC4IE	Bit Offset:4	Bit Width:1
\ %1  3 lshift TIM2_DIER        \ TIM2_CC3IE	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM2_DIER        \ TIM2_CC2IE	Bit Offset:2	Bit Width:1
\ %1  1 lshift TIM2_DIER        \ TIM2_CC1IE	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM2_DIER        \ TIM2_UIE	Bit Offset:0	Bit Width:1

\ TIM2_SR read-write
$0000 CONSTANT RESET_TIM2_SR 
\ %1  12 lshift TIM2_SR        \ TIM2_CC4OF	Bit Offset:12	Bit Width:1
\ %1  11 lshift TIM2_SR        \ TIM2_CC3OF	Bit Offset:11	Bit Width:1
\ %1  10 lshift TIM2_SR        \ TIM2_CC2OF	Bit Offset:10	Bit Width:1
\ %1  9 lshift TIM2_SR        \ TIM2_CC1OF	Bit Offset:9	Bit Width:1
\ %1  6 lshift TIM2_SR        \ TIM2_TIF	Bit Offset:6	Bit Width:1
\ %1  4 lshift TIM2_SR        \ TIM2_CC4IF	Bit Offset:4	Bit Width:1
\ %1  3 lshift TIM2_SR        \ TIM2_CC3IF	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM2_SR        \ TIM2_CC2IF	Bit Offset:2	Bit Width:1
\ %1  1 lshift TIM2_SR        \ TIM2_CC1IF	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM2_SR        \ TIM2_UIF	Bit Offset:0	Bit Width:1

\ TIM2_EGR write-only
$0000 CONSTANT RESET_TIM2_EGR 
\ %1  6 lshift TIM2_EGR        \ TIM2_TG	Bit Offset:6	Bit Width:1
\ %1  4 lshift TIM2_EGR        \ TIM2_CC4G	Bit Offset:4	Bit Width:1
\ %1  3 lshift TIM2_EGR        \ TIM2_CC3G	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM2_EGR        \ TIM2_CC2G	Bit Offset:2	Bit Width:1
\ %1  1 lshift TIM2_EGR        \ TIM2_CC1G	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM2_EGR        \ TIM2_UG	Bit Offset:0	Bit Width:1

\ TIM2_CCMR1_Output read-write
$00000000 CONSTANT RESET_TIM2_CCMR1_Output 
\ %1  15 lshift TIM2_CCMR1_Output        \ TIM2_OC2CE	Bit Offset:15	Bit Width:1
\ %xxx  12 lshift TIM2_CCMR1_Output        \ TIM2_OC2M	Bit Offset:12	Bit Width:3
\ %1  11 lshift TIM2_CCMR1_Output        \ TIM2_OC2PE	Bit Offset:11	Bit Width:1
\ %1  10 lshift TIM2_CCMR1_Output        \ TIM2_OC2FE	Bit Offset:10	Bit Width:1
\ %xx  8 lshift TIM2_CCMR1_Output        \ TIM2_CC2S	Bit Offset:8	Bit Width:2
\ %1  7 lshift TIM2_CCMR1_Output        \ TIM2_OC1CE	Bit Offset:7	Bit Width:1
\ %xxx  4 lshift TIM2_CCMR1_Output        \ TIM2_OC1M	Bit Offset:4	Bit Width:3
\ %1  3 lshift TIM2_CCMR1_Output        \ TIM2_OC1PE	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM2_CCMR1_Output        \ TIM2_OC1FE	Bit Offset:2	Bit Width:1
\ %xx  0 lshift TIM2_CCMR1_Output        \ TIM2_CC1S	Bit Offset:0	Bit Width:2

\ TIM2_CCMR1_Input read-write
$00000000 CONSTANT RESET_TIM2_CCMR1_Input 
\ %xxxx  12 lshift TIM2_CCMR1_Input        \ TIM2_IC2F	Bit Offset:12	Bit Width:4
\ %xx  10 lshift TIM2_CCMR1_Input        \ TIM2_IC2PSC	Bit Offset:10	Bit Width:2
\ %xx  8 lshift TIM2_CCMR1_Input        \ TIM2_CC2S	Bit Offset:8	Bit Width:2
\ %xxxx  4 lshift TIM2_CCMR1_Input        \ TIM2_IC1F	Bit Offset:4	Bit Width:4
\ %xx  2 lshift TIM2_CCMR1_Input        \ TIM2_IC1PSC	Bit Offset:2	Bit Width:2
\ %xx  0 lshift TIM2_CCMR1_Input        \ TIM2_CC1S	Bit Offset:0	Bit Width:2

\ TIM2_CCMR2_Output read-write
$00000000 CONSTANT RESET_TIM2_CCMR2_Output 
\ %1  15 lshift TIM2_CCMR2_Output        \ TIM2_O24CE	Bit Offset:15	Bit Width:1
\ %xxx  12 lshift TIM2_CCMR2_Output        \ TIM2_OC4M	Bit Offset:12	Bit Width:3
\ %1  11 lshift TIM2_CCMR2_Output        \ TIM2_OC4PE	Bit Offset:11	Bit Width:1
\ %1  10 lshift TIM2_CCMR2_Output        \ TIM2_OC4FE	Bit Offset:10	Bit Width:1
\ %xx  8 lshift TIM2_CCMR2_Output        \ TIM2_CC4S	Bit Offset:8	Bit Width:2
\ %1  7 lshift TIM2_CCMR2_Output        \ TIM2_OC3CE	Bit Offset:7	Bit Width:1
\ %xxx  4 lshift TIM2_CCMR2_Output        \ TIM2_OC3M	Bit Offset:4	Bit Width:3
\ %1  3 lshift TIM2_CCMR2_Output        \ TIM2_OC3PE	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM2_CCMR2_Output        \ TIM2_OC3FE	Bit Offset:2	Bit Width:1
\ %xx  0 lshift TIM2_CCMR2_Output        \ TIM2_CC3S	Bit Offset:0	Bit Width:2

\ TIM2_CCMR2_Input read-write
$00000000 CONSTANT RESET_TIM2_CCMR2_Input 
\ %xxxx  12 lshift TIM2_CCMR2_Input        \ TIM2_IC4F	Bit Offset:12	Bit Width:4
\ %xx  10 lshift TIM2_CCMR2_Input        \ TIM2_IC4PSC	Bit Offset:10	Bit Width:2
\ %xx  8 lshift TIM2_CCMR2_Input        \ TIM2_CC4S	Bit Offset:8	Bit Width:2
\ %xxxx  4 lshift TIM2_CCMR2_Input        \ TIM2_IC3F	Bit Offset:4	Bit Width:4
\ %xx  2 lshift TIM2_CCMR2_Input        \ TIM2_IC3PSC	Bit Offset:2	Bit Width:2
\ %xx  0 lshift TIM2_CCMR2_Input        \ TIM2_CC3S	Bit Offset:0	Bit Width:2

\ TIM2_CCER read-write
$0000 CONSTANT RESET_TIM2_CCER 
\ %1  13 lshift TIM2_CCER        \ TIM2_CC4P	Bit Offset:13	Bit Width:1
\ %1  12 lshift TIM2_CCER        \ TIM2_CC4E	Bit Offset:12	Bit Width:1
\ %1  9 lshift TIM2_CCER        \ TIM2_CC3P	Bit Offset:9	Bit Width:1
\ %1  8 lshift TIM2_CCER        \ TIM2_CC3E	Bit Offset:8	Bit Width:1
\ %1  5 lshift TIM2_CCER        \ TIM2_CC2P	Bit Offset:5	Bit Width:1
\ %1  4 lshift TIM2_CCER        \ TIM2_CC2E	Bit Offset:4	Bit Width:1
\ %1  1 lshift TIM2_CCER        \ TIM2_CC1P	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM2_CCER        \ TIM2_CC1E	Bit Offset:0	Bit Width:1

\ TIM2_CNT read-write
$00000000 CONSTANT RESET_TIM2_CNT 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM2_CNT        \ TIM2_CNT	Bit Offset:0	Bit Width:16

\ TIM2_PSC read-write
$0000 CONSTANT RESET_TIM2_PSC 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM2_PSC        \ TIM2_PSC	Bit Offset:0	Bit Width:16

\ TIM2_ARR read-write
$00000000 CONSTANT RESET_TIM2_ARR 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM2_ARR        \ TIM2_ARR	Bit Offset:0	Bit Width:16

\ TIM2_CCR1 read-write
$00000000 CONSTANT RESET_TIM2_CCR1 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM2_CCR1        \ TIM2_CCR1	Bit Offset:0	Bit Width:16

\ TIM2_CCR2 read-write
$00000000 CONSTANT RESET_TIM2_CCR2 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM2_CCR2        \ TIM2_CCR2	Bit Offset:0	Bit Width:16

\ TIM2_CCR3 read-write
$00000000 CONSTANT RESET_TIM2_CCR3 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM2_CCR3        \ TIM2_CCR3	Bit Offset:0	Bit Width:16

\ TIM2_CCR4 read-write
$00000000 CONSTANT RESET_TIM2_CCR4 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM2_CCR4        \ TIM2_CCR4	Bit Offset:0	Bit Width:16

\ TIM2_DCR read-write
$0000 CONSTANT RESET_TIM2_DCR 
\ %xxxxx  8 lshift TIM2_DCR        \ TIM2_DBL	Bit Offset:8	Bit Width:5
\ %xxxxx  0 lshift TIM2_DCR        \ TIM2_DBA	Bit Offset:0	Bit Width:5

\ TIM2_DMAR read-write
$0000 CONSTANT RESET_TIM2_DMAR 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM2_DMAR        \ TIM2_DMAB	Bit Offset:0	Bit Width:16

  
\ TIM3
  
\ TIM4
  
\ TIM5
  
\ TIM9
\ TIM9_CR1 read-write
$0000 CONSTANT RESET_TIM9_CR1 
\ %xx  8 lshift TIM9_CR1        \ TIM9_CKD	Bit Offset:8	Bit Width:2
\ %1  7 lshift TIM9_CR1        \ TIM9_ARPE	Bit Offset:7	Bit Width:1
\ %1  3 lshift TIM9_CR1        \ TIM9_OPM	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM9_CR1        \ TIM9_URS	Bit Offset:2	Bit Width:1
\ %1  1 lshift TIM9_CR1        \ TIM9_UDIS	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM9_CR1        \ TIM9_CEN	Bit Offset:0	Bit Width:1

\ TIM9_CR2 read-write
$0000 CONSTANT RESET_TIM9_CR2 
\ %xxx  4 lshift TIM9_CR2        \ TIM9_MMS	Bit Offset:4	Bit Width:3

\ TIM9_SMCR read-write
$0000 CONSTANT RESET_TIM9_SMCR 
\ %1  7 lshift TIM9_SMCR        \ TIM9_MSM	Bit Offset:7	Bit Width:1
\ %xxx  4 lshift TIM9_SMCR        \ TIM9_TS	Bit Offset:4	Bit Width:3
\ %xxx  0 lshift TIM9_SMCR        \ TIM9_SMS	Bit Offset:0	Bit Width:3

\ TIM9_DIER read-write
$0000 CONSTANT RESET_TIM9_DIER 
\ %1  6 lshift TIM9_DIER        \ TIM9_TIE	Bit Offset:6	Bit Width:1
\ %1  2 lshift TIM9_DIER        \ TIM9_CC2IE	Bit Offset:2	Bit Width:1
\ %1  1 lshift TIM9_DIER        \ TIM9_CC1IE	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM9_DIER        \ TIM9_UIE	Bit Offset:0	Bit Width:1

\ TIM9_SR read-write
$0000 CONSTANT RESET_TIM9_SR 
\ %1  10 lshift TIM9_SR        \ TIM9_CC2OF	Bit Offset:10	Bit Width:1
\ %1  9 lshift TIM9_SR        \ TIM9_CC1OF	Bit Offset:9	Bit Width:1
\ %1  6 lshift TIM9_SR        \ TIM9_TIF	Bit Offset:6	Bit Width:1
\ %1  2 lshift TIM9_SR        \ TIM9_CC2IF	Bit Offset:2	Bit Width:1
\ %1  1 lshift TIM9_SR        \ TIM9_CC1IF	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM9_SR        \ TIM9_UIF	Bit Offset:0	Bit Width:1

\ TIM9_EGR write-only
$0000 CONSTANT RESET_TIM9_EGR 
\ %1  6 lshift TIM9_EGR        \ TIM9_TG	Bit Offset:6	Bit Width:1
\ %1  2 lshift TIM9_EGR        \ TIM9_CC2G	Bit Offset:2	Bit Width:1
\ %1  1 lshift TIM9_EGR        \ TIM9_CC1G	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM9_EGR        \ TIM9_UG	Bit Offset:0	Bit Width:1

\ TIM9_CCMR1_Output read-write
$00000000 CONSTANT RESET_TIM9_CCMR1_Output 
\ %xxx  12 lshift TIM9_CCMR1_Output        \ TIM9_OC2M	Bit Offset:12	Bit Width:3
\ %1  11 lshift TIM9_CCMR1_Output        \ TIM9_OC2PE	Bit Offset:11	Bit Width:1
\ %1  10 lshift TIM9_CCMR1_Output        \ TIM9_OC2FE	Bit Offset:10	Bit Width:1
\ %xx  8 lshift TIM9_CCMR1_Output        \ TIM9_CC2S	Bit Offset:8	Bit Width:2
\ %xxx  4 lshift TIM9_CCMR1_Output        \ TIM9_OC1M	Bit Offset:4	Bit Width:3
\ %1  3 lshift TIM9_CCMR1_Output        \ TIM9_OC1PE	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM9_CCMR1_Output        \ TIM9_OC1FE	Bit Offset:2	Bit Width:1
\ %xx  0 lshift TIM9_CCMR1_Output        \ TIM9_CC1S	Bit Offset:0	Bit Width:2

\ TIM9_CCMR1_Input read-write
$00000000 CONSTANT RESET_TIM9_CCMR1_Input 
\ %xxxx  12 lshift TIM9_CCMR1_Input        \ TIM9_IC2F	Bit Offset:12	Bit Width:4
\ %xx  10 lshift TIM9_CCMR1_Input        \ TIM9_IC2PSC	Bit Offset:10	Bit Width:2
\ %xx  8 lshift TIM9_CCMR1_Input        \ TIM9_CC2S	Bit Offset:8	Bit Width:2
\ %xxxx  4 lshift TIM9_CCMR1_Input        \ TIM9_IC1F	Bit Offset:4	Bit Width:4
\ %xx  2 lshift TIM9_CCMR1_Input        \ TIM9_IC1PSC	Bit Offset:2	Bit Width:2
\ %xx  0 lshift TIM9_CCMR1_Input        \ TIM9_CC1S	Bit Offset:0	Bit Width:2

\ TIM9_CCER read-write
$0000 CONSTANT RESET_TIM9_CCER 
\ %1  7 lshift TIM9_CCER        \ TIM9_CC2NP	Bit Offset:7	Bit Width:1
\ %1  5 lshift TIM9_CCER        \ TIM9_CC2P	Bit Offset:5	Bit Width:1
\ %1  4 lshift TIM9_CCER        \ TIM9_CC2E	Bit Offset:4	Bit Width:1
\ %1  3 lshift TIM9_CCER        \ TIM9_CC1NP	Bit Offset:3	Bit Width:1
\ %1  1 lshift TIM9_CCER        \ TIM9_CC1P	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM9_CCER        \ TIM9_CC1E	Bit Offset:0	Bit Width:1

\ TIM9_CNT read-write
$00000000 CONSTANT RESET_TIM9_CNT 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM9_CNT        \ TIM9_CNT	Bit Offset:0	Bit Width:16

\ TIM9_PSC read-write
$0000 CONSTANT RESET_TIM9_PSC 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM9_PSC        \ TIM9_PSC	Bit Offset:0	Bit Width:16

\ TIM9_ARR read-write
$00000000 CONSTANT RESET_TIM9_ARR 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM9_ARR        \ TIM9_ARR	Bit Offset:0	Bit Width:16

\ TIM9_CCR1 read-write
$00000000 CONSTANT RESET_TIM9_CCR1 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM9_CCR1        \ TIM9_CCR1	Bit Offset:0	Bit Width:16

\ TIM9_CCR2 read-write
$00000000 CONSTANT RESET_TIM9_CCR2 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM9_CCR2        \ TIM9_CCR2	Bit Offset:0	Bit Width:16

  
\ TIM12
  
\ TIM10
\ TIM10_CR1 read-write
$0000 CONSTANT RESET_TIM10_CR1 
\ %xx  8 lshift TIM10_CR1        \ TIM10_CKD	Bit Offset:8	Bit Width:2
\ %1  7 lshift TIM10_CR1        \ TIM10_ARPE	Bit Offset:7	Bit Width:1
\ %1  2 lshift TIM10_CR1        \ TIM10_URS	Bit Offset:2	Bit Width:1
\ %1  1 lshift TIM10_CR1        \ TIM10_UDIS	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM10_CR1        \ TIM10_CEN	Bit Offset:0	Bit Width:1

\ TIM10_CR2 read-write
$0000 CONSTANT RESET_TIM10_CR2 
\ %xxx  4 lshift TIM10_CR2        \ TIM10_MMS	Bit Offset:4	Bit Width:3

\ TIM10_DIER read-write
$0000 CONSTANT RESET_TIM10_DIER 
\ %1  1 lshift TIM10_DIER        \ TIM10_CC1IE	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM10_DIER        \ TIM10_UIE	Bit Offset:0	Bit Width:1

\ TIM10_SR read-write
$0000 CONSTANT RESET_TIM10_SR 
\ %1  9 lshift TIM10_SR        \ TIM10_CC1OF	Bit Offset:9	Bit Width:1
\ %1  1 lshift TIM10_SR        \ TIM10_CC1IF	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM10_SR        \ TIM10_UIF	Bit Offset:0	Bit Width:1

\ TIM10_EGR write-only
$0000 CONSTANT RESET_TIM10_EGR 
\ %1  1 lshift TIM10_EGR        \ TIM10_CC1G	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM10_EGR        \ TIM10_UG	Bit Offset:0	Bit Width:1

\ TIM10_CCMR1_Output read-write
$00000000 CONSTANT RESET_TIM10_CCMR1_Output 
\ %xxx  4 lshift TIM10_CCMR1_Output        \ TIM10_OC1M	Bit Offset:4	Bit Width:3
\ %1  3 lshift TIM10_CCMR1_Output        \ TIM10_OC1PE	Bit Offset:3	Bit Width:1
\ %xx  0 lshift TIM10_CCMR1_Output        \ TIM10_CC1S	Bit Offset:0	Bit Width:2

\ TIM10_CCMR1_Input read-write
$00000000 CONSTANT RESET_TIM10_CCMR1_Input 
\ %xxxx  4 lshift TIM10_CCMR1_Input        \ TIM10_IC1F	Bit Offset:4	Bit Width:4
\ %xx  2 lshift TIM10_CCMR1_Input        \ TIM10_IC1PSC	Bit Offset:2	Bit Width:2
\ %xx  0 lshift TIM10_CCMR1_Input        \ TIM10_CC1S	Bit Offset:0	Bit Width:2

\ TIM10_CCER read-write
$0000 CONSTANT RESET_TIM10_CCER 
\ %1  3 lshift TIM10_CCER        \ TIM10_CC1NP	Bit Offset:3	Bit Width:1
\ %1  1 lshift TIM10_CCER        \ TIM10_CC1P	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM10_CCER        \ TIM10_CC1E	Bit Offset:0	Bit Width:1

\ TIM10_CNT read-write
$00000000 CONSTANT RESET_TIM10_CNT 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM10_CNT        \ TIM10_CNT	Bit Offset:0	Bit Width:16

\ TIM10_PSC read-write
$0000 CONSTANT RESET_TIM10_PSC 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM10_PSC        \ TIM10_PSC	Bit Offset:0	Bit Width:16

\ TIM10_ARR read-write
$00000000 CONSTANT RESET_TIM10_ARR 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM10_ARR        \ TIM10_ARR	Bit Offset:0	Bit Width:16

\ TIM10_CCR1 read-write
$00000000 CONSTANT RESET_TIM10_CCR1 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM10_CCR1        \ TIM10_CCR1	Bit Offset:0	Bit Width:16

  
\ TIM11
  
\ TIM13
  
\ TIM14
  
\ TIM6
\ TIM6_CR1 read-write
$0000 CONSTANT RESET_TIM6_CR1 
\ %1  7 lshift TIM6_CR1        \ TIM6_ARPE	Bit Offset:7	Bit Width:1
\ %1  3 lshift TIM6_CR1        \ TIM6_OPM	Bit Offset:3	Bit Width:1
\ %1  2 lshift TIM6_CR1        \ TIM6_URS	Bit Offset:2	Bit Width:1
\ %1  1 lshift TIM6_CR1        \ TIM6_UDIS	Bit Offset:1	Bit Width:1
\ %1  0 lshift TIM6_CR1        \ TIM6_CEN	Bit Offset:0	Bit Width:1

\ TIM6_CR2 read-write
$0000 CONSTANT RESET_TIM6_CR2 
\ %xxx  4 lshift TIM6_CR2        \ TIM6_MMS	Bit Offset:4	Bit Width:3

\ TIM6_DIER read-write
$0000 CONSTANT RESET_TIM6_DIER 
\ %1  8 lshift TIM6_DIER        \ TIM6_UDE	Bit Offset:8	Bit Width:1
\ %1  0 lshift TIM6_DIER        \ TIM6_UIE	Bit Offset:0	Bit Width:1

\ TIM6_SR read-write
$0000 CONSTANT RESET_TIM6_SR 
\ %1  0 lshift TIM6_SR        \ TIM6_UIF	Bit Offset:0	Bit Width:1

\ TIM6_EGR write-only
$0000 CONSTANT RESET_TIM6_EGR 
\ %1  0 lshift TIM6_EGR        \ TIM6_UG	Bit Offset:0	Bit Width:1

\ TIM6_CNT read-write
$00000000 CONSTANT RESET_TIM6_CNT 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM6_CNT        \ TIM6_CNT	Bit Offset:0	Bit Width:16

\ TIM6_PSC read-write
$0000 CONSTANT RESET_TIM6_PSC 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM6_PSC        \ TIM6_PSC	Bit Offset:0	Bit Width:16

\ TIM6_ARR read-write
$00000000 CONSTANT RESET_TIM6_ARR 
\ %xxxxxxxxxxxxxxxx  0 lshift TIM6_ARR        \ TIM6_ARR	Bit Offset:0	Bit Width:16

  
\ TIM7
  
\ I2C1
\ I2C1_CR1 read-write
$0000 CONSTANT RESET_I2C1_CR1 
\ %1  15 lshift I2C1_CR1        \ I2C1_SWRST	Bit Offset:15	Bit Width:1
\ %1  13 lshift I2C1_CR1        \ I2C1_ALERT	Bit Offset:13	Bit Width:1
\ %1  12 lshift I2C1_CR1        \ I2C1_PEC	Bit Offset:12	Bit Width:1
\ %1  11 lshift I2C1_CR1        \ I2C1_POS	Bit Offset:11	Bit Width:1
\ %1  10 lshift I2C1_CR1        \ I2C1_ACK	Bit Offset:10	Bit Width:1
\ %1  9 lshift I2C1_CR1        \ I2C1_STOP	Bit Offset:9	Bit Width:1
\ %1  8 lshift I2C1_CR1        \ I2C1_START	Bit Offset:8	Bit Width:1
\ %1  7 lshift I2C1_CR1        \ I2C1_NOSTRETCH	Bit Offset:7	Bit Width:1
\ %1  6 lshift I2C1_CR1        \ I2C1_ENGC	Bit Offset:6	Bit Width:1
\ %1  5 lshift I2C1_CR1        \ I2C1_ENPEC	Bit Offset:5	Bit Width:1
\ %1  4 lshift I2C1_CR1        \ I2C1_ENARP	Bit Offset:4	Bit Width:1
\ %1  3 lshift I2C1_CR1        \ I2C1_SMBTYPE	Bit Offset:3	Bit Width:1
\ %1  1 lshift I2C1_CR1        \ I2C1_SMBUS	Bit Offset:1	Bit Width:1
\ %1  0 lshift I2C1_CR1        \ I2C1_PE	Bit Offset:0	Bit Width:1

\ I2C1_CR2 read-write
$0000 CONSTANT RESET_I2C1_CR2 
\ %1  12 lshift I2C1_CR2        \ I2C1_LAST	Bit Offset:12	Bit Width:1
\ %1  11 lshift I2C1_CR2        \ I2C1_DMAEN	Bit Offset:11	Bit Width:1
\ %1  10 lshift I2C1_CR2        \ I2C1_ITBUFEN	Bit Offset:10	Bit Width:1
\ %1  9 lshift I2C1_CR2        \ I2C1_ITEVTEN	Bit Offset:9	Bit Width:1
\ %1  8 lshift I2C1_CR2        \ I2C1_ITERREN	Bit Offset:8	Bit Width:1
\ %xxxxxx  0 lshift I2C1_CR2        \ I2C1_FREQ	Bit Offset:0	Bit Width:6

\ I2C1_OAR1 read-write
$0000 CONSTANT RESET_I2C1_OAR1 
\ %1  15 lshift I2C1_OAR1        \ I2C1_ADDMODE	Bit Offset:15	Bit Width:1
\ %xx  8 lshift I2C1_OAR1        \ I2C1_ADD10	Bit Offset:8	Bit Width:2
\ %xxxxxxx  1 lshift I2C1_OAR1        \ I2C1_ADD7	Bit Offset:1	Bit Width:7
\ %1  0 lshift I2C1_OAR1        \ I2C1_ADD0	Bit Offset:0	Bit Width:1

\ I2C1_OAR2 read-write
$0000 CONSTANT RESET_I2C1_OAR2 
\ %xxxxxxx  1 lshift I2C1_OAR2        \ I2C1_ADD2	Bit Offset:1	Bit Width:7
\ %1  0 lshift I2C1_OAR2        \ I2C1_ENDUAL	Bit Offset:0	Bit Width:1

\ I2C1_DR read-write
$0000 CONSTANT RESET_I2C1_DR 
\ %xxxxxxxx  0 lshift I2C1_DR        \ I2C1_DR	Bit Offset:0	Bit Width:8

\ I2C1_SR1 
$0000 CONSTANT RESET_I2C1_SR1 
\ %1  15 lshift I2C1_SR1        \ I2C1_SMBALERT	Bit Offset:15	Bit Width:1
\ %1  14 lshift I2C1_SR1        \ I2C1_TIMEOUT	Bit Offset:14	Bit Width:1
\ %1  12 lshift I2C1_SR1        \ I2C1_PECERR	Bit Offset:12	Bit Width:1
\ %1  11 lshift I2C1_SR1        \ I2C1_OVR	Bit Offset:11	Bit Width:1
\ %1  10 lshift I2C1_SR1        \ I2C1_AF	Bit Offset:10	Bit Width:1
\ %1  9 lshift I2C1_SR1        \ I2C1_ARLO	Bit Offset:9	Bit Width:1
\ %1  8 lshift I2C1_SR1        \ I2C1_BERR	Bit Offset:8	Bit Width:1
\ %1  7 lshift I2C1_SR1        \ I2C1_TxE	Bit Offset:7	Bit Width:1
\ %1  6 lshift I2C1_SR1        \ I2C1_RxNE	Bit Offset:6	Bit Width:1
\ %1  4 lshift I2C1_SR1        \ I2C1_STOPF	Bit Offset:4	Bit Width:1
\ %1  3 lshift I2C1_SR1        \ I2C1_ADD10	Bit Offset:3	Bit Width:1
\ %1  2 lshift I2C1_SR1        \ I2C1_BTF	Bit Offset:2	Bit Width:1
\ %1  1 lshift I2C1_SR1        \ I2C1_ADDR	Bit Offset:1	Bit Width:1
\ %1  0 lshift I2C1_SR1        \ I2C1_SB	Bit Offset:0	Bit Width:1

\ I2C1_SR2 read-only
$0000 CONSTANT RESET_I2C1_SR2 
\ %xxxxxxxx  8 lshift I2C1_SR2        \ I2C1_PEC	Bit Offset:8	Bit Width:8
\ %1  7 lshift I2C1_SR2        \ I2C1_DUALF	Bit Offset:7	Bit Width:1
\ %1  6 lshift I2C1_SR2        \ I2C1_SMBHOST	Bit Offset:6	Bit Width:1
\ %1  5 lshift I2C1_SR2        \ I2C1_SMBDEFAULT	Bit Offset:5	Bit Width:1
\ %1  4 lshift I2C1_SR2        \ I2C1_GENCALL	Bit Offset:4	Bit Width:1
\ %1  2 lshift I2C1_SR2        \ I2C1_TRA	Bit Offset:2	Bit Width:1
\ %1  1 lshift I2C1_SR2        \ I2C1_BUSY	Bit Offset:1	Bit Width:1
\ %1  0 lshift I2C1_SR2        \ I2C1_MSL	Bit Offset:0	Bit Width:1

\ I2C1_CCR read-write
$0000 CONSTANT RESET_I2C1_CCR 
\ %1  15 lshift I2C1_CCR        \ I2C1_F_S	Bit Offset:15	Bit Width:1
\ %1  14 lshift I2C1_CCR        \ I2C1_DUTY	Bit Offset:14	Bit Width:1
\ %xxxxxxxxxxxx  0 lshift I2C1_CCR        \ I2C1_CCR	Bit Offset:0	Bit Width:12

\ I2C1_TRISE read-write
$0002 CONSTANT RESET_I2C1_TRISE 
\ %xxxxxx  0 lshift I2C1_TRISE        \ I2C1_TRISE	Bit Offset:0	Bit Width:6

  
\ I2C2
  
\ SPI1
\ SPI1_CR1 read-write
$0000 CONSTANT RESET_SPI1_CR1 
\ %1  15 lshift SPI1_CR1        \ SPI1_BIDIMODE	Bit Offset:15	Bit Width:1
\ %1  14 lshift SPI1_CR1        \ SPI1_BIDIOE	Bit Offset:14	Bit Width:1
\ %1  13 lshift SPI1_CR1        \ SPI1_CRCEN	Bit Offset:13	Bit Width:1
\ %1  12 lshift SPI1_CR1        \ SPI1_CRCNEXT	Bit Offset:12	Bit Width:1
\ %1  11 lshift SPI1_CR1        \ SPI1_DFF	Bit Offset:11	Bit Width:1
\ %1  10 lshift SPI1_CR1        \ SPI1_RXONLY	Bit Offset:10	Bit Width:1
\ %1  9 lshift SPI1_CR1        \ SPI1_SSM	Bit Offset:9	Bit Width:1
\ %1  8 lshift SPI1_CR1        \ SPI1_SSI	Bit Offset:8	Bit Width:1
\ %1  7 lshift SPI1_CR1        \ SPI1_LSBFIRST	Bit Offset:7	Bit Width:1
\ %1  6 lshift SPI1_CR1        \ SPI1_SPE	Bit Offset:6	Bit Width:1
\ %xxx  3 lshift SPI1_CR1        \ SPI1_BR	Bit Offset:3	Bit Width:3
\ %1  2 lshift SPI1_CR1        \ SPI1_MSTR	Bit Offset:2	Bit Width:1
\ %1  1 lshift SPI1_CR1        \ SPI1_CPOL	Bit Offset:1	Bit Width:1
\ %1  0 lshift SPI1_CR1        \ SPI1_CPHA	Bit Offset:0	Bit Width:1

\ SPI1_CR2 read-write
$0000 CONSTANT RESET_SPI1_CR2 
\ %1  7 lshift SPI1_CR2        \ SPI1_TXEIE	Bit Offset:7	Bit Width:1
\ %1  6 lshift SPI1_CR2        \ SPI1_RXNEIE	Bit Offset:6	Bit Width:1
\ %1  5 lshift SPI1_CR2        \ SPI1_ERRIE	Bit Offset:5	Bit Width:1
\ %1  2 lshift SPI1_CR2        \ SPI1_SSOE	Bit Offset:2	Bit Width:1
\ %1  1 lshift SPI1_CR2        \ SPI1_TXDMAEN	Bit Offset:1	Bit Width:1
\ %1  0 lshift SPI1_CR2        \ SPI1_RXDMAEN	Bit Offset:0	Bit Width:1

\ SPI1_SR 
$0002 CONSTANT RESET_SPI1_SR 
\ %1  7 lshift SPI1_SR        \ SPI1_BSY	Bit Offset:7	Bit Width:1
\ %1  6 lshift SPI1_SR        \ SPI1_OVR	Bit Offset:6	Bit Width:1
\ %1  5 lshift SPI1_SR        \ SPI1_MODF	Bit Offset:5	Bit Width:1
\ %1  4 lshift SPI1_SR        \ SPI1_CRCERR	Bit Offset:4	Bit Width:1
\ %1  3 lshift SPI1_SR        \ SPI1_UDR	Bit Offset:3	Bit Width:1
\ %1  2 lshift SPI1_SR        \ SPI1_CHSIDE	Bit Offset:2	Bit Width:1
\ %1  1 lshift SPI1_SR        \ SPI1_TXE	Bit Offset:1	Bit Width:1
\ %1  0 lshift SPI1_SR        \ SPI1_RXNE	Bit Offset:0	Bit Width:1

\ SPI1_DR read-write
$0000 CONSTANT RESET_SPI1_DR 
\ %xxxxxxxxxxxxxxxx  0 lshift SPI1_DR        \ SPI1_DR	Bit Offset:0	Bit Width:16

\ SPI1_CRCPR read-write
$0007 CONSTANT RESET_SPI1_CRCPR 
\ %xxxxxxxxxxxxxxxx  0 lshift SPI1_CRCPR        \ SPI1_CRCPOLY	Bit Offset:0	Bit Width:16

\ SPI1_RXCRCR read-only
$0000 CONSTANT RESET_SPI1_RXCRCR 
\ %xxxxxxxxxxxxxxxx  0 lshift SPI1_RXCRCR        \ SPI1_RxCRC	Bit Offset:0	Bit Width:16

\ SPI1_TXCRCR read-only
$0000 CONSTANT RESET_SPI1_TXCRCR 
\ %xxxxxxxxxxxxxxxx  0 lshift SPI1_TXCRCR        \ SPI1_TxCRC	Bit Offset:0	Bit Width:16

\ SPI1_I2SCFGR read-write
$0000 CONSTANT RESET_SPI1_I2SCFGR 
\ %1  11 lshift SPI1_I2SCFGR        \ SPI1_I2SMOD	Bit Offset:11	Bit Width:1
\ %1  10 lshift SPI1_I2SCFGR        \ SPI1_I2SE	Bit Offset:10	Bit Width:1
\ %xx  8 lshift SPI1_I2SCFGR        \ SPI1_I2SCFG	Bit Offset:8	Bit Width:2
\ %1  7 lshift SPI1_I2SCFGR        \ SPI1_PCMSYNC	Bit Offset:7	Bit Width:1
\ %xx  4 lshift SPI1_I2SCFGR        \ SPI1_I2SSTD	Bit Offset:4	Bit Width:2
\ %1  3 lshift SPI1_I2SCFGR        \ SPI1_CKPOL	Bit Offset:3	Bit Width:1
\ %xx  1 lshift SPI1_I2SCFGR        \ SPI1_DATLEN	Bit Offset:1	Bit Width:2
\ %1  0 lshift SPI1_I2SCFGR        \ SPI1_CHLEN	Bit Offset:0	Bit Width:1

\ SPI1_I2SPR read-write
00000010 CONSTANT RESET_SPI1_I2SPR 
\ %1  9 lshift SPI1_I2SPR        \ SPI1_MCKOE	Bit Offset:9	Bit Width:1
\ %1  8 lshift SPI1_I2SPR        \ SPI1_ODD	Bit Offset:8	Bit Width:1
\ %xxxxxxxx  0 lshift SPI1_I2SPR        \ SPI1_I2SDIV	Bit Offset:0	Bit Width:8

  
\ SPI2
  
\ SPI3
  
\ USART1
\ USART1_SR 
$00C0 CONSTANT RESET_USART1_SR 
\ %1  9 lshift USART1_SR        \ USART1_CTS	Bit Offset:9	Bit Width:1
\ %1  8 lshift USART1_SR        \ USART1_LBD	Bit Offset:8	Bit Width:1
\ %1  7 lshift USART1_SR        \ USART1_TXE	Bit Offset:7	Bit Width:1
\ %1  6 lshift USART1_SR        \ USART1_TC	Bit Offset:6	Bit Width:1
\ %1  5 lshift USART1_SR        \ USART1_RXNE	Bit Offset:5	Bit Width:1
\ %1  4 lshift USART1_SR        \ USART1_IDLE	Bit Offset:4	Bit Width:1
\ %1  3 lshift USART1_SR        \ USART1_ORE	Bit Offset:3	Bit Width:1
\ %1  2 lshift USART1_SR        \ USART1_NE	Bit Offset:2	Bit Width:1
\ %1  1 lshift USART1_SR        \ USART1_FE	Bit Offset:1	Bit Width:1
\ %1  0 lshift USART1_SR        \ USART1_PE	Bit Offset:0	Bit Width:1

\ USART1_DR read-write
$00000000 CONSTANT RESET_USART1_DR 
\ %xxxxxxxxx  0 lshift USART1_DR        \ USART1_DR	Bit Offset:0	Bit Width:9

\ USART1_BRR read-write
$0000 CONSTANT RESET_USART1_BRR 
\ %xxxxxxxxxxxx  4 lshift USART1_BRR        \ USART1_DIV_Mantissa	Bit Offset:4	Bit Width:12
\ %xxxx  0 lshift USART1_BRR        \ USART1_DIV_Fraction	Bit Offset:0	Bit Width:4

\ USART1_CR1 read-write
$0000 CONSTANT RESET_USART1_CR1 
\ %1  13 lshift USART1_CR1        \ USART1_UE	Bit Offset:13	Bit Width:1
\ %1  12 lshift USART1_CR1        \ USART1_M	Bit Offset:12	Bit Width:1
\ %1  11 lshift USART1_CR1        \ USART1_WAKE	Bit Offset:11	Bit Width:1
\ %1  10 lshift USART1_CR1        \ USART1_PCE	Bit Offset:10	Bit Width:1
\ %1  9 lshift USART1_CR1        \ USART1_PS	Bit Offset:9	Bit Width:1
\ %1  8 lshift USART1_CR1        \ USART1_PEIE	Bit Offset:8	Bit Width:1
\ %1  7 lshift USART1_CR1        \ USART1_TXEIE	Bit Offset:7	Bit Width:1
\ %1  6 lshift USART1_CR1        \ USART1_TCIE	Bit Offset:6	Bit Width:1
\ %1  5 lshift USART1_CR1        \ USART1_RXNEIE	Bit Offset:5	Bit Width:1
\ %1  4 lshift USART1_CR1        \ USART1_IDLEIE	Bit Offset:4	Bit Width:1
\ %1  3 lshift USART1_CR1        \ USART1_TE	Bit Offset:3	Bit Width:1
\ %1  2 lshift USART1_CR1        \ USART1_RE	Bit Offset:2	Bit Width:1
\ %1  1 lshift USART1_CR1        \ USART1_RWU	Bit Offset:1	Bit Width:1
\ %1  0 lshift USART1_CR1        \ USART1_SBK	Bit Offset:0	Bit Width:1

\ USART1_CR2 read-write
$0000 CONSTANT RESET_USART1_CR2 
\ %1  14 lshift USART1_CR2        \ USART1_LINEN	Bit Offset:14	Bit Width:1
\ %xx  12 lshift USART1_CR2        \ USART1_STOP	Bit Offset:12	Bit Width:2
\ %1  11 lshift USART1_CR2        \ USART1_CLKEN	Bit Offset:11	Bit Width:1
\ %1  10 lshift USART1_CR2        \ USART1_CPOL	Bit Offset:10	Bit Width:1
\ %1  9 lshift USART1_CR2        \ USART1_CPHA	Bit Offset:9	Bit Width:1
\ %1  8 lshift USART1_CR2        \ USART1_LBCL	Bit Offset:8	Bit Width:1
\ %1  6 lshift USART1_CR2        \ USART1_LBDIE	Bit Offset:6	Bit Width:1
\ %1  5 lshift USART1_CR2        \ USART1_LBDL	Bit Offset:5	Bit Width:1
\ %xxxx  0 lshift USART1_CR2        \ USART1_ADD	Bit Offset:0	Bit Width:4

\ USART1_CR3 read-write
$0000 CONSTANT RESET_USART1_CR3 
\ %1  10 lshift USART1_CR3        \ USART1_CTSIE	Bit Offset:10	Bit Width:1
\ %1  9 lshift USART1_CR3        \ USART1_CTSE	Bit Offset:9	Bit Width:1
\ %1  8 lshift USART1_CR3        \ USART1_RTSE	Bit Offset:8	Bit Width:1
\ %1  7 lshift USART1_CR3        \ USART1_DMAT	Bit Offset:7	Bit Width:1
\ %1  6 lshift USART1_CR3        \ USART1_DMAR	Bit Offset:6	Bit Width:1
\ %1  5 lshift USART1_CR3        \ USART1_SCEN	Bit Offset:5	Bit Width:1
\ %1  4 lshift USART1_CR3        \ USART1_NACK	Bit Offset:4	Bit Width:1
\ %1  3 lshift USART1_CR3        \ USART1_HDSEL	Bit Offset:3	Bit Width:1
\ %1  2 lshift USART1_CR3        \ USART1_IRLP	Bit Offset:2	Bit Width:1
\ %1  1 lshift USART1_CR3        \ USART1_IREN	Bit Offset:1	Bit Width:1
\ %1  0 lshift USART1_CR3        \ USART1_EIE	Bit Offset:0	Bit Width:1

\ USART1_GTPR read-write
$0000 CONSTANT RESET_USART1_GTPR 
\ %xxxxxxxx  8 lshift USART1_GTPR        \ USART1_GT	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift USART1_GTPR        \ USART1_PSC	Bit Offset:0	Bit Width:8

  
\ USART2
  
\ USART3
  
\ ADC1
\ ADC1_SR read-write
$00000000 CONSTANT RESET_ADC1_SR 
\ %1  4 lshift ADC1_SR        \ ADC1_STRT	Bit Offset:4	Bit Width:1
\ %1  3 lshift ADC1_SR        \ ADC1_JSTRT	Bit Offset:3	Bit Width:1
\ %1  2 lshift ADC1_SR        \ ADC1_JEOC	Bit Offset:2	Bit Width:1
\ %1  1 lshift ADC1_SR        \ ADC1_EOC	Bit Offset:1	Bit Width:1
\ %1  0 lshift ADC1_SR        \ ADC1_AWD	Bit Offset:0	Bit Width:1

\ ADC1_CR1 read-write
$00000000 CONSTANT RESET_ADC1_CR1 
\ %1  23 lshift ADC1_CR1        \ ADC1_AWDEN	Bit Offset:23	Bit Width:1
\ %1  22 lshift ADC1_CR1        \ ADC1_JAWDEN	Bit Offset:22	Bit Width:1
\ %xxxx  16 lshift ADC1_CR1        \ ADC1_DUALMOD	Bit Offset:16	Bit Width:4
\ %xxx  13 lshift ADC1_CR1        \ ADC1_DISCNUM	Bit Offset:13	Bit Width:3
\ %1  12 lshift ADC1_CR1        \ ADC1_JDISCEN	Bit Offset:12	Bit Width:1
\ %1  11 lshift ADC1_CR1        \ ADC1_DISCEN	Bit Offset:11	Bit Width:1
\ %1  10 lshift ADC1_CR1        \ ADC1_JAUTO	Bit Offset:10	Bit Width:1
\ %1  9 lshift ADC1_CR1        \ ADC1_AWDSGL	Bit Offset:9	Bit Width:1
\ %1  8 lshift ADC1_CR1        \ ADC1_SCAN	Bit Offset:8	Bit Width:1
\ %1  7 lshift ADC1_CR1        \ ADC1_JEOCIE	Bit Offset:7	Bit Width:1
\ %1  6 lshift ADC1_CR1        \ ADC1_AWDIE	Bit Offset:6	Bit Width:1
\ %1  5 lshift ADC1_CR1        \ ADC1_EOCIE	Bit Offset:5	Bit Width:1
\ %xxxxx  0 lshift ADC1_CR1        \ ADC1_AWDCH	Bit Offset:0	Bit Width:5

\ ADC1_CR2 read-write
$00000000 CONSTANT RESET_ADC1_CR2 
\ %1  23 lshift ADC1_CR2        \ ADC1_TSVREFE	Bit Offset:23	Bit Width:1
\ %1  22 lshift ADC1_CR2        \ ADC1_SWSTART	Bit Offset:22	Bit Width:1
\ %1  21 lshift ADC1_CR2        \ ADC1_JSWSTART	Bit Offset:21	Bit Width:1
\ %1  20 lshift ADC1_CR2        \ ADC1_EXTTRIG	Bit Offset:20	Bit Width:1
\ %xxx  17 lshift ADC1_CR2        \ ADC1_EXTSEL	Bit Offset:17	Bit Width:3
\ %1  15 lshift ADC1_CR2        \ ADC1_JEXTTRIG	Bit Offset:15	Bit Width:1
\ %xxx  12 lshift ADC1_CR2        \ ADC1_JEXTSEL	Bit Offset:12	Bit Width:3
\ %1  11 lshift ADC1_CR2        \ ADC1_ALIGN	Bit Offset:11	Bit Width:1
\ %1  8 lshift ADC1_CR2        \ ADC1_DMA	Bit Offset:8	Bit Width:1
\ %1  3 lshift ADC1_CR2        \ ADC1_RSTCAL	Bit Offset:3	Bit Width:1
\ %1  2 lshift ADC1_CR2        \ ADC1_CAL	Bit Offset:2	Bit Width:1
\ %1  1 lshift ADC1_CR2        \ ADC1_CONT	Bit Offset:1	Bit Width:1
\ %1  0 lshift ADC1_CR2        \ ADC1_ADON	Bit Offset:0	Bit Width:1

\ ADC1_SMPR1 read-write
$00000000 CONSTANT RESET_ADC1_SMPR1 
\ %xxx  0 lshift ADC1_SMPR1        \ ADC1_SMP10	Bit Offset:0	Bit Width:3
\ %xxx  3 lshift ADC1_SMPR1        \ ADC1_SMP11	Bit Offset:3	Bit Width:3
\ %xxx  6 lshift ADC1_SMPR1        \ ADC1_SMP12	Bit Offset:6	Bit Width:3
\ %xxx  9 lshift ADC1_SMPR1        \ ADC1_SMP13	Bit Offset:9	Bit Width:3
\ %xxx  12 lshift ADC1_SMPR1        \ ADC1_SMP14	Bit Offset:12	Bit Width:3
\ %xxx  15 lshift ADC1_SMPR1        \ ADC1_SMP15	Bit Offset:15	Bit Width:3
\ %xxx  18 lshift ADC1_SMPR1        \ ADC1_SMP16	Bit Offset:18	Bit Width:3
\ %xxx  21 lshift ADC1_SMPR1        \ ADC1_SMP17	Bit Offset:21	Bit Width:3

\ ADC1_SMPR2 read-write
$00000000 CONSTANT RESET_ADC1_SMPR2 
\ %xxx  0 lshift ADC1_SMPR2        \ ADC1_SMP0	Bit Offset:0	Bit Width:3
\ %xxx  3 lshift ADC1_SMPR2        \ ADC1_SMP1	Bit Offset:3	Bit Width:3
\ %xxx  6 lshift ADC1_SMPR2        \ ADC1_SMP2	Bit Offset:6	Bit Width:3
\ %xxx  9 lshift ADC1_SMPR2        \ ADC1_SMP3	Bit Offset:9	Bit Width:3
\ %xxx  12 lshift ADC1_SMPR2        \ ADC1_SMP4	Bit Offset:12	Bit Width:3
\ %xxx  15 lshift ADC1_SMPR2        \ ADC1_SMP5	Bit Offset:15	Bit Width:3
\ %xxx  18 lshift ADC1_SMPR2        \ ADC1_SMP6	Bit Offset:18	Bit Width:3
\ %xxx  21 lshift ADC1_SMPR2        \ ADC1_SMP7	Bit Offset:21	Bit Width:3
\ %xxx  24 lshift ADC1_SMPR2        \ ADC1_SMP8	Bit Offset:24	Bit Width:3
\ %xxx  27 lshift ADC1_SMPR2        \ ADC1_SMP9	Bit Offset:27	Bit Width:3

\ ADC1_JOFR1 read-write
$00000000 CONSTANT RESET_ADC1_JOFR1 
\ %xxxxxxxxxxxx  0 lshift ADC1_JOFR1        \ ADC1_JOFFSET1	Bit Offset:0	Bit Width:12

\ ADC1_JOFR2 read-write
$00000000 CONSTANT RESET_ADC1_JOFR2 
\ %xxxxxxxxxxxx  0 lshift ADC1_JOFR2        \ ADC1_JOFFSET2	Bit Offset:0	Bit Width:12

\ ADC1_JOFR3 read-write
$00000000 CONSTANT RESET_ADC1_JOFR3 
\ %xxxxxxxxxxxx  0 lshift ADC1_JOFR3        \ ADC1_JOFFSET3	Bit Offset:0	Bit Width:12

\ ADC1_JOFR4 read-write
$00000000 CONSTANT RESET_ADC1_JOFR4 
\ %xxxxxxxxxxxx  0 lshift ADC1_JOFR4        \ ADC1_JOFFSET4	Bit Offset:0	Bit Width:12

\ ADC1_HTR read-write
$00000FFF CONSTANT RESET_ADC1_HTR 
\ %xxxxxxxxxxxx  0 lshift ADC1_HTR        \ ADC1_HT	Bit Offset:0	Bit Width:12

\ ADC1_LTR read-write
$00000000 CONSTANT RESET_ADC1_LTR 
\ %xxxxxxxxxxxx  0 lshift ADC1_LTR        \ ADC1_LT	Bit Offset:0	Bit Width:12

\ ADC1_SQR1 read-write
$00000000 CONSTANT RESET_ADC1_SQR1 
\ %xxxx  20 lshift ADC1_SQR1        \ ADC1_L	Bit Offset:20	Bit Width:4
\ %xxxxx  15 lshift ADC1_SQR1        \ ADC1_SQ16	Bit Offset:15	Bit Width:5
\ %xxxxx  10 lshift ADC1_SQR1        \ ADC1_SQ15	Bit Offset:10	Bit Width:5
\ %xxxxx  5 lshift ADC1_SQR1        \ ADC1_SQ14	Bit Offset:5	Bit Width:5
\ %xxxxx  0 lshift ADC1_SQR1        \ ADC1_SQ13	Bit Offset:0	Bit Width:5

\ ADC1_SQR2 read-write
$00000000 CONSTANT RESET_ADC1_SQR2 
\ %xxxxx  25 lshift ADC1_SQR2        \ ADC1_SQ12	Bit Offset:25	Bit Width:5
\ %xxxxx  20 lshift ADC1_SQR2        \ ADC1_SQ11	Bit Offset:20	Bit Width:5
\ %xxxxx  15 lshift ADC1_SQR2        \ ADC1_SQ10	Bit Offset:15	Bit Width:5
\ %xxxxx  10 lshift ADC1_SQR2        \ ADC1_SQ9	Bit Offset:10	Bit Width:5
\ %xxxxx  5 lshift ADC1_SQR2        \ ADC1_SQ8	Bit Offset:5	Bit Width:5
\ %xxxxx  0 lshift ADC1_SQR2        \ ADC1_SQ7	Bit Offset:0	Bit Width:5

\ ADC1_SQR3 read-write
$00000000 CONSTANT RESET_ADC1_SQR3 
\ %xxxxx  25 lshift ADC1_SQR3        \ ADC1_SQ6	Bit Offset:25	Bit Width:5
\ %xxxxx  20 lshift ADC1_SQR3        \ ADC1_SQ5	Bit Offset:20	Bit Width:5
\ %xxxxx  15 lshift ADC1_SQR3        \ ADC1_SQ4	Bit Offset:15	Bit Width:5
\ %xxxxx  10 lshift ADC1_SQR3        \ ADC1_SQ3	Bit Offset:10	Bit Width:5
\ %xxxxx  5 lshift ADC1_SQR3        \ ADC1_SQ2	Bit Offset:5	Bit Width:5
\ %xxxxx  0 lshift ADC1_SQR3        \ ADC1_SQ1	Bit Offset:0	Bit Width:5

\ ADC1_JSQR read-write
$00000000 CONSTANT RESET_ADC1_JSQR 
\ %xx  20 lshift ADC1_JSQR        \ ADC1_JL	Bit Offset:20	Bit Width:2
\ %xxxxx  15 lshift ADC1_JSQR        \ ADC1_JSQ4	Bit Offset:15	Bit Width:5
\ %xxxxx  10 lshift ADC1_JSQR        \ ADC1_JSQ3	Bit Offset:10	Bit Width:5
\ %xxxxx  5 lshift ADC1_JSQR        \ ADC1_JSQ2	Bit Offset:5	Bit Width:5
\ %xxxxx  0 lshift ADC1_JSQR        \ ADC1_JSQ1	Bit Offset:0	Bit Width:5

\ ADC1_JDR1 read-only
$00000000 CONSTANT RESET_ADC1_JDR1 
\ %xxxxxxxxxxxxxxxx  0 lshift ADC1_JDR1        \ ADC1_JDATA	Bit Offset:0	Bit Width:16

\ ADC1_JDR2 read-only
$00000000 CONSTANT RESET_ADC1_JDR2 
\ %xxxxxxxxxxxxxxxx  0 lshift ADC1_JDR2        \ ADC1_JDATA	Bit Offset:0	Bit Width:16

\ ADC1_JDR3 read-only
$00000000 CONSTANT RESET_ADC1_JDR3 
\ %xxxxxxxxxxxxxxxx  0 lshift ADC1_JDR3        \ ADC1_JDATA	Bit Offset:0	Bit Width:16

\ ADC1_JDR4 read-only
$00000000 CONSTANT RESET_ADC1_JDR4 
\ %xxxxxxxxxxxxxxxx  0 lshift ADC1_JDR4        \ ADC1_JDATA	Bit Offset:0	Bit Width:16

\ ADC1_DR read-only
$00000000 CONSTANT RESET_ADC1_DR 
\ %xxxxxxxxxxxxxxxx  0 lshift ADC1_DR        \ ADC1_DATA	Bit Offset:0	Bit Width:16
\ %xxxxxxxxxxxxxxxx  16 lshift ADC1_DR        \ ADC1_ADC2DATA	Bit Offset:16	Bit Width:16

  
\ ADC2
\ ADC2_SR read-write
$00000000 CONSTANT RESET_ADC2_SR 
\ %1  4 lshift ADC2_SR        \ ADC2_STRT	Bit Offset:4	Bit Width:1
\ %1  3 lshift ADC2_SR        \ ADC2_JSTRT	Bit Offset:3	Bit Width:1
\ %1  2 lshift ADC2_SR        \ ADC2_JEOC	Bit Offset:2	Bit Width:1
\ %1  1 lshift ADC2_SR        \ ADC2_EOC	Bit Offset:1	Bit Width:1
\ %1  0 lshift ADC2_SR        \ ADC2_AWD	Bit Offset:0	Bit Width:1

\ ADC2_CR1 read-write
$00000000 CONSTANT RESET_ADC2_CR1 
\ %1  23 lshift ADC2_CR1        \ ADC2_AWDEN	Bit Offset:23	Bit Width:1
\ %1  22 lshift ADC2_CR1        \ ADC2_JAWDEN	Bit Offset:22	Bit Width:1
\ %xxx  13 lshift ADC2_CR1        \ ADC2_DISCNUM	Bit Offset:13	Bit Width:3
\ %1  12 lshift ADC2_CR1        \ ADC2_JDISCEN	Bit Offset:12	Bit Width:1
\ %1  11 lshift ADC2_CR1        \ ADC2_DISCEN	Bit Offset:11	Bit Width:1
\ %1  10 lshift ADC2_CR1        \ ADC2_JAUTO	Bit Offset:10	Bit Width:1
\ %1  9 lshift ADC2_CR1        \ ADC2_AWDSGL	Bit Offset:9	Bit Width:1
\ %1  8 lshift ADC2_CR1        \ ADC2_SCAN	Bit Offset:8	Bit Width:1
\ %1  7 lshift ADC2_CR1        \ ADC2_JEOCIE	Bit Offset:7	Bit Width:1
\ %1  6 lshift ADC2_CR1        \ ADC2_AWDIE	Bit Offset:6	Bit Width:1
\ %1  5 lshift ADC2_CR1        \ ADC2_EOCIE	Bit Offset:5	Bit Width:1
\ %xxxxx  0 lshift ADC2_CR1        \ ADC2_AWDCH	Bit Offset:0	Bit Width:5

\ ADC2_CR2 read-write
$00000000 CONSTANT RESET_ADC2_CR2 
\ %1  23 lshift ADC2_CR2        \ ADC2_TSVREFE	Bit Offset:23	Bit Width:1
\ %1  22 lshift ADC2_CR2        \ ADC2_SWSTART	Bit Offset:22	Bit Width:1
\ %1  21 lshift ADC2_CR2        \ ADC2_JSWSTART	Bit Offset:21	Bit Width:1
\ %1  20 lshift ADC2_CR2        \ ADC2_EXTTRIG	Bit Offset:20	Bit Width:1
\ %xxx  17 lshift ADC2_CR2        \ ADC2_EXTSEL	Bit Offset:17	Bit Width:3
\ %1  15 lshift ADC2_CR2        \ ADC2_JEXTTRIG	Bit Offset:15	Bit Width:1
\ %xxx  12 lshift ADC2_CR2        \ ADC2_JEXTSEL	Bit Offset:12	Bit Width:3
\ %1  11 lshift ADC2_CR2        \ ADC2_ALIGN	Bit Offset:11	Bit Width:1
\ %1  8 lshift ADC2_CR2        \ ADC2_DMA	Bit Offset:8	Bit Width:1
\ %1  3 lshift ADC2_CR2        \ ADC2_RSTCAL	Bit Offset:3	Bit Width:1
\ %1  2 lshift ADC2_CR2        \ ADC2_CAL	Bit Offset:2	Bit Width:1
\ %1  1 lshift ADC2_CR2        \ ADC2_CONT	Bit Offset:1	Bit Width:1
\ %1  0 lshift ADC2_CR2        \ ADC2_ADON	Bit Offset:0	Bit Width:1

\ ADC2_SMPR1 read-write
$00000000 CONSTANT RESET_ADC2_SMPR1 
\ %xxx  0 lshift ADC2_SMPR1        \ ADC2_SMP10	Bit Offset:0	Bit Width:3
\ %xxx  3 lshift ADC2_SMPR1        \ ADC2_SMP11	Bit Offset:3	Bit Width:3
\ %xxx  6 lshift ADC2_SMPR1        \ ADC2_SMP12	Bit Offset:6	Bit Width:3
\ %xxx  9 lshift ADC2_SMPR1        \ ADC2_SMP13	Bit Offset:9	Bit Width:3
\ %xxx  12 lshift ADC2_SMPR1        \ ADC2_SMP14	Bit Offset:12	Bit Width:3
\ %xxx  15 lshift ADC2_SMPR1        \ ADC2_SMP15	Bit Offset:15	Bit Width:3
\ %xxx  18 lshift ADC2_SMPR1        \ ADC2_SMP16	Bit Offset:18	Bit Width:3
\ %xxx  21 lshift ADC2_SMPR1        \ ADC2_SMP17	Bit Offset:21	Bit Width:3

\ ADC2_SMPR2 read-write
$00000000 CONSTANT RESET_ADC2_SMPR2 
\ %xxx  0 lshift ADC2_SMPR2        \ ADC2_SMP0	Bit Offset:0	Bit Width:3
\ %xxx  3 lshift ADC2_SMPR2        \ ADC2_SMP1	Bit Offset:3	Bit Width:3
\ %xxx  6 lshift ADC2_SMPR2        \ ADC2_SMP2	Bit Offset:6	Bit Width:3
\ %xxx  9 lshift ADC2_SMPR2        \ ADC2_SMP3	Bit Offset:9	Bit Width:3
\ %xxx  12 lshift ADC2_SMPR2        \ ADC2_SMP4	Bit Offset:12	Bit Width:3
\ %xxx  15 lshift ADC2_SMPR2        \ ADC2_SMP5	Bit Offset:15	Bit Width:3
\ %xxx  18 lshift ADC2_SMPR2        \ ADC2_SMP6	Bit Offset:18	Bit Width:3
\ %xxx  21 lshift ADC2_SMPR2        \ ADC2_SMP7	Bit Offset:21	Bit Width:3
\ %xxx  24 lshift ADC2_SMPR2        \ ADC2_SMP8	Bit Offset:24	Bit Width:3
\ %xxx  27 lshift ADC2_SMPR2        \ ADC2_SMP9	Bit Offset:27	Bit Width:3

\ ADC2_JOFR1 read-write
$00000000 CONSTANT RESET_ADC2_JOFR1 
\ %xxxxxxxxxxxx  0 lshift ADC2_JOFR1        \ ADC2_JOFFSET1	Bit Offset:0	Bit Width:12

\ ADC2_JOFR2 read-write
$00000000 CONSTANT RESET_ADC2_JOFR2 
\ %xxxxxxxxxxxx  0 lshift ADC2_JOFR2        \ ADC2_JOFFSET2	Bit Offset:0	Bit Width:12

\ ADC2_JOFR3 read-write
$00000000 CONSTANT RESET_ADC2_JOFR3 
\ %xxxxxxxxxxxx  0 lshift ADC2_JOFR3        \ ADC2_JOFFSET3	Bit Offset:0	Bit Width:12

\ ADC2_JOFR4 read-write
$00000000 CONSTANT RESET_ADC2_JOFR4 
\ %xxxxxxxxxxxx  0 lshift ADC2_JOFR4        \ ADC2_JOFFSET4	Bit Offset:0	Bit Width:12

\ ADC2_HTR read-write
$00000FFF CONSTANT RESET_ADC2_HTR 
\ %xxxxxxxxxxxx  0 lshift ADC2_HTR        \ ADC2_HT	Bit Offset:0	Bit Width:12

\ ADC2_LTR read-write
$00000000 CONSTANT RESET_ADC2_LTR 
\ %xxxxxxxxxxxx  0 lshift ADC2_LTR        \ ADC2_LT	Bit Offset:0	Bit Width:12

\ ADC2_SQR1 read-write
$00000000 CONSTANT RESET_ADC2_SQR1 
\ %xxxx  20 lshift ADC2_SQR1        \ ADC2_L	Bit Offset:20	Bit Width:4
\ %xxxxx  15 lshift ADC2_SQR1        \ ADC2_SQ16	Bit Offset:15	Bit Width:5
\ %xxxxx  10 lshift ADC2_SQR1        \ ADC2_SQ15	Bit Offset:10	Bit Width:5
\ %xxxxx  5 lshift ADC2_SQR1        \ ADC2_SQ14	Bit Offset:5	Bit Width:5
\ %xxxxx  0 lshift ADC2_SQR1        \ ADC2_SQ13	Bit Offset:0	Bit Width:5

\ ADC2_SQR2 read-write
$00000000 CONSTANT RESET_ADC2_SQR2 
\ %xxxxx  25 lshift ADC2_SQR2        \ ADC2_SQ12	Bit Offset:25	Bit Width:5
\ %xxxxx  20 lshift ADC2_SQR2        \ ADC2_SQ11	Bit Offset:20	Bit Width:5
\ %xxxxx  15 lshift ADC2_SQR2        \ ADC2_SQ10	Bit Offset:15	Bit Width:5
\ %xxxxx  10 lshift ADC2_SQR2        \ ADC2_SQ9	Bit Offset:10	Bit Width:5
\ %xxxxx  5 lshift ADC2_SQR2        \ ADC2_SQ8	Bit Offset:5	Bit Width:5
\ %xxxxx  0 lshift ADC2_SQR2        \ ADC2_SQ7	Bit Offset:0	Bit Width:5

\ ADC2_SQR3 read-write
$00000000 CONSTANT RESET_ADC2_SQR3 
\ %xxxxx  25 lshift ADC2_SQR3        \ ADC2_SQ6	Bit Offset:25	Bit Width:5
\ %xxxxx  20 lshift ADC2_SQR3        \ ADC2_SQ5	Bit Offset:20	Bit Width:5
\ %xxxxx  15 lshift ADC2_SQR3        \ ADC2_SQ4	Bit Offset:15	Bit Width:5
\ %xxxxx  10 lshift ADC2_SQR3        \ ADC2_SQ3	Bit Offset:10	Bit Width:5
\ %xxxxx  5 lshift ADC2_SQR3        \ ADC2_SQ2	Bit Offset:5	Bit Width:5
\ %xxxxx  0 lshift ADC2_SQR3        \ ADC2_SQ1	Bit Offset:0	Bit Width:5

\ ADC2_JSQR read-write
$00000000 CONSTANT RESET_ADC2_JSQR 
\ %xx  20 lshift ADC2_JSQR        \ ADC2_JL	Bit Offset:20	Bit Width:2
\ %xxxxx  15 lshift ADC2_JSQR        \ ADC2_JSQ4	Bit Offset:15	Bit Width:5
\ %xxxxx  10 lshift ADC2_JSQR        \ ADC2_JSQ3	Bit Offset:10	Bit Width:5
\ %xxxxx  5 lshift ADC2_JSQR        \ ADC2_JSQ2	Bit Offset:5	Bit Width:5
\ %xxxxx  0 lshift ADC2_JSQR        \ ADC2_JSQ1	Bit Offset:0	Bit Width:5

\ ADC2_JDR1 read-only
$00000000 CONSTANT RESET_ADC2_JDR1 
\ %xxxxxxxxxxxxxxxx  0 lshift ADC2_JDR1        \ ADC2_JDATA	Bit Offset:0	Bit Width:16

\ ADC2_JDR2 read-only
$00000000 CONSTANT RESET_ADC2_JDR2 
\ %xxxxxxxxxxxxxxxx  0 lshift ADC2_JDR2        \ ADC2_JDATA	Bit Offset:0	Bit Width:16

\ ADC2_JDR3 read-only
$00000000 CONSTANT RESET_ADC2_JDR3 
\ %xxxxxxxxxxxxxxxx  0 lshift ADC2_JDR3        \ ADC2_JDATA	Bit Offset:0	Bit Width:16

\ ADC2_JDR4 read-only
$00000000 CONSTANT RESET_ADC2_JDR4 
\ %xxxxxxxxxxxxxxxx  0 lshift ADC2_JDR4        \ ADC2_JDATA	Bit Offset:0	Bit Width:16

\ ADC2_DR read-only
$00000000 CONSTANT RESET_ADC2_DR 
\ %xxxxxxxxxxxxxxxx  0 lshift ADC2_DR        \ ADC2_DATA	Bit Offset:0	Bit Width:16

  
\ ADC3
  
\ CAN
\ CAN_CAN_MCR read-write
$00000000 CONSTANT RESET_CAN_CAN_MCR 
\ %1  16 lshift CAN_CAN_MCR        \ CAN_DBF	Bit Offset:16	Bit Width:1
\ %1  15 lshift CAN_CAN_MCR        \ CAN_RESET	Bit Offset:15	Bit Width:1
\ %1  7 lshift CAN_CAN_MCR        \ CAN_TTCM	Bit Offset:7	Bit Width:1
\ %1  6 lshift CAN_CAN_MCR        \ CAN_ABOM	Bit Offset:6	Bit Width:1
\ %1  5 lshift CAN_CAN_MCR        \ CAN_AWUM	Bit Offset:5	Bit Width:1
\ %1  4 lshift CAN_CAN_MCR        \ CAN_NART	Bit Offset:4	Bit Width:1
\ %1  3 lshift CAN_CAN_MCR        \ CAN_RFLM	Bit Offset:3	Bit Width:1
\ %1  2 lshift CAN_CAN_MCR        \ CAN_TXFP	Bit Offset:2	Bit Width:1
\ %1  1 lshift CAN_CAN_MCR        \ CAN_SLEEP	Bit Offset:1	Bit Width:1
\ %1  0 lshift CAN_CAN_MCR        \ CAN_INRQ	Bit Offset:0	Bit Width:1

\ CAN_CAN_MSR 
$00000000 CONSTANT RESET_CAN_CAN_MSR 
\ %1  11 lshift CAN_CAN_MSR        \ CAN_RX	Bit Offset:11	Bit Width:1
\ %1  10 lshift CAN_CAN_MSR        \ CAN_SAMP	Bit Offset:10	Bit Width:1
\ %1  9 lshift CAN_CAN_MSR        \ CAN_RXM	Bit Offset:9	Bit Width:1
\ %1  8 lshift CAN_CAN_MSR        \ CAN_TXM	Bit Offset:8	Bit Width:1
\ %1  4 lshift CAN_CAN_MSR        \ CAN_SLAKI	Bit Offset:4	Bit Width:1
\ %1  3 lshift CAN_CAN_MSR        \ CAN_WKUI	Bit Offset:3	Bit Width:1
\ %1  2 lshift CAN_CAN_MSR        \ CAN_ERRI	Bit Offset:2	Bit Width:1
\ %1  1 lshift CAN_CAN_MSR        \ CAN_SLAK	Bit Offset:1	Bit Width:1
\ %1  0 lshift CAN_CAN_MSR        \ CAN_INAK	Bit Offset:0	Bit Width:1

\ CAN_CAN_TSR 
$00000000 CONSTANT RESET_CAN_CAN_TSR 
\ %1  31 lshift CAN_CAN_TSR        \ CAN_LOW2	Bit Offset:31	Bit Width:1
\ %1  30 lshift CAN_CAN_TSR        \ CAN_LOW1	Bit Offset:30	Bit Width:1
\ %1  29 lshift CAN_CAN_TSR        \ CAN_LOW0	Bit Offset:29	Bit Width:1
\ %1  28 lshift CAN_CAN_TSR        \ CAN_TME2	Bit Offset:28	Bit Width:1
\ %1  27 lshift CAN_CAN_TSR        \ CAN_TME1	Bit Offset:27	Bit Width:1
\ %1  26 lshift CAN_CAN_TSR        \ CAN_TME0	Bit Offset:26	Bit Width:1
\ %xx  24 lshift CAN_CAN_TSR        \ CAN_CODE	Bit Offset:24	Bit Width:2
\ %1  23 lshift CAN_CAN_TSR        \ CAN_ABRQ2	Bit Offset:23	Bit Width:1
\ %1  19 lshift CAN_CAN_TSR        \ CAN_TERR2	Bit Offset:19	Bit Width:1
\ %1  18 lshift CAN_CAN_TSR        \ CAN_ALST2	Bit Offset:18	Bit Width:1
\ %1  17 lshift CAN_CAN_TSR        \ CAN_TXOK2	Bit Offset:17	Bit Width:1
\ %1  16 lshift CAN_CAN_TSR        \ CAN_RQCP2	Bit Offset:16	Bit Width:1
\ %1  15 lshift CAN_CAN_TSR        \ CAN_ABRQ1	Bit Offset:15	Bit Width:1
\ %1  11 lshift CAN_CAN_TSR        \ CAN_TERR1	Bit Offset:11	Bit Width:1
\ %1  10 lshift CAN_CAN_TSR        \ CAN_ALST1	Bit Offset:10	Bit Width:1
\ %1  9 lshift CAN_CAN_TSR        \ CAN_TXOK1	Bit Offset:9	Bit Width:1
\ %1  8 lshift CAN_CAN_TSR        \ CAN_RQCP1	Bit Offset:8	Bit Width:1
\ %1  7 lshift CAN_CAN_TSR        \ CAN_ABRQ0	Bit Offset:7	Bit Width:1
\ %1  3 lshift CAN_CAN_TSR        \ CAN_TERR0	Bit Offset:3	Bit Width:1
\ %1  2 lshift CAN_CAN_TSR        \ CAN_ALST0	Bit Offset:2	Bit Width:1
\ %1  1 lshift CAN_CAN_TSR        \ CAN_TXOK0	Bit Offset:1	Bit Width:1
\ %1  0 lshift CAN_CAN_TSR        \ CAN_RQCP0	Bit Offset:0	Bit Width:1

\ CAN_CAN_RF0R 
$00000000 CONSTANT RESET_CAN_CAN_RF0R 
\ %1  5 lshift CAN_CAN_RF0R        \ CAN_RFOM0	Bit Offset:5	Bit Width:1
\ %1  4 lshift CAN_CAN_RF0R        \ CAN_FOVR0	Bit Offset:4	Bit Width:1
\ %1  3 lshift CAN_CAN_RF0R        \ CAN_FULL0	Bit Offset:3	Bit Width:1
\ %xx  0 lshift CAN_CAN_RF0R        \ CAN_FMP0	Bit Offset:0	Bit Width:2

\ CAN_CAN_RF1R 
$00000000 CONSTANT RESET_CAN_CAN_RF1R 
\ %1  5 lshift CAN_CAN_RF1R        \ CAN_RFOM1	Bit Offset:5	Bit Width:1
\ %1  4 lshift CAN_CAN_RF1R        \ CAN_FOVR1	Bit Offset:4	Bit Width:1
\ %1  3 lshift CAN_CAN_RF1R        \ CAN_FULL1	Bit Offset:3	Bit Width:1
\ %xx  0 lshift CAN_CAN_RF1R        \ CAN_FMP1	Bit Offset:0	Bit Width:2

\ CAN_CAN_IER read-write
$00000000 CONSTANT RESET_CAN_CAN_IER 
\ %1  17 lshift CAN_CAN_IER        \ CAN_SLKIE	Bit Offset:17	Bit Width:1
\ %1  16 lshift CAN_CAN_IER        \ CAN_WKUIE	Bit Offset:16	Bit Width:1
\ %1  15 lshift CAN_CAN_IER        \ CAN_ERRIE	Bit Offset:15	Bit Width:1
\ %1  11 lshift CAN_CAN_IER        \ CAN_LECIE	Bit Offset:11	Bit Width:1
\ %1  10 lshift CAN_CAN_IER        \ CAN_BOFIE	Bit Offset:10	Bit Width:1
\ %1  9 lshift CAN_CAN_IER        \ CAN_EPVIE	Bit Offset:9	Bit Width:1
\ %1  8 lshift CAN_CAN_IER        \ CAN_EWGIE	Bit Offset:8	Bit Width:1
\ %1  6 lshift CAN_CAN_IER        \ CAN_FOVIE1	Bit Offset:6	Bit Width:1
\ %1  5 lshift CAN_CAN_IER        \ CAN_FFIE1	Bit Offset:5	Bit Width:1
\ %1  4 lshift CAN_CAN_IER        \ CAN_FMPIE1	Bit Offset:4	Bit Width:1
\ %1  3 lshift CAN_CAN_IER        \ CAN_FOVIE0	Bit Offset:3	Bit Width:1
\ %1  2 lshift CAN_CAN_IER        \ CAN_FFIE0	Bit Offset:2	Bit Width:1
\ %1  1 lshift CAN_CAN_IER        \ CAN_FMPIE0	Bit Offset:1	Bit Width:1
\ %1  0 lshift CAN_CAN_IER        \ CAN_TMEIE	Bit Offset:0	Bit Width:1

\ CAN_CAN_ESR 
$00000000 CONSTANT RESET_CAN_CAN_ESR 
\ %xxxxxxxx  24 lshift CAN_CAN_ESR        \ CAN_REC	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift CAN_CAN_ESR        \ CAN_TEC	Bit Offset:16	Bit Width:8
\ %xxx  4 lshift CAN_CAN_ESR        \ CAN_LEC	Bit Offset:4	Bit Width:3
\ %1  2 lshift CAN_CAN_ESR        \ CAN_BOFF	Bit Offset:2	Bit Width:1
\ %1  1 lshift CAN_CAN_ESR        \ CAN_EPVF	Bit Offset:1	Bit Width:1
\ %1  0 lshift CAN_CAN_ESR        \ CAN_EWGF	Bit Offset:0	Bit Width:1

\ CAN_CAN_BTR read-write
$00000000 CONSTANT RESET_CAN_CAN_BTR 
\ %1  31 lshift CAN_CAN_BTR        \ CAN_SILM	Bit Offset:31	Bit Width:1
\ %1  30 lshift CAN_CAN_BTR        \ CAN_LBKM	Bit Offset:30	Bit Width:1
\ %xx  24 lshift CAN_CAN_BTR        \ CAN_SJW	Bit Offset:24	Bit Width:2
\ %xxx  20 lshift CAN_CAN_BTR        \ CAN_TS2	Bit Offset:20	Bit Width:3
\ %xxxx  16 lshift CAN_CAN_BTR        \ CAN_TS1	Bit Offset:16	Bit Width:4
\ % 0 lshift CAN_CAN_BTR        \ CAN_BRP	Bit Offset:0	Bit Width:10

\ CAN_CAN_TI0R read-write
$00000000 CONSTANT RESET_CAN_CAN_TI0R 
\ % 21 lshift CAN_CAN_TI0R        \ CAN_STID	Bit Offset:21	Bit Width:11
\ % 3 lshift CAN_CAN_TI0R        \ CAN_EXID	Bit Offset:3	Bit Width:18
\ %1  2 lshift CAN_CAN_TI0R        \ CAN_IDE	Bit Offset:2	Bit Width:1
\ %1  1 lshift CAN_CAN_TI0R        \ CAN_RTR	Bit Offset:1	Bit Width:1
\ %1  0 lshift CAN_CAN_TI0R        \ CAN_TXRQ	Bit Offset:0	Bit Width:1

\ CAN_CAN_TDT0R read-write
$00000000 CONSTANT RESET_CAN_CAN_TDT0R 
\ %xxxxxxxxxxxxxxxx  16 lshift CAN_CAN_TDT0R        \ CAN_TIME	Bit Offset:16	Bit Width:16
\ %1  8 lshift CAN_CAN_TDT0R        \ CAN_TGT	Bit Offset:8	Bit Width:1
\ %xxxx  0 lshift CAN_CAN_TDT0R        \ CAN_DLC	Bit Offset:0	Bit Width:4

\ CAN_CAN_TDL0R read-write
$00000000 CONSTANT RESET_CAN_CAN_TDL0R 
\ %xxxxxxxx  24 lshift CAN_CAN_TDL0R        \ CAN_DATA3	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift CAN_CAN_TDL0R        \ CAN_DATA2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift CAN_CAN_TDL0R        \ CAN_DATA1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift CAN_CAN_TDL0R        \ CAN_DATA0	Bit Offset:0	Bit Width:8

\ CAN_CAN_TDH0R read-write
$00000000 CONSTANT RESET_CAN_CAN_TDH0R 
\ %xxxxxxxx  24 lshift CAN_CAN_TDH0R        \ CAN_DATA7	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift CAN_CAN_TDH0R        \ CAN_DATA6	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift CAN_CAN_TDH0R        \ CAN_DATA5	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift CAN_CAN_TDH0R        \ CAN_DATA4	Bit Offset:0	Bit Width:8

\ CAN_CAN_TI1R read-write
$00000000 CONSTANT RESET_CAN_CAN_TI1R 
\ % 21 lshift CAN_CAN_TI1R        \ CAN_STID	Bit Offset:21	Bit Width:11
\ % 3 lshift CAN_CAN_TI1R        \ CAN_EXID	Bit Offset:3	Bit Width:18
\ %1  2 lshift CAN_CAN_TI1R        \ CAN_IDE	Bit Offset:2	Bit Width:1
\ %1  1 lshift CAN_CAN_TI1R        \ CAN_RTR	Bit Offset:1	Bit Width:1
\ %1  0 lshift CAN_CAN_TI1R        \ CAN_TXRQ	Bit Offset:0	Bit Width:1

\ CAN_CAN_TDT1R read-write
$00000000 CONSTANT RESET_CAN_CAN_TDT1R 
\ %xxxxxxxxxxxxxxxx  16 lshift CAN_CAN_TDT1R        \ CAN_TIME	Bit Offset:16	Bit Width:16
\ %1  8 lshift CAN_CAN_TDT1R        \ CAN_TGT	Bit Offset:8	Bit Width:1
\ %xxxx  0 lshift CAN_CAN_TDT1R        \ CAN_DLC	Bit Offset:0	Bit Width:4

\ CAN_CAN_TDL1R read-write
$00000000 CONSTANT RESET_CAN_CAN_TDL1R 
\ %xxxxxxxx  24 lshift CAN_CAN_TDL1R        \ CAN_DATA3	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift CAN_CAN_TDL1R        \ CAN_DATA2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift CAN_CAN_TDL1R        \ CAN_DATA1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift CAN_CAN_TDL1R        \ CAN_DATA0	Bit Offset:0	Bit Width:8

\ CAN_CAN_TDH1R read-write
$00000000 CONSTANT RESET_CAN_CAN_TDH1R 
\ %xxxxxxxx  24 lshift CAN_CAN_TDH1R        \ CAN_DATA7	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift CAN_CAN_TDH1R        \ CAN_DATA6	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift CAN_CAN_TDH1R        \ CAN_DATA5	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift CAN_CAN_TDH1R        \ CAN_DATA4	Bit Offset:0	Bit Width:8

\ CAN_CAN_TI2R read-write
$00000000 CONSTANT RESET_CAN_CAN_TI2R 
\ % 21 lshift CAN_CAN_TI2R        \ CAN_STID	Bit Offset:21	Bit Width:11
\ % 3 lshift CAN_CAN_TI2R        \ CAN_EXID	Bit Offset:3	Bit Width:18
\ %1  2 lshift CAN_CAN_TI2R        \ CAN_IDE	Bit Offset:2	Bit Width:1
\ %1  1 lshift CAN_CAN_TI2R        \ CAN_RTR	Bit Offset:1	Bit Width:1
\ %1  0 lshift CAN_CAN_TI2R        \ CAN_TXRQ	Bit Offset:0	Bit Width:1

\ CAN_CAN_TDT2R read-write
$00000000 CONSTANT RESET_CAN_CAN_TDT2R 
\ %xxxxxxxxxxxxxxxx  16 lshift CAN_CAN_TDT2R        \ CAN_TIME	Bit Offset:16	Bit Width:16
\ %1  8 lshift CAN_CAN_TDT2R        \ CAN_TGT	Bit Offset:8	Bit Width:1
\ %xxxx  0 lshift CAN_CAN_TDT2R        \ CAN_DLC	Bit Offset:0	Bit Width:4

\ CAN_CAN_TDL2R read-write
$00000000 CONSTANT RESET_CAN_CAN_TDL2R 
\ %xxxxxxxx  24 lshift CAN_CAN_TDL2R        \ CAN_DATA3	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift CAN_CAN_TDL2R        \ CAN_DATA2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift CAN_CAN_TDL2R        \ CAN_DATA1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift CAN_CAN_TDL2R        \ CAN_DATA0	Bit Offset:0	Bit Width:8

\ CAN_CAN_TDH2R read-write
$00000000 CONSTANT RESET_CAN_CAN_TDH2R 
\ %xxxxxxxx  24 lshift CAN_CAN_TDH2R        \ CAN_DATA7	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift CAN_CAN_TDH2R        \ CAN_DATA6	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift CAN_CAN_TDH2R        \ CAN_DATA5	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift CAN_CAN_TDH2R        \ CAN_DATA4	Bit Offset:0	Bit Width:8

\ CAN_CAN_RI0R read-only
$00000000 CONSTANT RESET_CAN_CAN_RI0R 
\ % 21 lshift CAN_CAN_RI0R        \ CAN_STID	Bit Offset:21	Bit Width:11
\ % 3 lshift CAN_CAN_RI0R        \ CAN_EXID	Bit Offset:3	Bit Width:18
\ %1  2 lshift CAN_CAN_RI0R        \ CAN_IDE	Bit Offset:2	Bit Width:1
\ %1  1 lshift CAN_CAN_RI0R        \ CAN_RTR	Bit Offset:1	Bit Width:1

\ CAN_CAN_RDT0R read-only
$00000000 CONSTANT RESET_CAN_CAN_RDT0R 
\ %xxxxxxxxxxxxxxxx  16 lshift CAN_CAN_RDT0R        \ CAN_TIME	Bit Offset:16	Bit Width:16
\ %xxxxxxxx  8 lshift CAN_CAN_RDT0R        \ CAN_FMI	Bit Offset:8	Bit Width:8
\ %xxxx  0 lshift CAN_CAN_RDT0R        \ CAN_DLC	Bit Offset:0	Bit Width:4

\ CAN_CAN_RDL0R read-only
$00000000 CONSTANT RESET_CAN_CAN_RDL0R 
\ %xxxxxxxx  24 lshift CAN_CAN_RDL0R        \ CAN_DATA3	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift CAN_CAN_RDL0R        \ CAN_DATA2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift CAN_CAN_RDL0R        \ CAN_DATA1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift CAN_CAN_RDL0R        \ CAN_DATA0	Bit Offset:0	Bit Width:8

\ CAN_CAN_RDH0R read-only
$00000000 CONSTANT RESET_CAN_CAN_RDH0R 
\ %xxxxxxxx  24 lshift CAN_CAN_RDH0R        \ CAN_DATA7	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift CAN_CAN_RDH0R        \ CAN_DATA6	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift CAN_CAN_RDH0R        \ CAN_DATA5	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift CAN_CAN_RDH0R        \ CAN_DATA4	Bit Offset:0	Bit Width:8

\ CAN_CAN_RI1R read-only
$00000000 CONSTANT RESET_CAN_CAN_RI1R 
\ % 21 lshift CAN_CAN_RI1R        \ CAN_STID	Bit Offset:21	Bit Width:11
\ % 3 lshift CAN_CAN_RI1R        \ CAN_EXID	Bit Offset:3	Bit Width:18
\ %1  2 lshift CAN_CAN_RI1R        \ CAN_IDE	Bit Offset:2	Bit Width:1
\ %1  1 lshift CAN_CAN_RI1R        \ CAN_RTR	Bit Offset:1	Bit Width:1

\ CAN_CAN_RDT1R read-only
$00000000 CONSTANT RESET_CAN_CAN_RDT1R 
\ %xxxxxxxxxxxxxxxx  16 lshift CAN_CAN_RDT1R        \ CAN_TIME	Bit Offset:16	Bit Width:16
\ %xxxxxxxx  8 lshift CAN_CAN_RDT1R        \ CAN_FMI	Bit Offset:8	Bit Width:8
\ %xxxx  0 lshift CAN_CAN_RDT1R        \ CAN_DLC	Bit Offset:0	Bit Width:4

\ CAN_CAN_RDL1R read-only
$00000000 CONSTANT RESET_CAN_CAN_RDL1R 
\ %xxxxxxxx  24 lshift CAN_CAN_RDL1R        \ CAN_DATA3	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift CAN_CAN_RDL1R        \ CAN_DATA2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift CAN_CAN_RDL1R        \ CAN_DATA1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift CAN_CAN_RDL1R        \ CAN_DATA0	Bit Offset:0	Bit Width:8

\ CAN_CAN_RDH1R read-only
$00000000 CONSTANT RESET_CAN_CAN_RDH1R 
\ %xxxxxxxx  24 lshift CAN_CAN_RDH1R        \ CAN_DATA7	Bit Offset:24	Bit Width:8
\ %xxxxxxxx  16 lshift CAN_CAN_RDH1R        \ CAN_DATA6	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  8 lshift CAN_CAN_RDH1R        \ CAN_DATA5	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  0 lshift CAN_CAN_RDH1R        \ CAN_DATA4	Bit Offset:0	Bit Width:8

\ CAN_CAN_FMR read-write
$00000000 CONSTANT RESET_CAN_CAN_FMR 
\ %1  0 lshift CAN_CAN_FMR        \ CAN_FINIT	Bit Offset:0	Bit Width:1

\ CAN_CAN_FM1R read-write
$00000000 CONSTANT RESET_CAN_CAN_FM1R 
\ %1  0 lshift CAN_CAN_FM1R        \ CAN_FBM0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_CAN_FM1R        \ CAN_FBM1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_CAN_FM1R        \ CAN_FBM2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_CAN_FM1R        \ CAN_FBM3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_CAN_FM1R        \ CAN_FBM4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_CAN_FM1R        \ CAN_FBM5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_CAN_FM1R        \ CAN_FBM6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_CAN_FM1R        \ CAN_FBM7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_CAN_FM1R        \ CAN_FBM8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_CAN_FM1R        \ CAN_FBM9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_CAN_FM1R        \ CAN_FBM10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_CAN_FM1R        \ CAN_FBM11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_CAN_FM1R        \ CAN_FBM12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_CAN_FM1R        \ CAN_FBM13	Bit Offset:13	Bit Width:1

\ CAN_CAN_FS1R read-write
$00000000 CONSTANT RESET_CAN_CAN_FS1R 
\ %1  0 lshift CAN_CAN_FS1R        \ CAN_FSC0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_CAN_FS1R        \ CAN_FSC1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_CAN_FS1R        \ CAN_FSC2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_CAN_FS1R        \ CAN_FSC3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_CAN_FS1R        \ CAN_FSC4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_CAN_FS1R        \ CAN_FSC5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_CAN_FS1R        \ CAN_FSC6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_CAN_FS1R        \ CAN_FSC7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_CAN_FS1R        \ CAN_FSC8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_CAN_FS1R        \ CAN_FSC9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_CAN_FS1R        \ CAN_FSC10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_CAN_FS1R        \ CAN_FSC11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_CAN_FS1R        \ CAN_FSC12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_CAN_FS1R        \ CAN_FSC13	Bit Offset:13	Bit Width:1

\ CAN_CAN_FFA1R read-write
$00000000 CONSTANT RESET_CAN_CAN_FFA1R 
\ %1  0 lshift CAN_CAN_FFA1R        \ CAN_FFA0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_CAN_FFA1R        \ CAN_FFA1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_CAN_FFA1R        \ CAN_FFA2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_CAN_FFA1R        \ CAN_FFA3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_CAN_FFA1R        \ CAN_FFA4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_CAN_FFA1R        \ CAN_FFA5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_CAN_FFA1R        \ CAN_FFA6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_CAN_FFA1R        \ CAN_FFA7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_CAN_FFA1R        \ CAN_FFA8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_CAN_FFA1R        \ CAN_FFA9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_CAN_FFA1R        \ CAN_FFA10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_CAN_FFA1R        \ CAN_FFA11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_CAN_FFA1R        \ CAN_FFA12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_CAN_FFA1R        \ CAN_FFA13	Bit Offset:13	Bit Width:1

\ CAN_CAN_FA1R read-write
$00000000 CONSTANT RESET_CAN_CAN_FA1R 
\ %1  0 lshift CAN_CAN_FA1R        \ CAN_FACT0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_CAN_FA1R        \ CAN_FACT1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_CAN_FA1R        \ CAN_FACT2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_CAN_FA1R        \ CAN_FACT3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_CAN_FA1R        \ CAN_FACT4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_CAN_FA1R        \ CAN_FACT5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_CAN_FA1R        \ CAN_FACT6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_CAN_FA1R        \ CAN_FACT7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_CAN_FA1R        \ CAN_FACT8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_CAN_FA1R        \ CAN_FACT9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_CAN_FA1R        \ CAN_FACT10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_CAN_FA1R        \ CAN_FACT11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_CAN_FA1R        \ CAN_FACT12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_CAN_FA1R        \ CAN_FACT13	Bit Offset:13	Bit Width:1

\ CAN_F0R1 read-write
$00000000 CONSTANT RESET_CAN_F0R1 
\ %1  0 lshift CAN_F0R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F0R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F0R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F0R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F0R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F0R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F0R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F0R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F0R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F0R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F0R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F0R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F0R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F0R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F0R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F0R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F0R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F0R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F0R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F0R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F0R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F0R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F0R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F0R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F0R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F0R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F0R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F0R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F0R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F0R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F0R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F0R1        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F0R2 read-write
$00000000 CONSTANT RESET_CAN_F0R2 
\ %1  0 lshift CAN_F0R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F0R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F0R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F0R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F0R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F0R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F0R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F0R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F0R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F0R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F0R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F0R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F0R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F0R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F0R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F0R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F0R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F0R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F0R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F0R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F0R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F0R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F0R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F0R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F0R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F0R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F0R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F0R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F0R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F0R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F0R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F0R2        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F1R1 read-write
$00000000 CONSTANT RESET_CAN_F1R1 
\ %1  0 lshift CAN_F1R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F1R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F1R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F1R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F1R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F1R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F1R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F1R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F1R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F1R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F1R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F1R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F1R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F1R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F1R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F1R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F1R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F1R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F1R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F1R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F1R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F1R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F1R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F1R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F1R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F1R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F1R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F1R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F1R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F1R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F1R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F1R1        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F1R2 read-write
$00000000 CONSTANT RESET_CAN_F1R2 
\ %1  0 lshift CAN_F1R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F1R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F1R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F1R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F1R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F1R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F1R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F1R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F1R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F1R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F1R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F1R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F1R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F1R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F1R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F1R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F1R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F1R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F1R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F1R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F1R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F1R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F1R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F1R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F1R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F1R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F1R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F1R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F1R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F1R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F1R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F1R2        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F2R1 read-write
$00000000 CONSTANT RESET_CAN_F2R1 
\ %1  0 lshift CAN_F2R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F2R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F2R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F2R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F2R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F2R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F2R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F2R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F2R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F2R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F2R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F2R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F2R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F2R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F2R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F2R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F2R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F2R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F2R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F2R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F2R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F2R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F2R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F2R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F2R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F2R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F2R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F2R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F2R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F2R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F2R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F2R1        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F2R2 read-write
$00000000 CONSTANT RESET_CAN_F2R2 
\ %1  0 lshift CAN_F2R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F2R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F2R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F2R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F2R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F2R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F2R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F2R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F2R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F2R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F2R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F2R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F2R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F2R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F2R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F2R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F2R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F2R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F2R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F2R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F2R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F2R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F2R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F2R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F2R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F2R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F2R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F2R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F2R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F2R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F2R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F2R2        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F3R1 read-write
$00000000 CONSTANT RESET_CAN_F3R1 
\ %1  0 lshift CAN_F3R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F3R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F3R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F3R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F3R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F3R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F3R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F3R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F3R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F3R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F3R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F3R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F3R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F3R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F3R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F3R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F3R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F3R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F3R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F3R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F3R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F3R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F3R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F3R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F3R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F3R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F3R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F3R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F3R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F3R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F3R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F3R1        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F3R2 read-write
$00000000 CONSTANT RESET_CAN_F3R2 
\ %1  0 lshift CAN_F3R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F3R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F3R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F3R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F3R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F3R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F3R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F3R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F3R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F3R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F3R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F3R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F3R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F3R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F3R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F3R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F3R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F3R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F3R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F3R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F3R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F3R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F3R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F3R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F3R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F3R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F3R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F3R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F3R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F3R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F3R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F3R2        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F4R1 read-write
$00000000 CONSTANT RESET_CAN_F4R1 
\ %1  0 lshift CAN_F4R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F4R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F4R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F4R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F4R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F4R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F4R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F4R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F4R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F4R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F4R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F4R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F4R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F4R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F4R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F4R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F4R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F4R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F4R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F4R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F4R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F4R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F4R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F4R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F4R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F4R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F4R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F4R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F4R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F4R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F4R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F4R1        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F4R2 read-write
$00000000 CONSTANT RESET_CAN_F4R2 
\ %1  0 lshift CAN_F4R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F4R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F4R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F4R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F4R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F4R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F4R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F4R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F4R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F4R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F4R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F4R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F4R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F4R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F4R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F4R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F4R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F4R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F4R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F4R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F4R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F4R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F4R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F4R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F4R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F4R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F4R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F4R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F4R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F4R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F4R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F4R2        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F5R1 read-write
$00000000 CONSTANT RESET_CAN_F5R1 
\ %1  0 lshift CAN_F5R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F5R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F5R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F5R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F5R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F5R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F5R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F5R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F5R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F5R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F5R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F5R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F5R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F5R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F5R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F5R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F5R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F5R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F5R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F5R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F5R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F5R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F5R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F5R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F5R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F5R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F5R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F5R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F5R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F5R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F5R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F5R1        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F5R2 read-write
$00000000 CONSTANT RESET_CAN_F5R2 
\ %1  0 lshift CAN_F5R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F5R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F5R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F5R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F5R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F5R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F5R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F5R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F5R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F5R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F5R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F5R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F5R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F5R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F5R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F5R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F5R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F5R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F5R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F5R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F5R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F5R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F5R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F5R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F5R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F5R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F5R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F5R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F5R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F5R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F5R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F5R2        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F6R1 read-write
$00000000 CONSTANT RESET_CAN_F6R1 
\ %1  0 lshift CAN_F6R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F6R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F6R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F6R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F6R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F6R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F6R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F6R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F6R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F6R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F6R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F6R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F6R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F6R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F6R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F6R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F6R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F6R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F6R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F6R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F6R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F6R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F6R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F6R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F6R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F6R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F6R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F6R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F6R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F6R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F6R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F6R1        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F6R2 read-write
$00000000 CONSTANT RESET_CAN_F6R2 
\ %1  0 lshift CAN_F6R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F6R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F6R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F6R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F6R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F6R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F6R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F6R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F6R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F6R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F6R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F6R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F6R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F6R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F6R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F6R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F6R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F6R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F6R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F6R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F6R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F6R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F6R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F6R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F6R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F6R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F6R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F6R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F6R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F6R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F6R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F6R2        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F7R1 read-write
$00000000 CONSTANT RESET_CAN_F7R1 
\ %1  0 lshift CAN_F7R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F7R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F7R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F7R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F7R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F7R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F7R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F7R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F7R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F7R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F7R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F7R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F7R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F7R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F7R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F7R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F7R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F7R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F7R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F7R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F7R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F7R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F7R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F7R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F7R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F7R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F7R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F7R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F7R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F7R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F7R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F7R1        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F7R2 read-write
$00000000 CONSTANT RESET_CAN_F7R2 
\ %1  0 lshift CAN_F7R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F7R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F7R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F7R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F7R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F7R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F7R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F7R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F7R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F7R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F7R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F7R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F7R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F7R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F7R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F7R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F7R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F7R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F7R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F7R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F7R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F7R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F7R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F7R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F7R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F7R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F7R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F7R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F7R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F7R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F7R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F7R2        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F8R1 read-write
$00000000 CONSTANT RESET_CAN_F8R1 
\ %1  0 lshift CAN_F8R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F8R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F8R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F8R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F8R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F8R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F8R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F8R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F8R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F8R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F8R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F8R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F8R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F8R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F8R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F8R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F8R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F8R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F8R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F8R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F8R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F8R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F8R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F8R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F8R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F8R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F8R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F8R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F8R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F8R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F8R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F8R1        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F8R2 read-write
$00000000 CONSTANT RESET_CAN_F8R2 
\ %1  0 lshift CAN_F8R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F8R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F8R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F8R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F8R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F8R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F8R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F8R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F8R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F8R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F8R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F8R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F8R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F8R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F8R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F8R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F8R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F8R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F8R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F8R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F8R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F8R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F8R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F8R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F8R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F8R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F8R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F8R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F8R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F8R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F8R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F8R2        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F9R1 read-write
$00000000 CONSTANT RESET_CAN_F9R1 
\ %1  0 lshift CAN_F9R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F9R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F9R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F9R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F9R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F9R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F9R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F9R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F9R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F9R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F9R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F9R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F9R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F9R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F9R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F9R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F9R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F9R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F9R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F9R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F9R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F9R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F9R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F9R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F9R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F9R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F9R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F9R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F9R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F9R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F9R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F9R1        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F9R2 read-write
$00000000 CONSTANT RESET_CAN_F9R2 
\ %1  0 lshift CAN_F9R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F9R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F9R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F9R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F9R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F9R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F9R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F9R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F9R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F9R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F9R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F9R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F9R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F9R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F9R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F9R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F9R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F9R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F9R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F9R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F9R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F9R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F9R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F9R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F9R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F9R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F9R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F9R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F9R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F9R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F9R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F9R2        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F10R1 read-write
$00000000 CONSTANT RESET_CAN_F10R1 
\ %1  0 lshift CAN_F10R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F10R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F10R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F10R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F10R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F10R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F10R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F10R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F10R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F10R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F10R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F10R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F10R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F10R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F10R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F10R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F10R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F10R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F10R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F10R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F10R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F10R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F10R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F10R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F10R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F10R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F10R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F10R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F10R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F10R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F10R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F10R1        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F10R2 read-write
$00000000 CONSTANT RESET_CAN_F10R2 
\ %1  0 lshift CAN_F10R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F10R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F10R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F10R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F10R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F10R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F10R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F10R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F10R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F10R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F10R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F10R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F10R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F10R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F10R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F10R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F10R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F10R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F10R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F10R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F10R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F10R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F10R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F10R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F10R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F10R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F10R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F10R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F10R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F10R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F10R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F10R2        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F11R1 read-write
$00000000 CONSTANT RESET_CAN_F11R1 
\ %1  0 lshift CAN_F11R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F11R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F11R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F11R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F11R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F11R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F11R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F11R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F11R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F11R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F11R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F11R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F11R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F11R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F11R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F11R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F11R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F11R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F11R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F11R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F11R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F11R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F11R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F11R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F11R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F11R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F11R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F11R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F11R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F11R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F11R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F11R1        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F11R2 read-write
$00000000 CONSTANT RESET_CAN_F11R2 
\ %1  0 lshift CAN_F11R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F11R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F11R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F11R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F11R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F11R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F11R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F11R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F11R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F11R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F11R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F11R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F11R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F11R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F11R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F11R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F11R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F11R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F11R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F11R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F11R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F11R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F11R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F11R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F11R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F11R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F11R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F11R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F11R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F11R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F11R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F11R2        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F12R1 read-write
$00000000 CONSTANT RESET_CAN_F12R1 
\ %1  0 lshift CAN_F12R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F12R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F12R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F12R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F12R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F12R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F12R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F12R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F12R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F12R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F12R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F12R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F12R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F12R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F12R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F12R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F12R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F12R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F12R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F12R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F12R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F12R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F12R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F12R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F12R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F12R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F12R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F12R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F12R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F12R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F12R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F12R1        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F12R2 read-write
$00000000 CONSTANT RESET_CAN_F12R2 
\ %1  0 lshift CAN_F12R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F12R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F12R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F12R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F12R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F12R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F12R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F12R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F12R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F12R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F12R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F12R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F12R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F12R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F12R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F12R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F12R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F12R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F12R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F12R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F12R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F12R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F12R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F12R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F12R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F12R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F12R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F12R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F12R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F12R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F12R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F12R2        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F13R1 read-write
$00000000 CONSTANT RESET_CAN_F13R1 
\ %1  0 lshift CAN_F13R1        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F13R1        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F13R1        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F13R1        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F13R1        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F13R1        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F13R1        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F13R1        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F13R1        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F13R1        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F13R1        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F13R1        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F13R1        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F13R1        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F13R1        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F13R1        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F13R1        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F13R1        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F13R1        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F13R1        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F13R1        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F13R1        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F13R1        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F13R1        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F13R1        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F13R1        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F13R1        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F13R1        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F13R1        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F13R1        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F13R1        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F13R1        \ CAN_FB31	Bit Offset:31	Bit Width:1

\ CAN_F13R2 read-write
$00000000 CONSTANT RESET_CAN_F13R2 
\ %1  0 lshift CAN_F13R2        \ CAN_FB0	Bit Offset:0	Bit Width:1
\ %1  1 lshift CAN_F13R2        \ CAN_FB1	Bit Offset:1	Bit Width:1
\ %1  2 lshift CAN_F13R2        \ CAN_FB2	Bit Offset:2	Bit Width:1
\ %1  3 lshift CAN_F13R2        \ CAN_FB3	Bit Offset:3	Bit Width:1
\ %1  4 lshift CAN_F13R2        \ CAN_FB4	Bit Offset:4	Bit Width:1
\ %1  5 lshift CAN_F13R2        \ CAN_FB5	Bit Offset:5	Bit Width:1
\ %1  6 lshift CAN_F13R2        \ CAN_FB6	Bit Offset:6	Bit Width:1
\ %1  7 lshift CAN_F13R2        \ CAN_FB7	Bit Offset:7	Bit Width:1
\ %1  8 lshift CAN_F13R2        \ CAN_FB8	Bit Offset:8	Bit Width:1
\ %1  9 lshift CAN_F13R2        \ CAN_FB9	Bit Offset:9	Bit Width:1
\ %1  10 lshift CAN_F13R2        \ CAN_FB10	Bit Offset:10	Bit Width:1
\ %1  11 lshift CAN_F13R2        \ CAN_FB11	Bit Offset:11	Bit Width:1
\ %1  12 lshift CAN_F13R2        \ CAN_FB12	Bit Offset:12	Bit Width:1
\ %1  13 lshift CAN_F13R2        \ CAN_FB13	Bit Offset:13	Bit Width:1
\ %1  14 lshift CAN_F13R2        \ CAN_FB14	Bit Offset:14	Bit Width:1
\ %1  15 lshift CAN_F13R2        \ CAN_FB15	Bit Offset:15	Bit Width:1
\ %1  16 lshift CAN_F13R2        \ CAN_FB16	Bit Offset:16	Bit Width:1
\ %1  17 lshift CAN_F13R2        \ CAN_FB17	Bit Offset:17	Bit Width:1
\ %1  18 lshift CAN_F13R2        \ CAN_FB18	Bit Offset:18	Bit Width:1
\ %1  19 lshift CAN_F13R2        \ CAN_FB19	Bit Offset:19	Bit Width:1
\ %1  20 lshift CAN_F13R2        \ CAN_FB20	Bit Offset:20	Bit Width:1
\ %1  21 lshift CAN_F13R2        \ CAN_FB21	Bit Offset:21	Bit Width:1
\ %1  22 lshift CAN_F13R2        \ CAN_FB22	Bit Offset:22	Bit Width:1
\ %1  23 lshift CAN_F13R2        \ CAN_FB23	Bit Offset:23	Bit Width:1
\ %1  24 lshift CAN_F13R2        \ CAN_FB24	Bit Offset:24	Bit Width:1
\ %1  25 lshift CAN_F13R2        \ CAN_FB25	Bit Offset:25	Bit Width:1
\ %1  26 lshift CAN_F13R2        \ CAN_FB26	Bit Offset:26	Bit Width:1
\ %1  27 lshift CAN_F13R2        \ CAN_FB27	Bit Offset:27	Bit Width:1
\ %1  28 lshift CAN_F13R2        \ CAN_FB28	Bit Offset:28	Bit Width:1
\ %1  29 lshift CAN_F13R2        \ CAN_FB29	Bit Offset:29	Bit Width:1
\ %1  30 lshift CAN_F13R2        \ CAN_FB30	Bit Offset:30	Bit Width:1
\ %1  31 lshift CAN_F13R2        \ CAN_FB31	Bit Offset:31	Bit Width:1

  
\ DAC
\ DAC_CR read-write
$00000000 CONSTANT RESET_DAC_CR 
\ %1  0 lshift DAC_CR        \ DAC_EN1	Bit Offset:0	Bit Width:1
\ %1  1 lshift DAC_CR        \ DAC_BOFF1	Bit Offset:1	Bit Width:1
\ %1  2 lshift DAC_CR        \ DAC_TEN1	Bit Offset:2	Bit Width:1
\ %xxx  3 lshift DAC_CR        \ DAC_TSEL1	Bit Offset:3	Bit Width:3
\ %xx  6 lshift DAC_CR        \ DAC_WAVE1	Bit Offset:6	Bit Width:2
\ %xxxx  8 lshift DAC_CR        \ DAC_MAMP1	Bit Offset:8	Bit Width:4
\ %1  12 lshift DAC_CR        \ DAC_DMAEN1	Bit Offset:12	Bit Width:1
\ %1  16 lshift DAC_CR        \ DAC_EN2	Bit Offset:16	Bit Width:1
\ %1  17 lshift DAC_CR        \ DAC_BOFF2	Bit Offset:17	Bit Width:1
\ %1  18 lshift DAC_CR        \ DAC_TEN2	Bit Offset:18	Bit Width:1
\ %xxx  19 lshift DAC_CR        \ DAC_TSEL2	Bit Offset:19	Bit Width:3
\ %xx  22 lshift DAC_CR        \ DAC_WAVE2	Bit Offset:22	Bit Width:2
\ %xxxx  24 lshift DAC_CR        \ DAC_MAMP2	Bit Offset:24	Bit Width:4
\ %1  28 lshift DAC_CR        \ DAC_DMAEN2	Bit Offset:28	Bit Width:1

\ DAC_SWTRIGR write-only
$00000000 CONSTANT RESET_DAC_SWTRIGR 
\ %1  0 lshift DAC_SWTRIGR        \ DAC_SWTRIG1	Bit Offset:0	Bit Width:1
\ %1  1 lshift DAC_SWTRIGR        \ DAC_SWTRIG2	Bit Offset:1	Bit Width:1

\ DAC_DHR12R1 read-write
$00000000 CONSTANT RESET_DAC_DHR12R1 
\ %xxxxxxxxxxxx  0 lshift DAC_DHR12R1        \ DAC_DACC1DHR	Bit Offset:0	Bit Width:12

\ DAC_DHR12L1 read-write
$00000000 CONSTANT RESET_DAC_DHR12L1 
\ %xxxxxxxxxxxx  4 lshift DAC_DHR12L1        \ DAC_DACC1DHR	Bit Offset:4	Bit Width:12

\ DAC_DHR8R1 read-write
$00000000 CONSTANT RESET_DAC_DHR8R1 
\ %xxxxxxxx  0 lshift DAC_DHR8R1        \ DAC_DACC1DHR	Bit Offset:0	Bit Width:8

\ DAC_DHR12R2 read-write
$00000000 CONSTANT RESET_DAC_DHR12R2 
\ %xxxxxxxxxxxx  0 lshift DAC_DHR12R2        \ DAC_DACC2DHR	Bit Offset:0	Bit Width:12

\ DAC_DHR12L2 read-write
$00000000 CONSTANT RESET_DAC_DHR12L2 
\ %xxxxxxxxxxxx  4 lshift DAC_DHR12L2        \ DAC_DACC2DHR	Bit Offset:4	Bit Width:12

\ DAC_DHR8R2 read-write
$00000000 CONSTANT RESET_DAC_DHR8R2 
\ %xxxxxxxx  0 lshift DAC_DHR8R2        \ DAC_DACC2DHR	Bit Offset:0	Bit Width:8

\ DAC_DHR12RD read-write
$00000000 CONSTANT RESET_DAC_DHR12RD 
\ %xxxxxxxxxxxx  0 lshift DAC_DHR12RD        \ DAC_DACC1DHR	Bit Offset:0	Bit Width:12
\ %xxxxxxxxxxxx  16 lshift DAC_DHR12RD        \ DAC_DACC2DHR	Bit Offset:16	Bit Width:12

\ DAC_DHR12LD read-write
$00000000 CONSTANT RESET_DAC_DHR12LD 
\ %xxxxxxxxxxxx  4 lshift DAC_DHR12LD        \ DAC_DACC1DHR	Bit Offset:4	Bit Width:12
\ %xxxxxxxxxxxx  20 lshift DAC_DHR12LD        \ DAC_DACC2DHR	Bit Offset:20	Bit Width:12

\ DAC_DHR8RD read-write
$00000000 CONSTANT RESET_DAC_DHR8RD 
\ %xxxxxxxx  0 lshift DAC_DHR8RD        \ DAC_DACC1DHR	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift DAC_DHR8RD        \ DAC_DACC2DHR	Bit Offset:8	Bit Width:8

\ DAC_DOR1 read-only
$00000000 CONSTANT RESET_DAC_DOR1 
\ %xxxxxxxxxxxx  0 lshift DAC_DOR1        \ DAC_DACC1DOR	Bit Offset:0	Bit Width:12

\ DAC_DOR2 read-only
$00000000 CONSTANT RESET_DAC_DOR2 
\ %xxxxxxxxxxxx  0 lshift DAC_DOR2        \ DAC_DACC2DOR	Bit Offset:0	Bit Width:12

  
\ DBG
\ DBG_IDCODE read-only
$0 CONSTANT RESET_DBG_IDCODE 
\ %xxxxxxxxxxxx  0 lshift DBG_IDCODE        \ DBG_DEV_ID	Bit Offset:0	Bit Width:12
\ %xxxxxxxxxxxxxxxx  16 lshift DBG_IDCODE        \ DBG_REV_ID	Bit Offset:16	Bit Width:16

\ DBG_CR read-write
$0 CONSTANT RESET_DBG_CR 
\ %1  0 lshift DBG_CR        \ DBG_DBG_SLEEP	Bit Offset:0	Bit Width:1
\ %1  1 lshift DBG_CR        \ DBG_DBG_STOP	Bit Offset:1	Bit Width:1
\ %1  2 lshift DBG_CR        \ DBG_DBG_STANDBY	Bit Offset:2	Bit Width:1
\ %1  5 lshift DBG_CR        \ DBG_TRACE_IOEN	Bit Offset:5	Bit Width:1
\ %xx  6 lshift DBG_CR        \ DBG_TRACE_MODE	Bit Offset:6	Bit Width:2
\ %1  8 lshift DBG_CR        \ DBG_DBG_IWDG_STOP	Bit Offset:8	Bit Width:1
\ %1  9 lshift DBG_CR        \ DBG_DBG_WWDG_STOP	Bit Offset:9	Bit Width:1
\ %1  10 lshift DBG_CR        \ DBG_DBG_TIM1_STOP	Bit Offset:10	Bit Width:1
\ %1  11 lshift DBG_CR        \ DBG_DBG_TIM2_STOP	Bit Offset:11	Bit Width:1
\ %1  12 lshift DBG_CR        \ DBG_DBG_TIM3_STOP	Bit Offset:12	Bit Width:1
\ %1  13 lshift DBG_CR        \ DBG_DBG_TIM4_STOP	Bit Offset:13	Bit Width:1
\ %1  14 lshift DBG_CR        \ DBG_DBG_CAN1_STOP	Bit Offset:14	Bit Width:1
\ %1  15 lshift DBG_CR        \ DBG_DBG_I2C1_SMBUS_TIMEOUT	Bit Offset:15	Bit Width:1
\ %1  16 lshift DBG_CR        \ DBG_DBG_I2C2_SMBUS_TIMEOUT	Bit Offset:16	Bit Width:1
\ %1  17 lshift DBG_CR        \ DBG_DBG_TIM8_STOP	Bit Offset:17	Bit Width:1
\ %1  18 lshift DBG_CR        \ DBG_DBG_TIM5_STOP	Bit Offset:18	Bit Width:1
\ %1  19 lshift DBG_CR        \ DBG_DBG_TIM6_STOP	Bit Offset:19	Bit Width:1
\ %1  20 lshift DBG_CR        \ DBG_DBG_TIM7_STOP	Bit Offset:20	Bit Width:1
\ %1  21 lshift DBG_CR        \ DBG_DBG_CAN2_STOP	Bit Offset:21	Bit Width:1

  
\ UART4
\ UART4_SR 
$0 CONSTANT RESET_UART4_SR 
\ %1  0 lshift UART4_SR        \ UART4_PE	Bit Offset:0	Bit Width:1
\ %1  1 lshift UART4_SR        \ UART4_FE	Bit Offset:1	Bit Width:1
\ %1  2 lshift UART4_SR        \ UART4_NE	Bit Offset:2	Bit Width:1
\ %1  3 lshift UART4_SR        \ UART4_ORE	Bit Offset:3	Bit Width:1
\ %1  4 lshift UART4_SR        \ UART4_IDLE	Bit Offset:4	Bit Width:1
\ %1  5 lshift UART4_SR        \ UART4_RXNE	Bit Offset:5	Bit Width:1
\ %1  6 lshift UART4_SR        \ UART4_TC	Bit Offset:6	Bit Width:1
\ %1  7 lshift UART4_SR        \ UART4_TXE	Bit Offset:7	Bit Width:1
\ %1  8 lshift UART4_SR        \ UART4_LBD	Bit Offset:8	Bit Width:1

\ UART4_DR read-write
$0 CONSTANT RESET_UART4_DR 
\ %xxxxxxxxx  0 lshift UART4_DR        \ UART4_DR	Bit Offset:0	Bit Width:9

\ UART4_BRR read-write
$0 CONSTANT RESET_UART4_BRR 
\ %xxxx  0 lshift UART4_BRR        \ UART4_DIV_Fraction	Bit Offset:0	Bit Width:4
\ %xxxxxxxxxxxx  4 lshift UART4_BRR        \ UART4_DIV_Mantissa	Bit Offset:4	Bit Width:12

\ UART4_CR1 read-write
$0 CONSTANT RESET_UART4_CR1 
\ %1  0 lshift UART4_CR1        \ UART4_SBK	Bit Offset:0	Bit Width:1
\ %1  1 lshift UART4_CR1        \ UART4_RWU	Bit Offset:1	Bit Width:1
\ %1  2 lshift UART4_CR1        \ UART4_RE	Bit Offset:2	Bit Width:1
\ %1  3 lshift UART4_CR1        \ UART4_TE	Bit Offset:3	Bit Width:1
\ %1  4 lshift UART4_CR1        \ UART4_IDLEIE	Bit Offset:4	Bit Width:1
\ %1  5 lshift UART4_CR1        \ UART4_RXNEIE	Bit Offset:5	Bit Width:1
\ %1  6 lshift UART4_CR1        \ UART4_TCIE	Bit Offset:6	Bit Width:1
\ %1  7 lshift UART4_CR1        \ UART4_TXEIE	Bit Offset:7	Bit Width:1
\ %1  8 lshift UART4_CR1        \ UART4_PEIE	Bit Offset:8	Bit Width:1
\ %1  9 lshift UART4_CR1        \ UART4_PS	Bit Offset:9	Bit Width:1
\ %1  10 lshift UART4_CR1        \ UART4_PCE	Bit Offset:10	Bit Width:1
\ %1  11 lshift UART4_CR1        \ UART4_WAKE	Bit Offset:11	Bit Width:1
\ %1  12 lshift UART4_CR1        \ UART4_M	Bit Offset:12	Bit Width:1
\ %1  13 lshift UART4_CR1        \ UART4_UE	Bit Offset:13	Bit Width:1

\ UART4_CR2 read-write
$0 CONSTANT RESET_UART4_CR2 
\ %xxxx  0 lshift UART4_CR2        \ UART4_ADD	Bit Offset:0	Bit Width:4
\ %1  5 lshift UART4_CR2        \ UART4_LBDL	Bit Offset:5	Bit Width:1
\ %1  6 lshift UART4_CR2        \ UART4_LBDIE	Bit Offset:6	Bit Width:1
\ %xx  12 lshift UART4_CR2        \ UART4_STOP	Bit Offset:12	Bit Width:2
\ %1  14 lshift UART4_CR2        \ UART4_LINEN	Bit Offset:14	Bit Width:1

\ UART4_CR3 read-write
$0 CONSTANT RESET_UART4_CR3 
\ %1  0 lshift UART4_CR3        \ UART4_EIE	Bit Offset:0	Bit Width:1
\ %1  1 lshift UART4_CR3        \ UART4_IREN	Bit Offset:1	Bit Width:1
\ %1  2 lshift UART4_CR3        \ UART4_IRLP	Bit Offset:2	Bit Width:1
\ %1  3 lshift UART4_CR3        \ UART4_HDSEL	Bit Offset:3	Bit Width:1
\ %1  6 lshift UART4_CR3        \ UART4_DMAR	Bit Offset:6	Bit Width:1
\ %1  7 lshift UART4_CR3        \ UART4_DMAT	Bit Offset:7	Bit Width:1

  
\ UART5
\ UART5_SR 
$0 CONSTANT RESET_UART5_SR 
\ %1  0 lshift UART5_SR        \ UART5_PE	Bit Offset:0	Bit Width:1
\ %1  1 lshift UART5_SR        \ UART5_FE	Bit Offset:1	Bit Width:1
\ %1  2 lshift UART5_SR        \ UART5_NE	Bit Offset:2	Bit Width:1
\ %1  3 lshift UART5_SR        \ UART5_ORE	Bit Offset:3	Bit Width:1
\ %1  4 lshift UART5_SR        \ UART5_IDLE	Bit Offset:4	Bit Width:1
\ %1  5 lshift UART5_SR        \ UART5_RXNE	Bit Offset:5	Bit Width:1
\ %1  6 lshift UART5_SR        \ UART5_TC	Bit Offset:6	Bit Width:1
\ %1  7 lshift UART5_SR        \ UART5_TXE	Bit Offset:7	Bit Width:1
\ %1  8 lshift UART5_SR        \ UART5_LBD	Bit Offset:8	Bit Width:1

\ UART5_DR read-write
$0 CONSTANT RESET_UART5_DR 
\ %xxxxxxxxx  0 lshift UART5_DR        \ UART5_DR	Bit Offset:0	Bit Width:9

\ UART5_BRR read-write
$0 CONSTANT RESET_UART5_BRR 
\ %xxxx  0 lshift UART5_BRR        \ UART5_DIV_Fraction	Bit Offset:0	Bit Width:4
\ %xxxxxxxxxxxx  4 lshift UART5_BRR        \ UART5_DIV_Mantissa	Bit Offset:4	Bit Width:12

\ UART5_CR1 read-write
$0 CONSTANT RESET_UART5_CR1 
\ %1  0 lshift UART5_CR1        \ UART5_SBK	Bit Offset:0	Bit Width:1
\ %1  1 lshift UART5_CR1        \ UART5_RWU	Bit Offset:1	Bit Width:1
\ %1  2 lshift UART5_CR1        \ UART5_RE	Bit Offset:2	Bit Width:1
\ %1  3 lshift UART5_CR1        \ UART5_TE	Bit Offset:3	Bit Width:1
\ %1  4 lshift UART5_CR1        \ UART5_IDLEIE	Bit Offset:4	Bit Width:1
\ %1  5 lshift UART5_CR1        \ UART5_RXNEIE	Bit Offset:5	Bit Width:1
\ %1  6 lshift UART5_CR1        \ UART5_TCIE	Bit Offset:6	Bit Width:1
\ %1  7 lshift UART5_CR1        \ UART5_TXEIE	Bit Offset:7	Bit Width:1
\ %1  8 lshift UART5_CR1        \ UART5_PEIE	Bit Offset:8	Bit Width:1
\ %1  9 lshift UART5_CR1        \ UART5_PS	Bit Offset:9	Bit Width:1
\ %1  10 lshift UART5_CR1        \ UART5_PCE	Bit Offset:10	Bit Width:1
\ %1  11 lshift UART5_CR1        \ UART5_WAKE	Bit Offset:11	Bit Width:1
\ %1  12 lshift UART5_CR1        \ UART5_M	Bit Offset:12	Bit Width:1
\ %1  13 lshift UART5_CR1        \ UART5_UE	Bit Offset:13	Bit Width:1

\ UART5_CR2 read-write
$0 CONSTANT RESET_UART5_CR2 
\ %xxxx  0 lshift UART5_CR2        \ UART5_ADD	Bit Offset:0	Bit Width:4
\ %1  5 lshift UART5_CR2        \ UART5_LBDL	Bit Offset:5	Bit Width:1
\ %1  6 lshift UART5_CR2        \ UART5_LBDIE	Bit Offset:6	Bit Width:1
\ %xx  12 lshift UART5_CR2        \ UART5_STOP	Bit Offset:12	Bit Width:2
\ %1  14 lshift UART5_CR2        \ UART5_LINEN	Bit Offset:14	Bit Width:1

\ UART5_CR3 read-write
$0 CONSTANT RESET_UART5_CR3 
\ %1  0 lshift UART5_CR3        \ UART5_EIE	Bit Offset:0	Bit Width:1
\ %1  1 lshift UART5_CR3        \ UART5_IREN	Bit Offset:1	Bit Width:1
\ %1  2 lshift UART5_CR3        \ UART5_IRLP	Bit Offset:2	Bit Width:1
\ %1  3 lshift UART5_CR3        \ UART5_HDSEL	Bit Offset:3	Bit Width:1
\ %1  7 lshift UART5_CR3        \ UART5_DMAT	Bit Offset:7	Bit Width:1

  
\ CRC
\ CRC_DR read-write
$FFFFFFFF CONSTANT RESET_CRC_DR 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift CRC_DR        \ CRC_DR	Bit Offset:0	Bit Width:32

\ CRC_IDR read-write
$00000000 CONSTANT RESET_CRC_IDR 
\ %xxxxxxxx  0 lshift CRC_IDR        \ CRC_IDR	Bit Offset:0	Bit Width:8

\ CRC_CR write-only
$00000000 CONSTANT RESET_CRC_CR 
\ %1  0 lshift CRC_CR        \ CRC_RESET	Bit Offset:0	Bit Width:1

  
\ FLASH
\ FLASH_ACR 
$00000030 CONSTANT RESET_FLASH_ACR 
\ %xxx  0 lshift FLASH_ACR        \ FLASH_LATENCY	Bit Offset:0	Bit Width:3
\ %1  3 lshift FLASH_ACR        \ FLASH_HLFCYA	Bit Offset:3	Bit Width:1
\ %1  4 lshift FLASH_ACR        \ FLASH_PRFTBE	Bit Offset:4	Bit Width:1
\ %1  5 lshift FLASH_ACR        \ FLASH_PRFTBS	Bit Offset:5	Bit Width:1

\ FLASH_KEYR write-only
$00000000 CONSTANT RESET_FLASH_KEYR 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift FLASH_KEYR        \ FLASH_KEY	Bit Offset:0	Bit Width:32

\ FLASH_OPTKEYR write-only
$00000000 CONSTANT RESET_FLASH_OPTKEYR 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift FLASH_OPTKEYR        \ FLASH_OPTKEY	Bit Offset:0	Bit Width:32

\ FLASH_SR 
$00000000 CONSTANT RESET_FLASH_SR 
\ %1  5 lshift FLASH_SR        \ FLASH_EOP	Bit Offset:5	Bit Width:1
\ %1  4 lshift FLASH_SR        \ FLASH_WRPRTERR	Bit Offset:4	Bit Width:1
\ %1  2 lshift FLASH_SR        \ FLASH_PGERR	Bit Offset:2	Bit Width:1
\ %1  0 lshift FLASH_SR        \ FLASH_BSY	Bit Offset:0	Bit Width:1

\ FLASH_CR read-write
$00000080 CONSTANT RESET_FLASH_CR 
\ %1  0 lshift FLASH_CR        \ FLASH_PG	Bit Offset:0	Bit Width:1
\ %1  1 lshift FLASH_CR        \ FLASH_PER	Bit Offset:1	Bit Width:1
\ %1  2 lshift FLASH_CR        \ FLASH_MER	Bit Offset:2	Bit Width:1
\ %1  4 lshift FLASH_CR        \ FLASH_OPTPG	Bit Offset:4	Bit Width:1
\ %1  5 lshift FLASH_CR        \ FLASH_OPTER	Bit Offset:5	Bit Width:1
\ %1  6 lshift FLASH_CR        \ FLASH_STRT	Bit Offset:6	Bit Width:1
\ %1  7 lshift FLASH_CR        \ FLASH_LOCK	Bit Offset:7	Bit Width:1
\ %1  9 lshift FLASH_CR        \ FLASH_OPTWRE	Bit Offset:9	Bit Width:1
\ %1  10 lshift FLASH_CR        \ FLASH_ERRIE	Bit Offset:10	Bit Width:1
\ %1  12 lshift FLASH_CR        \ FLASH_EOPIE	Bit Offset:12	Bit Width:1

\ FLASH_AR write-only
$00000000 CONSTANT RESET_FLASH_AR 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift FLASH_AR        \ FLASH_FAR	Bit Offset:0	Bit Width:32

\ FLASH_OBR read-only
$03FFFFFC CONSTANT RESET_FLASH_OBR 
\ %1  0 lshift FLASH_OBR        \ FLASH_OPTERR	Bit Offset:0	Bit Width:1
\ %1  1 lshift FLASH_OBR        \ FLASH_RDPRT	Bit Offset:1	Bit Width:1
\ %1  2 lshift FLASH_OBR        \ FLASH_WDG_SW	Bit Offset:2	Bit Width:1
\ %1  3 lshift FLASH_OBR        \ FLASH_nRST_STOP	Bit Offset:3	Bit Width:1
\ %1  4 lshift FLASH_OBR        \ FLASH_nRST_STDBY	Bit Offset:4	Bit Width:1
\ %xxxxxxxx  10 lshift FLASH_OBR        \ FLASH_Data0	Bit Offset:10	Bit Width:8
\ %xxxxxxxx  18 lshift FLASH_OBR        \ FLASH_Data1	Bit Offset:18	Bit Width:8

\ FLASH_WRPR read-only
$FFFFFFFF CONSTANT RESET_FLASH_WRPR 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift FLASH_WRPR        \ FLASH_WRP	Bit Offset:0	Bit Width:32

  
\ NVIC
\ NVIC_ICTR read-only
$00000000 CONSTANT RESET_NVIC_ICTR 
\ %xxxx  0 lshift NVIC_ICTR        \ NVIC_INTLINESNUM	Bit Offset:0	Bit Width:4

\ NVIC_STIR write-only
$00000000 CONSTANT RESET_NVIC_STIR 
\ %xxxxxxxxx  0 lshift NVIC_STIR        \ NVIC_INTID	Bit Offset:0	Bit Width:9

\ NVIC_ISER0 read-write
$00000000 CONSTANT RESET_NVIC_ISER0 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift NVIC_ISER0        \ NVIC_SETENA	Bit Offset:0	Bit Width:32

\ NVIC_ISER1 read-write
$00000000 CONSTANT RESET_NVIC_ISER1 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift NVIC_ISER1        \ NVIC_SETENA	Bit Offset:0	Bit Width:32

\ NVIC_ICER0 read-write
$00000000 CONSTANT RESET_NVIC_ICER0 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift NVIC_ICER0        \ NVIC_CLRENA	Bit Offset:0	Bit Width:32

\ NVIC_ICER1 read-write
$00000000 CONSTANT RESET_NVIC_ICER1 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift NVIC_ICER1        \ NVIC_CLRENA	Bit Offset:0	Bit Width:32

\ NVIC_ISPR0 read-write
$00000000 CONSTANT RESET_NVIC_ISPR0 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift NVIC_ISPR0        \ NVIC_SETPEND	Bit Offset:0	Bit Width:32

\ NVIC_ISPR1 read-write
$00000000 CONSTANT RESET_NVIC_ISPR1 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift NVIC_ISPR1        \ NVIC_SETPEND	Bit Offset:0	Bit Width:32

\ NVIC_ICPR0 read-write
$00000000 CONSTANT RESET_NVIC_ICPR0 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift NVIC_ICPR0        \ NVIC_CLRPEND	Bit Offset:0	Bit Width:32

\ NVIC_ICPR1 read-write
$00000000 CONSTANT RESET_NVIC_ICPR1 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift NVIC_ICPR1        \ NVIC_CLRPEND	Bit Offset:0	Bit Width:32

\ NVIC_IABR0 read-only
$00000000 CONSTANT RESET_NVIC_IABR0 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift NVIC_IABR0        \ NVIC_ACTIVE	Bit Offset:0	Bit Width:32

\ NVIC_IABR1 read-only
$00000000 CONSTANT RESET_NVIC_IABR1 
\ %xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  0 lshift NVIC_IABR1        \ NVIC_ACTIVE	Bit Offset:0	Bit Width:32

\ NVIC_IPR0 read-write
$00000000 CONSTANT RESET_NVIC_IPR0 
\ %xxxxxxxx  0 lshift NVIC_IPR0        \ NVIC_IPR_N0	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift NVIC_IPR0        \ NVIC_IPR_N1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  16 lshift NVIC_IPR0        \ NVIC_IPR_N2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  24 lshift NVIC_IPR0        \ NVIC_IPR_N3	Bit Offset:24	Bit Width:8

\ NVIC_IPR1 read-write
$00000000 CONSTANT RESET_NVIC_IPR1 
\ %xxxxxxxx  0 lshift NVIC_IPR1        \ NVIC_IPR_N0	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift NVIC_IPR1        \ NVIC_IPR_N1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  16 lshift NVIC_IPR1        \ NVIC_IPR_N2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  24 lshift NVIC_IPR1        \ NVIC_IPR_N3	Bit Offset:24	Bit Width:8

\ NVIC_IPR2 read-write
$00000000 CONSTANT RESET_NVIC_IPR2 
\ %xxxxxxxx  0 lshift NVIC_IPR2        \ NVIC_IPR_N0	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift NVIC_IPR2        \ NVIC_IPR_N1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  16 lshift NVIC_IPR2        \ NVIC_IPR_N2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  24 lshift NVIC_IPR2        \ NVIC_IPR_N3	Bit Offset:24	Bit Width:8

\ NVIC_IPR3 read-write
$00000000 CONSTANT RESET_NVIC_IPR3 
\ %xxxxxxxx  0 lshift NVIC_IPR3        \ NVIC_IPR_N0	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift NVIC_IPR3        \ NVIC_IPR_N1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  16 lshift NVIC_IPR3        \ NVIC_IPR_N2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  24 lshift NVIC_IPR3        \ NVIC_IPR_N3	Bit Offset:24	Bit Width:8

\ NVIC_IPR4 read-write
$00000000 CONSTANT RESET_NVIC_IPR4 
\ %xxxxxxxx  0 lshift NVIC_IPR4        \ NVIC_IPR_N0	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift NVIC_IPR4        \ NVIC_IPR_N1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  16 lshift NVIC_IPR4        \ NVIC_IPR_N2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  24 lshift NVIC_IPR4        \ NVIC_IPR_N3	Bit Offset:24	Bit Width:8

\ NVIC_IPR5 read-write
$00000000 CONSTANT RESET_NVIC_IPR5 
\ %xxxxxxxx  0 lshift NVIC_IPR5        \ NVIC_IPR_N0	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift NVIC_IPR5        \ NVIC_IPR_N1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  16 lshift NVIC_IPR5        \ NVIC_IPR_N2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  24 lshift NVIC_IPR5        \ NVIC_IPR_N3	Bit Offset:24	Bit Width:8

\ NVIC_IPR6 read-write
$00000000 CONSTANT RESET_NVIC_IPR6 
\ %xxxxxxxx  0 lshift NVIC_IPR6        \ NVIC_IPR_N0	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift NVIC_IPR6        \ NVIC_IPR_N1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  16 lshift NVIC_IPR6        \ NVIC_IPR_N2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  24 lshift NVIC_IPR6        \ NVIC_IPR_N3	Bit Offset:24	Bit Width:8

\ NVIC_IPR7 read-write
$00000000 CONSTANT RESET_NVIC_IPR7 
\ %xxxxxxxx  0 lshift NVIC_IPR7        \ NVIC_IPR_N0	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift NVIC_IPR7        \ NVIC_IPR_N1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  16 lshift NVIC_IPR7        \ NVIC_IPR_N2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  24 lshift NVIC_IPR7        \ NVIC_IPR_N3	Bit Offset:24	Bit Width:8

\ NVIC_IPR8 read-write
$00000000 CONSTANT RESET_NVIC_IPR8 
\ %xxxxxxxx  0 lshift NVIC_IPR8        \ NVIC_IPR_N0	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift NVIC_IPR8        \ NVIC_IPR_N1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  16 lshift NVIC_IPR8        \ NVIC_IPR_N2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  24 lshift NVIC_IPR8        \ NVIC_IPR_N3	Bit Offset:24	Bit Width:8

\ NVIC_IPR9 read-write
$00000000 CONSTANT RESET_NVIC_IPR9 
\ %xxxxxxxx  0 lshift NVIC_IPR9        \ NVIC_IPR_N0	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift NVIC_IPR9        \ NVIC_IPR_N1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  16 lshift NVIC_IPR9        \ NVIC_IPR_N2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  24 lshift NVIC_IPR9        \ NVIC_IPR_N3	Bit Offset:24	Bit Width:8

\ NVIC_IPR10 read-write
$00000000 CONSTANT RESET_NVIC_IPR10 
\ %xxxxxxxx  0 lshift NVIC_IPR10        \ NVIC_IPR_N0	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift NVIC_IPR10        \ NVIC_IPR_N1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  16 lshift NVIC_IPR10        \ NVIC_IPR_N2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  24 lshift NVIC_IPR10        \ NVIC_IPR_N3	Bit Offset:24	Bit Width:8

\ NVIC_IPR11 read-write
$00000000 CONSTANT RESET_NVIC_IPR11 
\ %xxxxxxxx  0 lshift NVIC_IPR11        \ NVIC_IPR_N0	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift NVIC_IPR11        \ NVIC_IPR_N1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  16 lshift NVIC_IPR11        \ NVIC_IPR_N2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  24 lshift NVIC_IPR11        \ NVIC_IPR_N3	Bit Offset:24	Bit Width:8

\ NVIC_IPR12 read-write
$00000000 CONSTANT RESET_NVIC_IPR12 
\ %xxxxxxxx  0 lshift NVIC_IPR12        \ NVIC_IPR_N0	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift NVIC_IPR12        \ NVIC_IPR_N1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  16 lshift NVIC_IPR12        \ NVIC_IPR_N2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  24 lshift NVIC_IPR12        \ NVIC_IPR_N3	Bit Offset:24	Bit Width:8

\ NVIC_IPR13 read-write
$00000000 CONSTANT RESET_NVIC_IPR13 
\ %xxxxxxxx  0 lshift NVIC_IPR13        \ NVIC_IPR_N0	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift NVIC_IPR13        \ NVIC_IPR_N1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  16 lshift NVIC_IPR13        \ NVIC_IPR_N2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  24 lshift NVIC_IPR13        \ NVIC_IPR_N3	Bit Offset:24	Bit Width:8

\ NVIC_IPR14 read-write
$00000000 CONSTANT RESET_NVIC_IPR14 
\ %xxxxxxxx  0 lshift NVIC_IPR14        \ NVIC_IPR_N0	Bit Offset:0	Bit Width:8
\ %xxxxxxxx  8 lshift NVIC_IPR14        \ NVIC_IPR_N1	Bit Offset:8	Bit Width:8
\ %xxxxxxxx  16 lshift NVIC_IPR14        \ NVIC_IPR_N2	Bit Offset:16	Bit Width:8
\ %xxxxxxxx  24 lshift NVIC_IPR14        \ NVIC_IPR_N3	Bit Offset:24	Bit Width:8

  
\ USB
\ USB_EP0R read-write
$00000000 CONSTANT RESET_USB_EP0R 
\ %xxxx  0 lshift USB_EP0R        \ USB_EA	Bit Offset:0	Bit Width:4
\ %xx  4 lshift USB_EP0R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
\ %1  6 lshift USB_EP0R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
\ %1  7 lshift USB_EP0R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
\ %1  8 lshift USB_EP0R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
\ %xx  9 lshift USB_EP0R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
\ %1  11 lshift USB_EP0R        \ USB_SETUP	Bit Offset:11	Bit Width:1
\ %xx  12 lshift USB_EP0R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
\ %1  14 lshift USB_EP0R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
\ %1  15 lshift USB_EP0R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1

\ USB_EP1R read-write
$00000000 CONSTANT RESET_USB_EP1R 
\ %xxxx  0 lshift USB_EP1R        \ USB_EA	Bit Offset:0	Bit Width:4
\ %xx  4 lshift USB_EP1R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
\ %1  6 lshift USB_EP1R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
\ %1  7 lshift USB_EP1R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
\ %1  8 lshift USB_EP1R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
\ %xx  9 lshift USB_EP1R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
\ %1  11 lshift USB_EP1R        \ USB_SETUP	Bit Offset:11	Bit Width:1
\ %xx  12 lshift USB_EP1R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
\ %1  14 lshift USB_EP1R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
\ %1  15 lshift USB_EP1R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1

\ USB_EP2R read-write
$00000000 CONSTANT RESET_USB_EP2R 
\ %xxxx  0 lshift USB_EP2R        \ USB_EA	Bit Offset:0	Bit Width:4
\ %xx  4 lshift USB_EP2R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
\ %1  6 lshift USB_EP2R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
\ %1  7 lshift USB_EP2R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
\ %1  8 lshift USB_EP2R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
\ %xx  9 lshift USB_EP2R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
\ %1  11 lshift USB_EP2R        \ USB_SETUP	Bit Offset:11	Bit Width:1
\ %xx  12 lshift USB_EP2R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
\ %1  14 lshift USB_EP2R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
\ %1  15 lshift USB_EP2R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1

\ USB_EP3R read-write
$00000000 CONSTANT RESET_USB_EP3R 
\ %xxxx  0 lshift USB_EP3R        \ USB_EA	Bit Offset:0	Bit Width:4
\ %xx  4 lshift USB_EP3R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
\ %1  6 lshift USB_EP3R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
\ %1  7 lshift USB_EP3R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
\ %1  8 lshift USB_EP3R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
\ %xx  9 lshift USB_EP3R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
\ %1  11 lshift USB_EP3R        \ USB_SETUP	Bit Offset:11	Bit Width:1
\ %xx  12 lshift USB_EP3R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
\ %1  14 lshift USB_EP3R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
\ %1  15 lshift USB_EP3R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1

\ USB_EP4R read-write
$00000000 CONSTANT RESET_USB_EP4R 
\ %xxxx  0 lshift USB_EP4R        \ USB_EA	Bit Offset:0	Bit Width:4
\ %xx  4 lshift USB_EP4R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
\ %1  6 lshift USB_EP4R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
\ %1  7 lshift USB_EP4R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
\ %1  8 lshift USB_EP4R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
\ %xx  9 lshift USB_EP4R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
\ %1  11 lshift USB_EP4R        \ USB_SETUP	Bit Offset:11	Bit Width:1
\ %xx  12 lshift USB_EP4R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
\ %1  14 lshift USB_EP4R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
\ %1  15 lshift USB_EP4R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1

\ USB_EP5R read-write
$00000000 CONSTANT RESET_USB_EP5R 
\ %xxxx  0 lshift USB_EP5R        \ USB_EA	Bit Offset:0	Bit Width:4
\ %xx  4 lshift USB_EP5R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
\ %1  6 lshift USB_EP5R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
\ %1  7 lshift USB_EP5R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
\ %1  8 lshift USB_EP5R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
\ %xx  9 lshift USB_EP5R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
\ %1  11 lshift USB_EP5R        \ USB_SETUP	Bit Offset:11	Bit Width:1
\ %xx  12 lshift USB_EP5R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
\ %1  14 lshift USB_EP5R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
\ %1  15 lshift USB_EP5R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1

\ USB_EP6R read-write
$00000000 CONSTANT RESET_USB_EP6R 
\ %xxxx  0 lshift USB_EP6R        \ USB_EA	Bit Offset:0	Bit Width:4
\ %xx  4 lshift USB_EP6R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
\ %1  6 lshift USB_EP6R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
\ %1  7 lshift USB_EP6R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
\ %1  8 lshift USB_EP6R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
\ %xx  9 lshift USB_EP6R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
\ %1  11 lshift USB_EP6R        \ USB_SETUP	Bit Offset:11	Bit Width:1
\ %xx  12 lshift USB_EP6R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
\ %1  14 lshift USB_EP6R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
\ %1  15 lshift USB_EP6R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1

\ USB_EP7R read-write
$00000000 CONSTANT RESET_USB_EP7R 
\ %xxxx  0 lshift USB_EP7R        \ USB_EA	Bit Offset:0	Bit Width:4
\ %xx  4 lshift USB_EP7R        \ USB_STAT_TX	Bit Offset:4	Bit Width:2
\ %1  6 lshift USB_EP7R        \ USB_DTOG_TX	Bit Offset:6	Bit Width:1
\ %1  7 lshift USB_EP7R        \ USB_CTR_TX	Bit Offset:7	Bit Width:1
\ %1  8 lshift USB_EP7R        \ USB_EP_KIND	Bit Offset:8	Bit Width:1
\ %xx  9 lshift USB_EP7R        \ USB_EP_TYPE	Bit Offset:9	Bit Width:2
\ %1  11 lshift USB_EP7R        \ USB_SETUP	Bit Offset:11	Bit Width:1
\ %xx  12 lshift USB_EP7R        \ USB_STAT_RX	Bit Offset:12	Bit Width:2
\ %1  14 lshift USB_EP7R        \ USB_DTOG_RX	Bit Offset:14	Bit Width:1
\ %1  15 lshift USB_EP7R        \ USB_CTR_RX	Bit Offset:15	Bit Width:1

\ USB_CNTR read-write
$00000003 CONSTANT RESET_USB_CNTR 
\ %1  0 lshift USB_CNTR        \ USB_FRES	Bit Offset:0	Bit Width:1
\ %1  1 lshift USB_CNTR        \ USB_PDWN	Bit Offset:1	Bit Width:1
\ %1  2 lshift USB_CNTR        \ USB_LPMODE	Bit Offset:2	Bit Width:1
\ %1  3 lshift USB_CNTR        \ USB_FSUSP	Bit Offset:3	Bit Width:1
\ %1  4 lshift USB_CNTR        \ USB_RESUME	Bit Offset:4	Bit Width:1
\ %1  8 lshift USB_CNTR        \ USB_ESOFM	Bit Offset:8	Bit Width:1
\ %1  9 lshift USB_CNTR        \ USB_SOFM	Bit Offset:9	Bit Width:1
\ %1  10 lshift USB_CNTR        \ USB_RESETM	Bit Offset:10	Bit Width:1
\ %1  11 lshift USB_CNTR        \ USB_SUSPM	Bit Offset:11	Bit Width:1
\ %1  12 lshift USB_CNTR        \ USB_WKUPM	Bit Offset:12	Bit Width:1
\ %1  13 lshift USB_CNTR        \ USB_ERRM	Bit Offset:13	Bit Width:1
\ %1  14 lshift USB_CNTR        \ USB_PMAOVRM	Bit Offset:14	Bit Width:1
\ %1  15 lshift USB_CNTR        \ USB_CTRM	Bit Offset:15	Bit Width:1

\ USB_ISTR read-write
$00000000 CONSTANT RESET_USB_ISTR 
\ %xxxx  0 lshift USB_ISTR        \ USB_EP_ID	Bit Offset:0	Bit Width:4
\ %1  4 lshift USB_ISTR        \ USB_DIR	Bit Offset:4	Bit Width:1
\ %1  8 lshift USB_ISTR        \ USB_ESOF	Bit Offset:8	Bit Width:1
\ %1  9 lshift USB_ISTR        \ USB_SOF	Bit Offset:9	Bit Width:1
\ %1  10 lshift USB_ISTR        \ USB_RESET	Bit Offset:10	Bit Width:1
\ %1  11 lshift USB_ISTR        \ USB_SUSP	Bit Offset:11	Bit Width:1
\ %1  12 lshift USB_ISTR        \ USB_WKUP	Bit Offset:12	Bit Width:1
\ %1  13 lshift USB_ISTR        \ USB_ERR	Bit Offset:13	Bit Width:1
\ %1  14 lshift USB_ISTR        \ USB_PMAOVR	Bit Offset:14	Bit Width:1
\ %1  15 lshift USB_ISTR        \ USB_CTR	Bit Offset:15	Bit Width:1

\ USB_FNR read-only
$0000 CONSTANT RESET_USB_FNR 
\ % 0 lshift USB_FNR        \ USB_FN	Bit Offset:0	Bit Width:11
\ %xx  11 lshift USB_FNR        \ USB_LSOF	Bit Offset:11	Bit Width:2
\ %1  13 lshift USB_FNR        \ USB_LCK	Bit Offset:13	Bit Width:1
\ %1  14 lshift USB_FNR        \ USB_RXDM	Bit Offset:14	Bit Width:1
\ %1  15 lshift USB_FNR        \ USB_RXDP	Bit Offset:15	Bit Width:1

\ USB_DADDR read-write
$0000 CONSTANT RESET_USB_DADDR 
\ %xxxxxxx  0 lshift USB_DADDR        \ USB_ADD	Bit Offset:0	Bit Width:7
\ %1  7 lshift USB_DADDR        \ USB_EF	Bit Offset:7	Bit Width:1

\ USB_BTABLE read-write
$0000 CONSTANT RESET_USB_BTABLE 
\ % 3 lshift USB_BTABLE        \ USB_BTABLE	Bit Offset:3	Bit Width:13

  
