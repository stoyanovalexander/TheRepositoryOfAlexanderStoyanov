using System;
    class Numbers1ToN
    {
        static void Main()
        {
            Console.Write("Enter number greater than 1: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 2) 
            {
                Console.Write("Enter other int number greater than 1!!!: ");
                 number = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
