using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double second = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double third = double.Parse(Console.ReadLine());
            double buffer;
            for (int i = 0; i < 2; i++)
            {
                if (first < second)
                {
                    buffer = second;
                    second = first;
                    first = buffer;
                    if (first < third)
                    {
                        buffer = third;
                        third = first;
                        first = buffer;
                    }
                }
                else
                {
                    if (second < third)
                    {
                        buffer = third;
                        third = second;
                        second = buffer;
                    }
                }
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);

        }
    }
}
