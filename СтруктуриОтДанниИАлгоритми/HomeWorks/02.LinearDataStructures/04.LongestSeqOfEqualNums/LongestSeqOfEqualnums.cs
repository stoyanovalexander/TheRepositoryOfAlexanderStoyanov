using System;
using System.Collections.Generic;
using System.Linq;

    class LongestSeqOfEqualnums
    {
        static List<int> FindLongestSequence(List<int> theNumbers)
        {
            int len = 1;
            int bestLen = 0;
            int bestNumber = 0;
            for (int i = 0; i < theNumbers.Count - 1; i++)
            {
                if (theNumbers[i] == theNumbers[i + 1])
                {
                    len++;
                }
                else
                {
                    if (len > bestLen)
                    {
                        bestNumber = theNumbers[i];
                        bestLen = len;
                    }
                    len = 1;
                }
            }

            if (len > bestLen)
            {
                bestLen = len;
                bestNumber = theNumbers[theNumbers.Count - 1];
            }

            List<int> longestSequence=new List<int>();
            for (int i = 0; i < bestLen; i++)
            {
                longestSequence.Add(bestNumber);
            }

            return longestSequence;
        }

        static void Main()
        {
            Console.Write("Enter the of the numbers in the List(positive one): ");
            int length = int.Parse(Console.ReadLine());
            List<int> enteredNumbers = new List<int>();

            // Fill the input List
            for (int i = 0; i < length; i++)
            {
                Console.Write("Some number: ");
                int theEnteredNumber = int.Parse(Console.ReadLine());
                enteredNumbers.Add(theEnteredNumber);
            }

            List<int> longestSequence = FindLongestSequence(enteredNumbers);

            // Print the result on the console
            Console.Write("{");
            for (int i = 0; i < length - 1; i++)
            {
                Console.Write(enteredNumbers[i] + ",");
            }
            Console.Write(enteredNumbers[length - 1] + "}→{");

            for (int i = 0; i < longestSequence.Count - 1; i++)
            {
                Console.Write(longestSequence[i] + ",");
            }
            Console.Write(longestSequence[longestSequence.Count-1] + "}");
            Console.WriteLine();

        }
    }

