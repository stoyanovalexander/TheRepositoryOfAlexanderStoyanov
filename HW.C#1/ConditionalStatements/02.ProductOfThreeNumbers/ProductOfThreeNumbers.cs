using System;
    class ProductOfThreeNumbers
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int third = int.Parse(Console.ReadLine());
            if ((first == 0) || (second == 0) || (third == 0))
            {
                Console.WriteLine("The sign of the product is: +");
            }
            if ((first > 0) && (second > 0) && (third > 0))
            {
                Console.WriteLine("The sign of the product is: +");
            }
            if ((first > 0) && (second > 0) && (third < 0))
            {
                Console.WriteLine("The sign of the product is: -");
            }
            if ((first > 0) && (second < 0) && (third > 0))
            {
                Console.WriteLine("The sign of the product is: -");
            }
            if ((first > 0) && (second < 0) && (third < 0))
            {
                Console.WriteLine("The sign of the product is: +");
            }
            if ((first < 0) && (second > 0) && (third > 0))
            {
                Console.WriteLine("The sign of the product is: -");
            }
            if ((first < 0) && (second > 0) && (third < 0))
            {
                Console.WriteLine("The sign of the product is: +");
            }
            if ((first < 0) && (second < 0) && (third > 0))
            {
                Console.WriteLine("The sign of the product is: +");
            }

            if ((first < 0) && (second < 0) && (third < 0))
            {
                Console.WriteLine("The sign of the product is: -");
            }
        }
    }