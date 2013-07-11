using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CalculateSurface
{

    public class Rectangle : Shapes
    {
        public Rectangle(int width, int height) : base(width, height) { }
        public override void CalculateSurface()
        {
            Console.WriteLine(this.Height * this.Width);
        }

    }
}
