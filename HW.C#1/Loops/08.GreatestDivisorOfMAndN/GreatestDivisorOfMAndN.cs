using System;
    class GreatestDivisorOfMAndN
    {
        static void Main()
        {
            Console.Write("Enter first number  m=");
            uint m = uint.Parse(Console.ReadLine());
            Console.Write("Enter second number  n=");
            uint n = uint.Parse(Console.ReadLine());
            uint greatestDevisor;
            uint reminder;
            while(n!=0)
            {
                reminder=m%n;
                m=n;
                n=reminder;
            }
            Console.WriteLine("greatestDevisor="+m);
        }
    }
