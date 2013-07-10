
using System;
    class OddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int oddOrEven = int.Parse(Console.ReadLine());
            byte check = (byte)(oddOrEven % 2);
            if (check == 1)
            {
                Console.WriteLine(oddOrEven + " is odd");
            }
            else
            {
                Console.WriteLine(oddOrEven+" is even");
            }
        }
    }
