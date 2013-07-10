using System;
using System.Numerics;
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger trib1 = BigInteger.Parse(Console.ReadLine());
            BigInteger trib2 = BigInteger.Parse(Console.ReadLine());
            BigInteger trib3 = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            BigInteger newTrib = 0;

            if (n == 1)
            {
                Console.WriteLine(trib1);
            }
            else if (n == 2)
            {
                Console.WriteLine(trib2);
            }
            else if (n == 3)
            {
                Console.WriteLine(trib3);
            }
            else
            {
                for (int i = 4; i <= n; i++)
                {
                    newTrib = trib1 + trib2 + trib3;
                    trib1 = trib2;
                    trib2 = trib3;
                    trib3 = newTrib;
                }
                Console.WriteLine(newTrib);
            }
        }
    }

