using System;
    class SumOfPNumbers
    {
        static void Main()
        {
            Console.Write("Enter the number of the numbers: ");
            uint numberOfNumbers = uint.Parse(Console.ReadLine());
            double sum=0;
            for (uint i = 0; i < numberOfNumbers; i++)
            {
                Console.Write("Enter number");
                double number = double.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine("sum={0}",sum);
        }
    }
