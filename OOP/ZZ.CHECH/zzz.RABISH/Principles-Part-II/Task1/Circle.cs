using System;
using System.Linq;

namespace Task1
{
    public class Circle : Shape
    {
        public Circle(double radius)
            : base(radius) 
        {
        } 

        public override double CalculateSurface()
        {
            return this.Width * 2 *  Math.PI;
        }
    }
}
