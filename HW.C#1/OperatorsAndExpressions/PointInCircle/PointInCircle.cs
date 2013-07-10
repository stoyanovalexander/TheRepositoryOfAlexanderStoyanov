using System;
class PointInCercle
{
    static void Main()
    {
        Console.WriteLine("Enter height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter width: ");
        double width = double.Parse(Console.ReadLine());
        double pointRadiusOn2 = (height * height) + (width * width);
        ulong circleRadiusOn2 = 25;
        Console.WriteLine("The point is in the circle k(0,5): " + (circleRadiusOn2 >= pointRadiusOn2));
    }
}
