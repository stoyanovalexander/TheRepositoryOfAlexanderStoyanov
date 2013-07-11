using System;
using System.Collections.Generic;
using System.Linq;

    class NumbersOccurencesCount
    {
        static int[] CountOccurences(int[] enteredArray)
        {
            int[] occurencesCounter = new int[1001];
            for (int i = 0; i < enteredArray.Length; i++)
            {
                for (int j = 0; j < occurencesCounter.Length; j++)
                {
                    if (enteredArray[i] == j)
                    {
                        occurencesCounter[j]++;
                    }
                }
            }

            return occurencesCounter;
        }

        static void Main()
        {
            // Fill the array
            Console.Write("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] theArray = new int[length]; 

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter some number: ");
                theArray[i] = int.Parse(Console.ReadLine());

            }

            int[] occurencesCounter = CountOccurences(theArray);

            // Print the result
            Console.WriteLine();

            for (int i = 0; i < occurencesCounter.Length; i++)
            {
                if (occurencesCounter[i] != 0)
                {
                    Console.WriteLine("{0}→{1}times",i,occurencesCounter[i]);
                }
            }
        }
    }

