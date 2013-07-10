using System;
class RectanglesArea
{
    static void Main()
    {
        Console.WriteLine("Enter the height:");
        double height = double.Parse(Console.ReadLine());
        if (height <= 0)
        {
            Console.WriteLine("Enter other  height>0");
        }
        else
        {
            Console.WriteLine("Enter the width:");
            double width = double.Parse(Console.ReadLine());
            if (width <= 0)
            {
                Console.WriteLine("Enter other  width>0");
            }
            else
            {
                double area = height * width;
                Console.WriteLine("area=" + area);
            }
        }
    }
}
