using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
class DelWordsWithPrefixText
{
    static void Main()
    {
        StreamReader reader = new StreamReader("PrefixText.txt", Encoding.GetEncoding("UTF-8"));
        StreamWriter writer = new StreamWriter("NoMorePrefixText.txt", false, Encoding.GetEncoding("UTF-8"));
        using (reader)
        {
            using (writer)
            {
                string pattern = @"\b(text)\w*\b";
                Regex word = new Regex(pattern);
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    string newLine = word.Replace(line,string.Empty);
                    writer.WriteLine(newLine);
                }
            }
        }
        File.Delete("PrefixText.txt");
        File.Move("NoMorePrefixText.txt", "PrefixText.txt");
    }
}