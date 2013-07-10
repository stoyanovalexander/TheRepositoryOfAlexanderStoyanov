using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
    class SortStrings
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("UnsortedStrings.txt",Encoding.GetEncoding("UTF-8"));
            StreamWriter writer = new StreamWriter("SortedStrings.txt",false,Encoding.GetEncoding("UTF-8"));
            using (reader)
            {
                List<string> lines = new List<string>();
                string line = reader.ReadLine();
                while (line != null)
                {
                    lines.Add(line);
                    line = reader.ReadLine();
                }
                lines.Sort();
                using (writer)
                {
                    for (int i = 0; i < lines.Count; i++)
                    {
                        writer.WriteLine(lines[i]);
                    }
                }
            }
        }
    }

