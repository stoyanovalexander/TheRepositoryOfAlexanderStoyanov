using System;
using System.Text;
using System.IO;
    class ConcatenateFiles
    {
        static void Main()
        {
            StreamReader readerOne = new StreamReader("02.FileOne.txt",Encoding.GetEncoding("UTF-8"));
            StreamReader readerTwo = new StreamReader("02.FileTwo.txt", Encoding.GetEncoding("UTF-8"));
            // Read first one and write it in the third one
            using (readerOne)
            {
                StreamWriter writeOne = new StreamWriter("02.Concatenation.txt", false, Encoding.GetEncoding("UTF-8"));
                using (writeOne)
                {
                    string line = readerOne.ReadLine();
                    while (line != null)
                    {
                        writeOne.WriteLine(line);
                        line = readerOne.ReadLine();
                    }
                }
            }
            // Read second one and add it to third one where first one is already overwrited
            using (readerTwo)
            {
                StreamWriter writeTwo = new StreamWriter("02.Concatenation.txt", true, Encoding.GetEncoding("UTF-8"));
                using (writeTwo)
                {
                    string line = readerTwo.ReadLine();
                    while (line != null)
                    {
                        writeTwo.WriteLine(line);
                        line = readerTwo.ReadLine();
                    }
                }
            }
        }
    }

