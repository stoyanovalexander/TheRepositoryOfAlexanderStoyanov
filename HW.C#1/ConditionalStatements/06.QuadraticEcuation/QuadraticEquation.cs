using System;
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Enter coefficient: a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficent: b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter coefficient: c=");
            double c = double.Parse(Console.ReadLine());
            double discreet = b * b - 4 * a * c;
            if (discreet >= 0)
            {
                double realRoot1 = (-b + Math.Sqrt(discreet)) / (2 * a);
                double realRoot2 = (-b - Math.Sqrt(discreet)) / (2 * a);
                Console.WriteLine("realRoot1={0}, realRoot2={1}", realRoot1, realRoot2);
            }
            else
            {
                Console.WriteLine("There no real roots");
            }
        }
    }

