using System;
    class First100Fibonacci
    {
        static void Main()
        {
            double a = 0;
            double b = 1;
            Console.WriteLine("{0,3}: {1,22}",1,a);
            Console.WriteLine("{0,3}: {1,22}",2,b);
            for(byte i=3;i<=100;i++)
            {
                double c=a+b;
                Console.WriteLine("{0,3}: {1,22}",i,c);
                a=b;
                b=c;
            }
        }
    }