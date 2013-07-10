using System;
    class Exchange
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);
        }
    }
