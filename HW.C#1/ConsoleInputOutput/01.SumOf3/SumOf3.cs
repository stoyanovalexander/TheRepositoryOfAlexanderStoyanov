using System;
    class SumOf3
    {
        static void Main()
        {
            Console.Write("Enter first int: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second int: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third int: ");
            int c = int.Parse(Console.ReadLine());
            long sum = a + b + c;
            Console.WriteLine("sum="+sum);
        }
    }

