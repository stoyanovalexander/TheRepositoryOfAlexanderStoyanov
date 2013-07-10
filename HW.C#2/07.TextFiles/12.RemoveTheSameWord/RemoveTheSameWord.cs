using System;
using System.Text;
using System.Security;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
    class RemoveTheSameWord
    {
        static void Main()
        {
            try
            {
                StreamReader reader = new StreamReader("FileWithWords.txt", Encoding.GetEncoding("UTF-8"));
                StreamWriter writer = new StreamWriter("WithoutTheSame.txt", false, Encoding.GetEncoding("UTF-8"));
                string allWords = String.Join(" ", File.ReadAllLines("WordsForCheck.txt"));
                string[] allWordsForCheck = allWords.Split(' ');
                using (reader)
                {
                    using (writer)
                    {
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            for (int i = 0; i < allWordsForCheck.Length; i++)
                            {
                                string word = "\\b" + allWordsForCheck[i] + "\\b";
                                line = Regex.Replace(line, word,"");
                            }
                            writer.WriteLine(line);
                            line = reader.ReadLine();
                        }
                    }
                }
                File.Delete("FileWithWords.txt");
                File.Move("WithoutTheSame.txt", "FileWithWords.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("This file is not found");
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("This directory is not found");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SecurityException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

