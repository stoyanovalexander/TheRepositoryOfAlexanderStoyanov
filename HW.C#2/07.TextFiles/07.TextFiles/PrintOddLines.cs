using System;
using System.IO;
using System.Text;
    class PrintOddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("01.PrintOddLines.txt",Encoding.GetEncoding("UTF-8"));
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine();
                    if ((lineNumber % 2) == 0)
                    {
                        line = reader.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }

