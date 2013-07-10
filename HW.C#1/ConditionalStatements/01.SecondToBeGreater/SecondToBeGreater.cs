using System;
    class SecondToBeGreater
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());
            if (first > second)
            {
                int exchangeVar;
                exchangeVar = first;
                first = second;
                second = exchangeVar;
            }
            Console.WriteLine("first="+first);
            Console.WriteLine("second="+second);
        }
    }
