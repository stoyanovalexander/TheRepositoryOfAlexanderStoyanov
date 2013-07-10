using System;
    class PrintGreater
    {
        static void Main()
        {
            Console.Write("Enter first number: a=");
            int a =int.Parse(Console.ReadLine());
            Console.Write("Enter second number: b=");
            int b = int.Parse(Console.ReadLine());
            int greater = a > b ? a : b;
            Console.WriteLine("greater="+greater);
        }
    }

