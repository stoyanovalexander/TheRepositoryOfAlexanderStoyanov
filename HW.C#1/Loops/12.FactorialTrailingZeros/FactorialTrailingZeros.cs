using System;
using System.Numerics;
    class FactorialTrailingZeros
    {
        static void Main()
        {
            Console.Write("Enter num=");
            uint num = uint.Parse(Console.ReadLine());
            BigInteger numFactorial = 1;
            uint forCountingZeros = num;
            uint addZeros;
            uint trailingZeros=0;
            while (forCountingZeros != 0)
            {
                addZeros = forCountingZeros / 5;
                forCountingZeros = addZeros;
                trailingZeros = trailingZeros + addZeros;
            }
            for (uint number = 2; number <= num; number++)
            {
                numFactorial = numFactorial * number;
            }
            Console.WriteLine("num={0} → num!={1} → {2}", num, numFactorial,trailingZeros);
        }
    }

