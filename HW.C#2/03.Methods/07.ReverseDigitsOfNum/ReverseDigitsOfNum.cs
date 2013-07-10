using System;
    class ReverseDigitsOfNum
    {
        static void ReverseDigits(int num)
        {
            int reminder = 0;
            while(num!=0)
            {
                reminder = num % 10;
                num = num / 10;
                Console.Write(reminder);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter someNum= ");
            int someNum = int.Parse(Console.ReadLine());
            Console.Write(someNum + "→");
            ReverseDigits(someNum);
            Console.WriteLine();
        }
    }

