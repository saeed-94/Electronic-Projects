$regfile = "attiny24.dat"
$crystal = 800000
Config Porta = Output



do
reset porta
set porta.0
waitms 500
reset porta.0

set porta.1
waitms 500
reset porta.1

set porta.2
waitms 500
reset porta.2

set porta.3
waitms 500
reset porta.3

set porta.4
waitms 500
reset porta.4

set porta.5
waitms 500
reset porta.5

set porta.6
waitms 500
reset porta.6

set porta.7
waitms 500
reset porta.7


loop
end
