using System;
using System.Numerics;
    class FactorialsDivide
    {
        static void Main()
        {
            Console.Write("Enter n=");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("Enter k=");
            uint k = uint.Parse(Console.ReadLine());
            if (n < 3)
            {
                Console.WriteLine("Enter bigger value of n");
            }
            else if (k < 2)
            {
                Console.WriteLine("Enter bigger value of k");
            }
            else if (k >= n)
            {
                Console.WriteLine("Enter k<n");
            }
            else
            {
                BigInteger nFactDivKFact = 1;
                for (uint betweenKAndN = k + 1; betweenKAndN <= n; betweenKAndN++) // n!/k1=(k+1)*(k+2)*...n
                {
                    nFactDivKFact = nFactDivKFact * betweenKAndN;
                }
                Console.WriteLine("n!/k!=" + nFactDivKFact);
            }
        }
    }

