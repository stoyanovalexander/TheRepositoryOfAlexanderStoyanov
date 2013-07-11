using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinningClassesPartTwo
{
    //Task4
    public class Path
    {
        public List<Point3D> sequence=new List<Point3D>();

        public List<Point3D> Secuence
        {
            get {return this.sequence; }
            set { this.sequence = value; }
        }

        public void AddPoint(Point3D point)
        {
            
            sequence.Add(point);
        }
    }
}
