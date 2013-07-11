using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Triangle : Shape
    {
        public override double Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height has to be positive double");
                }
                this.height = value;
            }
        }
        public override double Width
        {
            get
            {
                return this.width;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width has to be positive double");
                }
                this.width = value;
            }
        }

        public Triangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return ((this.Height * this.Width) / 2);
        }
    }
}