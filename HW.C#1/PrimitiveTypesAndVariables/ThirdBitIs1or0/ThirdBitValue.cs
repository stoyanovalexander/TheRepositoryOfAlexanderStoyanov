using System;
    class ThirdBitValue
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int mask = 1<<3;
            int result = number & mask;
            Console.WriteLine(0+" :is the third bit of: "+number+" "+(result==0));
        }
    }
