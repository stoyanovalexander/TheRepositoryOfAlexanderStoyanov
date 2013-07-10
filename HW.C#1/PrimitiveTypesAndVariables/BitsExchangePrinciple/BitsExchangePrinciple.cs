using System;
class BitsExchangePrinciple
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of  p  ( p<32 ): ");
        byte p = byte.Parse(Console.ReadLine());
        if (p >= 32)
        {
            Console.WriteLine("Write other value for  p");
        }
        else
        {
            Console.WriteLine("Enter a value of  k  ( k<16 ): ");
            byte k = byte.Parse(Console.ReadLine());
            if (k >= 16)
            {
                Console.WriteLine("Write other value for  k");
            }
            else
            {
                Console.WriteLine("Write a value for  q ( q<32 ): ");
                byte q = byte.Parse(Console.ReadLine());
                if (q + (k - 1) >= 32)
                {
                    Console.WriteLine("Write other values of q  or  k ");
                }
                else
                {
                    if (p + (k - 1) >= q)
                    {
                        Console.WriteLine("Write other values of  p  or  q  or  k ");
                    }
                    else
                    {
                        uint mask =((uint)Math.Pow(2.0,(double)k))-1;
                        uint maskOne = mask << p;
                        uint resultOne = number & maskOne;
                        uint maskTwo = mask << q;
                        uint resultTwo = number & maskTwo;
                        uint notMaskOne = ~maskOne;
                        uint notMaskTwo = ~maskTwo;
                        uint zerosBitsForChange = (number & notMaskOne) & notMaskTwo;
                        resultOne = resultOne << (q - p);
                        resultTwo = resultTwo >> (q - p);
                        uint lastMask = resultOne | resultTwo;
                        uint changedNumber = zerosBitsForChange | lastMask;
                        Console.WriteLine(number + " After changing bits [p,(p+k-1))] with [q,(q+k-1)] is changedNamber=" + changedNumber);
                    }
                }
            }
        }
    }
}

       
            

