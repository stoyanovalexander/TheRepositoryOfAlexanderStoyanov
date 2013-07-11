using System;
using System.Linq;

namespace Task1
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width) 
            : this(width, 0)
        {
        }
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        protected double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        protected double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
