using System;
    class TrapezoidArea
    {
        static void Main()
        {
            Console.WriteLine("Enter the height: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first side: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seconde side: ");
            double b = double.Parse(Console.ReadLine());
            double area = (h * (a + b)) / 2;
            Console.WriteLine("area="+area);
        }
    }
