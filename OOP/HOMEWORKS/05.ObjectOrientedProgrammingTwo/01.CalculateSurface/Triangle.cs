using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CalculateSurface
{

    public class Triangle : Shapes
    {
        public Triangle(int width, int height) : base(width, height) { }
        public override void CalculateSurface()
        {
            Console.WriteLine(this.Width*this.Height/2);
        }
    }
}
