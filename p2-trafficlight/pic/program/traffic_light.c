#include <traffic_light.h>
#include <10LF322.h>
#use delay(clock=20000000)
#use FIXED_IO( A_outputs=PIN_A2,PIN_A1,PIN_A0 )

void main()
{

   while(TRUE)
   {
output_low(PIN_A0);
output_low(PIN_A1);
output_high(PIN_A2);
delay_ms( 6000 );
output_low(PIN_A0);
output_high(PIN_A1);
output_low(PIN_A2);
delay_ms( 2000 );
output_high(PIN_A0);
output_low(PIN_A1);
output_low(PIN_A2);
delay_ms( 6000 );






      
   }

}
