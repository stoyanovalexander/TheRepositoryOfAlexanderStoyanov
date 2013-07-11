using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTry
{
    class Point
    {
        private int xCoord;
        private int yCoord;
        private string name;

        public Point():this(0,0)
        {}
        public Point(int xCoord,int yCoord)
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
            this.name = string.Format("Point({0},{1})",xCoord,yCoord);
        }
        public int XCoord
        {
            get { return this.xCoord; }
            set { this.xCoord = value; }
        }
        public int YCoord
        {
            get { return this.yCoord; }
            set { this.yCoord = value; }
        }
        public string Name
        {
            get { return this.name;}
            set { this.name = value;  }
        }

        // METHODS
      public double CalculateDistance(Point p)
            {
                return Math.Sqrt( (p.xCoord-this.xCoord)*(p.xCoord-this.xCoord)+(p.yCoord-this.yCoord)*(p.yCoord-this.yCoord) );
            }
        }
    }

