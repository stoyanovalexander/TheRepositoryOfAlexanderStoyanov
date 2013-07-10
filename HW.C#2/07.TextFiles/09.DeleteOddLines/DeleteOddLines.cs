using System;
using System.IO;
using System.Text;
class ReplaceStartWithFinish
{
    static void Main()
    {
        StreamReader reader = new StreamReader("FileWithOddLines.txt", Encoding.GetEncoding("UTF-8"));
        StreamWriter writer = new StreamWriter("FileWithoutOddLines.txt", false, Encoding.GetEncoding("UTF-8"));
        using (reader)
        {
            using (writer)
            {
                int counter = 0;
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    counter++;
                    if ((counter % 2) == 0)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }
        File.Delete("FileWithOddLines.txt");
        File.Move("FileWithoutOddLines.txt", "FileWithOddLines.txt");
    }
}

