using System;
using System.Text;
using System.Security;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader("FileWithSomeWords.txt",Encoding.GetEncoding("UTF-8"));
                StreamWriter writer = new StreamWriter("NumberOfRepeating.txt", false, Encoding.GetEncoding("UTF-8"));
                string[] words = File.ReadAllLines("WordsForCheck.txt");
                int[] occurences = new int[words.Length];
                using (reader)
                {
                    using (writer)
                    {
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            for (int i = 0; i < words.Length; i++)
                            {
                                occurences[i] += Regex.Matches(line, "\\b" + words[i] + "\\b").Count;

                            }
                            line = reader.ReadLine();
                        }
                        Array.Sort(occurences, words);
                        for (int i = words.Length - 1; i >= 0; i--)
                        {
                            writer.WriteLine(occurences[i] + " : " + words[i]);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("This file is not found");
            }
            catch (DirectoryNotFoundException)
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

