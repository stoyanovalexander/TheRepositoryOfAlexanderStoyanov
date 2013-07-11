using System;
using System.Collections.Generic;
using System.Linq;

    class FoundArraysMajorant
    {
        static void MajorantFound(int[] enteredArray)
        {
            List<int> sameNumbersInList = new List<int>();

            // Put the numbers from the array in list
            for (int i = 0; i < enteredArray.Length; i++)
            {
                sameNumbersInList.Add(enteredArray[i]);
            }

            sameNumbersInList.Sort();
            int length = 1;
            int majorant=sameNumbersInList.Count/2+1;
            bool majoritanFound = false;

            for (int i = 0; i < sameNumbersInList.Count - 1; i++)
            {
                if (sameNumbersInList[i] == sameNumbersInList[i + 1])
                {
                    length++;
                }

                if (sameNumbersInList[i] != sameNumbersInList[i + 1])
                {
                    if (length >= majorant)
                    {
                        Console.Write(sameNumbersInList[i]);
                        majoritanFound = true;
                        break;
                    }

                        length = 1;
                }
            }

            if ((!majoritanFound)&&(length >= majorant))
            {
                Console.Write(sameNumbersInList[sameNumbersInList.Count - 1]);  // The last one
            }

            else if((!majoritanFound)&&(length<majorant))
            {
                Console.WriteLine("majorant does not exist");
            }
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

            // Print the result on the console
            Console.Write("{");
            for (int i = 0; i < length - 1; i++)
            {
                Console.Write(theArray[i] + ",");
            }

            Console.Write(theArray[length - 1] + "}→");
            MajorantFound(theArray);
            Console.WriteLine();
        }
    }

