s <- read.csv("log.csv")
# Scale to physical units: 
# 3.3 V reference, div5 voltage divider, 10x oversampling, 12 bit ADC
# s$voltage <- s$voltage * 3.3 * 5 / 10 / 4095
# old voltage scaling: no longer necessary
# s$voltage <- s$voltage * 3.778  / 10000
# s$current <- s$current * 3.668 / 1000
s$current <- s$current / 1000
s$voltage <- s$voltage / 1000

s$power <- s$voltage * s$current # milliwatts

attach(s)
vmax = voltage[which.max(power)]
pmax = power[which.max(power)]


## Graph out
png("solarcell.png", width=1024, height=800, pointsize=18)

par(mar=c(5,4,4,5)+.1)
plot(voltage, current, cex=3,
     xlab="Voltage", ylab="Current (milliamps)", main="Solar Cell Characterization")
# plot(voltage, current, 
#      xlab="Voltage", ylab="Current (milliamps)", main="Solar Cell Characterization")

## second axis for power
par(new=T)
#plot(voltage, power, col=2, axes=F, xlab=NA, ylab=NA)
plot(voltage, power, col=2, axes=F, xlab=NA, ylab=NA, cex=3)
axis(side=4)
mtext("Power (milliwatts)", side=4, line=3)

## precise lines, values
abline(v=vmax, lty=2, lwd=2)
axis(1, at=round(vmax,2), padj=1.5)
abline(h=pmax, lty=3, lwd=2)
axis(4, at=round(pmax,2), padj=1.5)
dev.off()

detach(s)



