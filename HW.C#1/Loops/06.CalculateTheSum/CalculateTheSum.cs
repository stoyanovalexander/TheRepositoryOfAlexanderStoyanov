using System;
using System.Numerics;
    class CalculateTheSum
    {
        static void Main()
        {
            Console.Write("Enter first integer n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer x=");
            int x = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Enter bigger value for n");
            }
            else
            {
                double sum = 1 ;
                double factorial = 1;
                double power = 1;
                for (int num = 1; num <= n; num++)
                {
                    factorial = factorial * num;
                    power = power * x;
                    sum = sum + factorial / power;
                }
                Console.WriteLine("sum="+sum);
            }
        }
    }

