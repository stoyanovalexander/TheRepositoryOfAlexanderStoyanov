using System;
using System.Collections.Generic;
using System.Linq;
  class RemoveOddOccurencedNums
    {
      static List<int> RemoveOddOccurenced(List<int> theNumbers)
      {
          theNumbers.Sort();
          int length = 1;
          List<int> onlyEvenOccurenced = new List<int>();

          for (int i = 0; i < theNumbers.Count-1; i++)
          {
              if (theNumbers[i] == theNumbers[i + 1])
              {
                  length++;
              }

              if (theNumbers[i] != theNumbers[i + 1])
              {
                  if (length % 2 == 0)
                  {
                      onlyEvenOccurenced.Add(theNumbers[i]);
                  }

                  length = 1;
              }
          }

          return onlyEvenOccurenced; 
      }

        static void Main()
        {
            Console.Write("Enter the number of the numbers in the List(positive one): ");
            int length = int.Parse(Console.ReadLine());
            List<int> onlyEvenOccurenced = new List<int>();

            // Fill the input List
            for (int i = 0; i < length; i++)
            {
                Console.Write("Some number: ");
                int theEnteredNumber = int.Parse(Console.ReadLine());
                onlyEvenOccurenced.Add(theEnteredNumber);
            }

            List<int> onlyPositiveNums = RemoveOddOccurenced(onlyEvenOccurenced);

            // Print the result on the console
            Console.Write("{");
            for (int i = 0; i < length - 1; i++)
            {
                Console.Write(onlyEvenOccurenced[i] + ",");
            }
            Console.Write(onlyEvenOccurenced[length - 1] + "}→{");

            for (int i = 0; i < onlyPositiveNums.Count - 1; i++)
            {
                Console.Write(onlyPositiveNums[i] + ",");
            }
            Console.Write(onlyPositiveNums[onlyPositiveNums.Count - 1] + "}");
            Console.WriteLine();
        }
    }

