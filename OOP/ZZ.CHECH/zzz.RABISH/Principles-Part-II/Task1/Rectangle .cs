using System;
using System.Linq;

namespace Task1
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height) 
        {
        } 

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
