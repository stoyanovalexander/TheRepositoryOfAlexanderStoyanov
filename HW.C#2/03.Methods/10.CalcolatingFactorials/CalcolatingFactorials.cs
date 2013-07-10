using System;
using System.Numerics;
    class CalcolatingFactorials
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write("{0}!= ",i);
                CalculateFactorial(i);
                Console.WriteLine();
            }
        }
        static void CalculateFactorial(int num)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            Console.Write(factorial);

        }
    }
