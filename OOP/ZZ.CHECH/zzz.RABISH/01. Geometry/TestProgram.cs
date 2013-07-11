using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            List<Shape> listOfShapes = new List<Shape>(6);
            listOfShapes.Add(new Rectangle(2, 3));
            listOfShapes.Add(new Triangle(2, 3));
            listOfShapes.Add(new Circle(5));
            listOfShapes.Add(new Rectangle(2.5, 7.6));
            listOfShapes.Add(new Triangle(2.5, 7.6));
            listOfShapes.Add(new Circle(5.5));

            foreach (Shape shape in listOfShapes)
            {
                Console.WriteLine(shape.CalculateArea());
            }

            foreach (Shape shape in listOfShapes)
            {
                Console.WriteLine("*    *    *");
                Console.WriteLine(shape.ToString());
           
            }

        }
    }
}
