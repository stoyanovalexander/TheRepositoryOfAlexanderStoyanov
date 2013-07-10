using System;
using System.Text;
using System.IO;
    class CompareFilesLineByLine
    {
        static void Main()
        {
            StreamReader firstReader = new StreamReader("FirstForCompare.txt",Encoding.GetEncoding("UTF-8"));
            StreamReader secondReader = new StreamReader("SecondForCompare.txt",Encoding.GetEncoding("UTF-8"));
            using (firstReader)
            {
                using (secondReader)
                {
                    string firstLine = firstReader.ReadLine();
                    string secondLine = secondReader.ReadLine();
                    int same = 0;
                    int diffrent = 0;
                    while ((firstLine != null) && (secondLine != null))
                    {
                        if (firstLine == secondLine)
                        {
                            same++;
                        }
                        else
                        {
                            diffrent++;
                        }
                        firstLine = firstReader.ReadLine();
                        secondLine = secondReader.ReadLine();
                    }
                    Console.WriteLine("same="+same);
                    Console.WriteLine("diffrent="+diffrent);
                }
            }
        }
    }

