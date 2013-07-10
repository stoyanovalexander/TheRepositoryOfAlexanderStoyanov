using System;
class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter the height: ");
        double h = double.Parse(Console.ReadLine());
        if (h <= 0)
        {
            Console.WriteLine("Enter other  h>0");
        }
        else
        {
            Console.WriteLine("Enter the first side: ");
            double a = double.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Ënter other  a>0");
            }
            else
            {
                Console.WriteLine("Enter the seconde side: ");
                double b = double.Parse(Console.ReadLine());
                if (b <= 0)
                {
                    Console.WriteLine("Enter other  b>0");
                }
                else
                {
                    double area = (h * (a + b)) / 2;
                    Console.WriteLine("area=" + area);
                }
            }
        }
    }
}

