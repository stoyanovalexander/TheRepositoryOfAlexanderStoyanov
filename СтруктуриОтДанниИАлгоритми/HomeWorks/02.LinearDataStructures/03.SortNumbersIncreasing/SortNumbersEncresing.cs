using System;
using System.Collections.Generic;
using System.Linq;

    class SortNumbersEncresing
    {
        static void Main()
        {
            bool isParsed = true;
            List<int> theEnteredNumbers = new List<int>();
            while (isParsed)
            {
                Console.Write("Enter integer number: ");
                string theInput = Console.ReadLine();
                int valueOfTheInput;
                isParsed = int.TryParse(theInput, out valueOfTheInput);

                if (isParsed)
                {
                    theEnteredNumbers.Add(valueOfTheInput);    
                }
            }

            Console.WriteLine();
            Console.WriteLine("SORTED LIST!");
            theEnteredNumbers.Sort();
            foreach (int number in theEnteredNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }

