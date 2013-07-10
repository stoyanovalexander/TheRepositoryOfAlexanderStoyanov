using System;
    class ProgramCirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * radius * Math.PI;
            double area = radius * radius * Math.PI;
            Console.WriteLine("Perimeter="+perimeter);
            Console.WriteLine("area="+area);
        }
    }

