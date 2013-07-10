using System;
using System.Numerics;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = 0;
            for (int i = 1; i <= n; i++)
            {
                BigInteger num = BigInteger.Parse(Console.ReadLine());
                result = result ^ num;
            }
            Console.WriteLine(result);
        }
    }

