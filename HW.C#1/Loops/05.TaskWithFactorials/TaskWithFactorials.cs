using System;
using System.Numerics;
    class TaskWithFactorials
    {
        static void Main()
        {
            Console.Write("Enter n=");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("Enter k=");
            uint k = uint.Parse(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("Enter bigger value of n");
            }
            else if(k<=n)
            {
                Console.WriteLine("Enter bigger value of k");
            }
            BigInteger result = 1; // result=n!*k!/(k-n)!=n!*k*(k-1)*(k-2)*...(k-n+1)
            for (uint multiplierFromN = 1, multiplierFromK = k; multiplierFromN <= n; multiplierFromN++, multiplierFromK--)
// result=(1*k)*(2*(k-1))*(3*(k-2))*...(n*(k-n+1))   (1,2,3...n->multiplierFromN)  (k,(k-1),(k-2)...(k-n+1)->multiplierFromK)
            {
                result = result * multiplierFromN * multiplierFromK;                
            }
            Console.WriteLine("n!*k!/(k-n)!="+result);
        }
    }
