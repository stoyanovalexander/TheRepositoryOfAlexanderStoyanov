using System;
class InCircleOutRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        double distanceToCenter = (x - 1) * (x - 1) + (y - 1) * (y - 1);
        bool inCircle = (distanceToCenter <= 9);
        bool overRectangle = (x > 1);
        bool underRectangle = (x < -1);
        bool leftRectangle = (y < -1);
        bool outRectangle = overRectangle || underRectangle || leftRectangle;
        Console.WriteLine("The point is in circle k((1,1),3) and out of rectangle((-1,-1),(5,1)) : " + (inCircle && outRectangle));
    }
}
