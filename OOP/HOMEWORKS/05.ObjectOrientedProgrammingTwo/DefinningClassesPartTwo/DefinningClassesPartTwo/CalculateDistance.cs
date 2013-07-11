using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinningClassesPartTwo
{
    static class CalculateDistance
    {
        //Task3: CalculateTheDistance
        public static double CalculateTheDistance(Point3D first, Point3D second)
        {
            double distance = Math.Sqrt((first.X - second.X) * (first.X - second.X)
                + (first.Y - second.Y) * (first.Y - second.Y)+(first.Z - second.Z) * (first.Z - second.Z));
            return distance;
        }
    }
}
