using System;
using System.Numerics;
    class SumOfNFibonaci
    {
        static void Main()
        {
            Console.Write("Enter the number of Fibonaci numbers NumbersFib=");
            uint numbersFib = uint.Parse(Console.ReadLine());
            BigInteger smallFib = 0;
            BigInteger middleFib = 1;
            BigInteger bigFib=smallFib+middleFib;
            BigInteger SumFibonaci;
            BigInteger forReplace;
            if (numbersFib == 0)
            {
                Console.WriteLine("Enter bigger value of fibonaciNum");
            }
            else if (numbersFib == 1)
            {
                Console.WriteLine("sumFibonaci="+smallFib);
            }
            else if (numbersFib == 2)
            {
                Console.WriteLine("sumFibonaci=" + (smallFib + middleFib));
            }
            else if (numbersFib == 3)
            {
                Console.WriteLine("sumFibonaci="+(smallFib+middleFib+bigFib));
            }
            else
            {
                SumFibonaci = smallFib + middleFib + bigFib;
                for (uint num = 4; num <= numbersFib; num++)
                {
                    forReplace = bigFib;
                    bigFib = middleFib+bigFib;

                    smallFib = middleFib;
                    middleFib = forReplace;
                    SumFibonaci = SumFibonaci + bigFib;
                }
                Console.WriteLine("sumFibonaci="+SumFibonaci);
            }
        }
    }

