using System;
    class BetweenAandBdividedOn5
    {
        static void Main()
        {
            Console.Write("Enter first uint number: ");
            uint a = uint.Parse(Console.ReadLine());
            Console.Write("Enter second uint number: ");
            uint b = uint.Parse(Console.ReadLine());
            if (a > b)
            {
                uint c = a;
                a = b;
                b = c;
            }
            uint counter=0;
            byte reminder;
            for (uint i = a; i <= b; i++)
            {
                reminder = (byte)(i % 5);
                if (reminder == 0)
                {
                    counter = counter + 1;
                }
            }
            Console.WriteLine("Numbers divided on 5: p[{0},{1}]={2}", a, b, counter);
        }
    }

