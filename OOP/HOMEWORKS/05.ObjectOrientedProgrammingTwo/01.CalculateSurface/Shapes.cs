using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CalculateSurface
{

    public abstract class Shapes
    {
        public int Width { get; set; }
        public int Height { get; set; }
        //public Shapess(int width)
        //{
        //    this.Width = width;
        //}

        public Shapes(int widht, int height)
        {
            this.Width = widht;
            this.Height = height;
        }
        public Shapes(int height)
        {
            this.Width = height;
        }
        public abstract void CalculateSurface();

    }
}
