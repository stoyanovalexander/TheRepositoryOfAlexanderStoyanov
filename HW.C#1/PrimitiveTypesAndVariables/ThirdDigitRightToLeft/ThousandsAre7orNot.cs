using System;
    class ThousandsAre7orNot
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int dividedOn100 = number / 100;
            int thousands = dividedOn100 % 10;
            Console.WriteLine(number+": Has 7 thousands: "+(thousands==7));
        }
    }
