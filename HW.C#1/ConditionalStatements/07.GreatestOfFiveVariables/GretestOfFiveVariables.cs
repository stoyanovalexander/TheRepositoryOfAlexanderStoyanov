using System;
    class GretestOfFiveVariables
    {
        static void Main()
        {
            Console.Write("Enter variable  a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter variable  b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter variable  c=");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter variable  d=");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter variable  e=");
            int e = int.Parse(Console.ReadLine());
            int greaterAB;
            int greaterCD;
            int greaterABCD;
            int greatest;
            if (a > b)
            {
                greaterAB = a;
            }
            else 
            {
                greaterAB = b;
            }
            if (c > d)
            {
                greaterCD = c;
            }
            else
            {
                greaterCD = d;
            }
            if (greaterAB > greaterCD)
            {
                greaterABCD = greaterAB;
            }
            else
            {
                greaterABCD = greaterCD;
            }
            if (greaterABCD > e)
            {
                greatest = greaterABCD;
            }
            else
            {
                greatest = e;
            }
            Console.WriteLine("greatest="+greatest);
        }
    }
