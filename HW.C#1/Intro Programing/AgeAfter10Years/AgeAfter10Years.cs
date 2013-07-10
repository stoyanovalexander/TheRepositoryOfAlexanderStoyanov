using System;
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.Write("My age now is: ");
            int myage = int.Parse(Console.ReadLine());
            int futureage = myage+10;
            Console.WriteLine("my age after 10 years will be: "+futureage);
        }
    }

