namespace _01.CalculateSurface{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class CalculateSurfaceTest
    {
        static void Main(string[] args)
        {
            Shapes[] someFigures =
            {
                new Triangle(10,15),
                new Triangle(10,5),
                new Rectangle(15,5),
                new Rectangle(5,5),
                new Circle(10),
                new Circle(5),
            };
            foreach (var figure in someFigures)
            {
                figure.CalculateSurface();
            }
        }
    }
}
