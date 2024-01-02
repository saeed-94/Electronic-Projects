$regfile = "attiny13.dat"
$crystal = 480000
Config PortB.0 =Output
config portb.1= output
config portb.2=output

do
reset portb.0
reset portb.1
set portb.2
waitms 6000
reset portb.0
set portb.1
reset portb.2
waitms 2000
set portb.0
reset portb.1
reset portb.2
waitms 6000
loop
end