using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Circle:Shape
    {
        public override double Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                if (value <=0)
                {
                    throw new ArgumentOutOfRangeException("Diameter myst be postive double!");
                }
                this.width = value;
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
                if (value <= 0 )
                {
                    throw new ArgumentOutOfRangeException("Diameter must be positive double!");
                }
                this.width = value;
                this.height = value;
            }
        }

        public Circle(double diameter):base(diameter,diameter)
        {
        }

        public override double CalculateArea()
        {
            return ((Math.PI * this.Width * this.Width) / 4);
        }
        public override string ToString()
        {
            return string.Format("{0}\nDiametre: {1}\nArea: {2}", this.GetType(), this.Height, this.CalculateArea());
        }
    }
}
