using System;
using System.Collections.Generic;
using System.Linq;

    class SumAndAverage
    {
        static void Main()
        {
            bool isParsed = true;
            List<int> theEnteredNumbers=new List<int>();
            while (isParsed)
            {
                Console.Write("Enter POSITIVE number: ");
                string theInput = Console.ReadLine();
                int valueOfTheInput;
                isParsed = int.TryParse(theInput, out valueOfTheInput);
 
                if (isParsed)
                {
                    if (valueOfTheInput < 0)
                    {
                        throw new ArgumentException("Entered numbers must be POSITIVE!");
                    }

                    else
                    {
                        theEnteredNumbers.Add(valueOfTheInput);
                    }
                }
            }

            int sum = theEnteredNumbers.Sum();
            double average = theEnteredNumbers.Average();
            Console.WriteLine("theEnteredNumbers sum={0}",sum);
            Console.WriteLine("theEnteredNumbers saverage={0}", average);
        }
    }

