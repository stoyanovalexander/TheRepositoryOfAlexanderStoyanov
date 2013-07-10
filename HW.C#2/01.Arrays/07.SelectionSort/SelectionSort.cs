using System;
    class SelectionSort
    {
        static void Main()
        {
            Console.Write("Enter the arrayLength=");
            int arrayLen = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLen];
            // Fill the array
            for (int i = 0; i < arrayLen; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            
            for (int i = 0; (i < arrayLen - 1); i++)
            {
                int small = array[i];
                int count = i;
                for (int j = i + 1; j < arrayLen; j++)
                {
                    if (array[j] < small)
                    {
                        small = array[j];
                        count = j;
                    }
                }
                if (count != i)
                {
                    array[count] = array[i];
                    array[i] = small;
                }
            }
            // Print the sorted masiv
            Console.Write("{");
            for (int i = 0; i < arrayLen-1; i++)
            {
                Console.Write(array[i]+",");
            }
            Console.Write(array[arrayLen-1]+"}");
        }
    }

