using System;
using System.IO;
using System.Text;
    class OverwriteWithLineNumber
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("ForOverwriting.txt", Encoding.GetEncoding("UTF-8"));
            using (reader)
            {
                StreamWriter writer = new StreamWriter("OvwriteWithLineNumbers.txt",false,Encoding.GetEncoding("UTF-8"));
                using (writer)
                {
                    string line = reader.ReadLine();
                    int number = 0;
                    while (line != null)
                    {
                        number++;
                        writer.WriteLine(number+" "+line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }

