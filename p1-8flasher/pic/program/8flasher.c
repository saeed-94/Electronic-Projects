#include <8flasher.h>
#include <16C61.h>
#use delay (clock=20000000)
#use FIXED_IO( B_outputs=PIN_B7,PIN_B6,PIN_B5,PIN_B4,PIN_B3,PIN_B2,PIN_B1,PIN_B0 )

void main()
{

int data=0x01;

   while(TRUE)
   {
  output_b(data);
  delay_ms(100);
  data=data<<1;
  
}

}

