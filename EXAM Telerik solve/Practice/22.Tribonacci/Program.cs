using System;
using System.Numerics;
    class Program
    {
        static void Main(string[] args)
        {
            // Input data
            BigInteger T1 = BigInteger.Parse(Console.ReadLine());
            BigInteger T2 = BigInteger.Parse(Console.ReadLine());
            BigInteger T3 = BigInteger.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            // Solve
            if (N == 1) Console.WriteLine(T1);
            else if (N == 2) Console.WriteLine(T2);
            else if (N == 3) Console.WriteLine(T3);
            else
            {
                BigInteger sum = 0;
                for (long i = 4; i <= N; i++)
                {
                    sum = T1 + T2 + T3;
                    T1 = T2;
                    T2 = T3;
                    T3 = sum;
                }
                Console.WriteLine(T3);
            }
        }
    }

