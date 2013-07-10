using System;
    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Enter the number of the Catalan number: ");
            byte number = byte.Parse(Console.ReadLine());
            double catalanNumber=1;
            if(number==0)
      // catalan0=(2*0)!/((0+1)!*0!)=1/1= 1
            {
                Console.WriteLine("catalanNumber="+1);
            }
            else if(number==1)
    // catalan1=(1*2)!/((1+1)!*1!)=2/2= 1
            {
                Console.WriteLine("catalanNumber="+1);
            }
            else
            {
                for (uint divisor = 2 , dividend=2*(uint)number; divisor <= number; divisor++,dividend--)   
    //catalan5=(2*5)!/((5+1)!*5!)=10!/(6!*5!)=(10*9*8*7)/(2*3*4*5)= (10/2) * (9/3) * (8/4) * (7/5)
                {
                    catalanNumber = catalanNumber * ((double)dividend / (double)divisor);
                }
                Console.WriteLine("catalanNumber="+catalanNumber);
            }
        }
    }
