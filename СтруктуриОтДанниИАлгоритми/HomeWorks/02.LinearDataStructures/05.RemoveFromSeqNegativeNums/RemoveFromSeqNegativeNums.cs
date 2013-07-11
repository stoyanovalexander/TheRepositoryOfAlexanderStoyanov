using System;
using System.Collections.Generic;
using System.Linq;

    class RemoveFromSeqNegativeNums
    {
        static List<int> RemoveNegativeNumbers(List<int> theNumbers)
        {
            List<int> onlyPositiveNums=new List<int>();

            for (int i = 0; i < theNumbers.Count; i++)
            {
                if (theNumbers[i] >= 0)
                {
                    onlyPositiveNums.Add(theNumbers[i]);
                }
            }

            return onlyPositiveNums;
        }

        static void Main()
        {
            Console.Write("Enter the number of the numbers in the List(positive one): ");
            int length = int.Parse(Console.ReadLine());
            List<int> enteredNumbers = new List<int>();

            // Fill the input List
            for (int i = 0; i < length; i++)
            {
                Console.Write("Some number: ");
                int theEnteredNumber = int.Parse(Console.ReadLine());
                enteredNumbers.Add(theEnteredNumber);
            }

            List<int> onlyPositiveNums = RemoveNegativeNumbers(enteredNumbers);

            // Print the result on the console
            Console.Write("{");
            for (int i = 0; i < length - 1; i++)
            {
                Console.Write(enteredNumbers[i] + ",");
            }
            Console.Write(enteredNumbers[length - 1] + "}→{");

            for (int i = 0; i < onlyPositiveNums.Count - 1; i++)
            {
                Console.Write(onlyPositiveNums[i] + ",");
            }
            Console.Write(onlyPositiveNums[onlyPositiveNums.Count - 1] + "}");
            Console.WriteLine();

        }
    }

