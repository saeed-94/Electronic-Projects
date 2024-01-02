/*******************************************************
This program was created by the
CodeWizardAVR V3.12 Advanced
Automatic Program Generator
� Copyright 1998-2014 Pavel Haiduc, HP InfoTech s.r.l.
http://www.hpinfotech.com

Project : traffic_light
Version : 1
Date    : 1398/08/26
Author  : Saeed Ghorbani
Company : SA
Comments: 


Chip type               : ATtiny13
AVR Core Clock frequency: 4.800000 MHz
Memory model            : Tiny
External RAM size       : 0
Data Stack size         : 16
*******************************************************/

#include <tiny13.h>
#include <delay.h>

#define red     PORTB.0 
#define yellow     PORTB.1 
#define green     PORTB.2 

void main(void)
{

#pragma optsize-
CLKPR=(1<<CLKPCE);
CLKPR=(0<<CLKPCE) | (0<<CLKPS3) | (0<<CLKPS2) | (0<<CLKPS1) | (0<<CLKPS0);
#ifdef _OPTIMIZE_SIZE_
#pragma optsize+
#endif


DDRB=(0<<DDB5) | (0<<DDB4) | (0<<DDB3) | (1<<DDB2) | (1<<DDB1) | (1<<DDB0);
PORTB=(0<<PORTB5) | (0<<PORTB4) | (0<<PORTB3) | (0<<PORTB2) | (0<<PORTB1) | (0<<PORTB0);

while (1)
      {
      red=0;
      yellow=0;
      green=1;

      delay_ms(6000); 
      red=0;
      yellow=1;
      green=0;

      delay_ms(2000); 
      red=1;
      yellow=0;
      green=0;
      delay_ms(6000);
    }  
}