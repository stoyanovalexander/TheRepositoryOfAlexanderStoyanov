using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DefinningClassesPartTwo
{
    // Task4: PathAndPathStorage
    public static class PathStorage
    {
        public static void SavePath(Path path)
        {
            StreamWriter writer = new StreamWriter("FileWithPath.txt", false, Encoding.GetEncoding("UTF-8"));
            using(writer)
            {
                for (int i = 0; i < path.Secuence.Count;i++ )
                {
                    writer.WriteLine(string.Format("x:{0} y:{1} z:{2}", path.Secuence[i].X ,path.Secuence[i].Y
                                                                                         ,path.Secuence[i].Z));
                }
            }
        }
        
        public static List<Path> LoadPath()
        {
            StreamReader reader = new StreamReader("LoadFromThis.txt",Encoding.GetEncoding("UTF-8"));
            Path loadPath = new Path();
            List<Path> pathsLoaded = new List<Path>();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (line != "NEXT")
                    {
                        Point3D point = new Point3D();
                        string[] points = line.Split(' ');
                        point.X = int.Parse(points[0]);
                        point.Y = int.Parse(points[1]);
                        point.Z = int.Parse(points[2]);
                        loadPath.AddPoint(point);
                    }
                    else
                    {
                        pathsLoaded.Add(loadPath);
                        loadPath = new Path();
                    }
                    line = reader.ReadLine();
                }
            }
            return pathsLoaded;
        }
    }
}
