using System;
    class MinAndMaxNumber
    {
        static void Main()
        {
            Console.Write("The number of the numbers: ");
            int numberOfNumbers = int.Parse(Console.ReadLine());
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            for (uint position = 1; position <= numberOfNumbers; position++)
            {
                Console.Write(" ");
                    int number = int.Parse(Console.ReadLine());
                    if (number >= max)
                    {
                        max = number;
                    }
                    if (number <= min)
                    {
                        min = number;
                    }
            }
            Console.WriteLine("min={0},  max={1}",min,max);
        }
    }

