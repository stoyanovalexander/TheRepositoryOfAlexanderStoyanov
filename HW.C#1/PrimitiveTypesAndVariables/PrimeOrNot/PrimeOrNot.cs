using System;
    class PrimeOrNot
    {
        static void Main()
        {
            Console.WriteLine("Enter a number (0,100]: ");
            int num = int.Parse(Console.ReadLine());
            int onTwo = num % 2;
            int onThree = num % 3;
            int onFive = num % 5;
            int onSeven = num % 7;
            bool prime = (onTwo != 0) && (onThree != 0) && (onFive != 0) && (onSeven != 0);
            Console.WriteLine(num+" : is prime : "+prime);
        }
    }
