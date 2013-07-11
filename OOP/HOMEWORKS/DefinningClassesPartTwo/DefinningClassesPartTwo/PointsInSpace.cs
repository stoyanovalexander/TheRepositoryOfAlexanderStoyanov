using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefinningClassesPartTwo;

namespace DefinningClassesPartTwo
{
    class PointsInSpace
    {
        static void Main(string[] args)
        {
            // Task1: StructurePoint3D
            Point3D firstPoint = new Point3D();
            Console.WriteLine(firstPoint);
            Console.WriteLine();

            // Task2: CenterPoint
            Console.WriteLine(Point3D.CenterPoint.ToString());
            Point3D pOne = new Point3D(0, 0, 2);
            Point3D pTwo = new Point3D(4, 3, 4);
            Console.WriteLine( CalculateDistance.CalculateTheDistance(pOne, pTwo));
            Console.WriteLine();

            // Task4: PathAndPathStorage
            Point3D pathPointOne = new Point3D(3, 0, 0);
            Point3D pathPointTwo = new Point3D(5,6,7);
            Point3D pathPointThree = new Point3D(8, 9, 1);
            Path pathToSave = new Path();
            pathToSave.AddPoint(pathPointOne);
            pathToSave.AddPoint(pathPointTwo);
            pathToSave.AddPoint(pathPointThree);
            PathStorage.SavePath(pathToSave);

            List<Path> pathList = PathStorage.LoadPath();
            for (int i = 0; i < pathList.Count;i++ )

                // FORMAT OF THE TEXT FILE IS:
                // 32 33 22
                // 32 33 44
                // NEXT
                // 39 55 44
                // 22 11 55
                // 44 55 66
                // NEXT
                // 44 55 66
                // NEXT
            {
                Console.WriteLine("New Path");
                for (int j = 0; j < pathList[i].Secuence.Count;j++ )
                {
                    Console.WriteLine(string.Format("x:{0,-10} y:{1,-10} z:{2,-10}", pathList[i].Secuence[j].X,
                    pathList[i].Secuence[j].Y,pathList[i].Secuence[j].Z));
                }
       
            }
        }
    }
}
