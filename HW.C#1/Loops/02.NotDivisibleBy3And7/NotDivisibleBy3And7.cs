using System;
    class NotDivisibleBy3And7
    {
        static void Main()
        {
            Console.Write("Enter biggest number: ");
            uint biggestNumber = uint.Parse(Console.ReadLine());
            for (uint number = 1; number <= biggestNumber; number++)
            {
                if ((number % 3 != 0) || (number % 7 != 0))
                {
                    Console.WriteLine("number: "+number);
                }
            }
        }
    }

