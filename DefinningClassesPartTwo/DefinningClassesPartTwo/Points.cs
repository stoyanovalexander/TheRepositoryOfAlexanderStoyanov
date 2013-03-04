using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Point3D
{
    // Task1: StructurePoint3D
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public override string ToString()
    {
        return string.Format("{0},{1},{2}", X, Y, Z);
    }
    // Task2: CenterPoint
    public Point3D(int x, int y, int z) : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public static readonly Point3D CenterPoint = new Point3D(0, 0, 0);
}

