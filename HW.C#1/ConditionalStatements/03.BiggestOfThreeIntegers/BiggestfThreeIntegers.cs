using System;
    class BiggestfThreeIntegers
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int third = int.Parse(Console.ReadLine());
            int biggest;
            if (first > second)
            {
                biggest = first;
                if (biggest < third)
                {
                    biggest = third;
                }
            }
            else
            {
                biggest = second;
                if (biggest < third)
                {
                    biggest = third;
                }
            }
            Console.WriteLine("biggest="+biggest);
        }
    }
