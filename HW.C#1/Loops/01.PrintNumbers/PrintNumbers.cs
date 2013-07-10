using System;
    class PrintNumbers
    {
        static void Main()
        {
            Console.Write("Enter biggest number: ");
            uint biggestNumber = uint.Parse(Console.ReadLine());
            for (uint number = 1; number <= biggestNumber; number++)
            {
                Console.WriteLine("number="+number);
            }
        }
    }

