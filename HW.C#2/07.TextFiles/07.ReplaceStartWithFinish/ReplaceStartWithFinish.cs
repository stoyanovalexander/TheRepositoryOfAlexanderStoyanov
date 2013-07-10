using System;
using System.IO;
using System.Text;
    class ReplaceStartWithFinish
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("FileWithStarts.txt",Encoding.GetEncoding("UTF-8"));
            StreamWriter writer = new StreamWriter("FileWithFinishes.txt",false,Encoding.GetEncoding("UTF-8"));
            using (reader)
            {
                using (writer)
                {
                    for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                    {
                        string newLine = line.Replace("start", "finish");
                        writer.WriteLine(newLine);
                    }
                }
            }
            File.Delete("FileWithStarts.txt");
            File.Move("FileWithFinishes.txt", "FileWithStarts.txt");
        }
    }

