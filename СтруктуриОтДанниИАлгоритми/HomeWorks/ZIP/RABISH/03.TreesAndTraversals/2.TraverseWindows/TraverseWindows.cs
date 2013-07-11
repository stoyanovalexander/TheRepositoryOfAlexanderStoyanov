using System;
using System.IO;

namespace TraverseDirectory
{
    public class TraverseWindows
    {
        static void Main()
        {

            string directory = @"C:\WINDOWS";

            DirSearch(directory);
        }

        private static void DirSearch(string directory)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(directory))
                {
                    foreach (string f in Directory.GetFiles(dir, "*.exe"))
                    {
                        Console.WriteLine(f);
                    }

                    DirSearch(dir);
                }
            }

            catch (System.UnauthorizedAccessException excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}