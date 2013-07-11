using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    abstract class Shape : IShape
    {
        protected double width;
        protected double height;

        public abstract double Height { get; protected set; }

        public abstract double Width { get; protected set; }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateArea();

        public override string ToString()
        {
            return string.Format("{0}\nWidth: {1}\nHeight: {2}\nArea: {3}", this.GetType(), this.Width, this.Height, this.CalculateArea());
        }
    }
}