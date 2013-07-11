using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CalculateSurface
{
    public class Circle : Shapes
    {

        public Circle(int height) : base(height) { }
        public override void CalculateSurface()
        {
            Console.WriteLine(Math.PI*this.Width*2);
        }
    }
}
