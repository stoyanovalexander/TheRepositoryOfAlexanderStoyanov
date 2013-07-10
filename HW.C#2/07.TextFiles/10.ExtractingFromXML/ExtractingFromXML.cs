using System;
using System.IO;
using System.Text;
    class ExtractingFromXML
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("FileToExtractFrom.xml", Encoding.GetEncoding("UTF-8"));
            using (reader)
            {
                bool charToWrite = false;
                int charCode = reader.Read();
                while (charCode != -1)
                {
                    if (charCode == '\n' )//|| charCode == '\r')
                    {
                        Console.WriteLine();
                    }
                    if (charCode == '>')
                    {
                        charToWrite = true;
                    }
                    if (charCode == '<')
                    {
                        charToWrite = false;
                    }
                    if ((charCode != '>') && charToWrite && (charCode != '\n') && (charCode != '\r'))
                    {
                        Console.Write( (char)charCode);
                    }
                    charCode = reader.Read();
                }
                Console.WriteLine();

            }
        }
    }

