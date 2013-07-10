using System;
    class DividedOn7And5
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            byte check = (byte)(number % 35);
            Console.WriteLine(number+" : Can be divided on 5 and 7: "+(check==0));
        }
    }
