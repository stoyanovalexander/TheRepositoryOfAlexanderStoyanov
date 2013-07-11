using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class InTriangleOrNot
{
    static void Main(string[] args)
    {
        Console.Write("x1=");
        double x1 =double.Parse(Console.ReadLine());
        Console.Write("y1=");
        double y1 =double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("x2=");
        double x2 =double.Parse(Console.ReadLine());
        Console.Write("y2=");
        double y2 =double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("x3=");
        double x3 =double.Parse(Console.ReadLine());
        Console.Write("y3=");
        double y3 =double.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Px=");
        double Px =double.Parse(Console.ReadLine());
        Console.Write("Py=");
        double Py = double.Parse(Console.ReadLine());


        double dx = (Px - x3);
        double dy = (Py - y3);

        double A = x1 - x3;
        double B = y1 - y3;
        double C = x2 - x3;
        double D = y2 - y3;

        double denom = A * D - B * C;

        double alpha = D * dx - C * dy;
        alpha /= denom;

        double beta = -B * dx + A * dy;
        beta /= denom;

        double gamma = 1.0 - (alpha + beta);

        Console.WriteLine();
        if (alpha >= 0 && beta >= 0 && gamma >= 0)
        {
            Console.WriteLine("Point({0},{1}) is IN triangle[({2},{3}), ({4},{5}), ({6},{7})]", Px, Py, x1, y1, x2, y2, x3, y3);
        }

        else
        {
            Console.WriteLine("Point({0},{1}) is OUT OFF triangle[({2},{3}), ({4},{5}), ({6},{7})]", Px, Py, x1, y1, x2, y2, x3, y3);
        }
    }
}

 
