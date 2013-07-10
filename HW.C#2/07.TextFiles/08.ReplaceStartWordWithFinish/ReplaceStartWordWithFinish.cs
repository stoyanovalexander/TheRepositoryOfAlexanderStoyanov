using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
class ReplaceStartWithFinish
{
    static void Main()
    {
        StreamReader reader = new StreamReader("FileWithStarts.txt", Encoding.GetEncoding("UTF-8"));
        StreamWriter writer = new StreamWriter("FileWithFinishes.txt", false, Encoding.GetEncoding("UTF-8"));
        using (reader)
        {
            using (writer)
            {
                string theStartString = @"\b(start)\b";
                Regex startWord = new Regex(theStartString);
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    string newLine = startWord.Replace(line, "finish");
                    writer.WriteLine(newLine);
                }
            }
        }
        File.Delete("FileWithStarts.txt");
        File.Move("FileWithFinishes.txt", "FileWithStarts.txt");
    }
}

