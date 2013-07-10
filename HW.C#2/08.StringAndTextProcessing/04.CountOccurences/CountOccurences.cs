using System;
using System.Text;
using System.Collections.Generic;
    class CountOccurences
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string text = Console.ReadLine();
            text = text.ToLower();
            string lookFor = Console.ReadLine();
            lookFor = lookFor.ToLower();
            int startIndex=0;
            int occurenceIndex=0;
            int count=0;
            while (true)
            {
                occurenceIndex = text.IndexOf(lookFor, startIndex);
                if (occurenceIndex == -1)
                {
                    break;
                }
                else
                {
                    startIndex = occurenceIndex + lookFor.Length;
                    count++;
                }
            }
            Console.WriteLine("The result is: "+count);
        }
    }

