using System;
    class MostFrequentNum
    {
        static void Main()
        {
            Console.Write("Enter arrLen=");
            int arrLen = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLen];
            int[] array = new int[arrLen];
            // Fill the array
            for (int i = 0; i < arrLen; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // Fill second array with same values as the first
            for(int i=0;i<arrLen;i++)
            {
                array[i]=arr[i];
            }
            // Selection Sort
            for (int i = 0; (i < arrLen - 1); i++)
            {
                int small = arr[i];
                int count = i;
                for (int j = i + 1; j < arrLen; j++)
                {
                    if (arr[j] < small)
                    {
                        small = arr[j];
                        count = j;
                    }
                }
                if (count != i)
                {
                    arr[count] = arr[i];
                    arr[i] = small;
                }
            }
            // MaximalSequence
            int len = 1;
            int bestLen = 0;
            int bestNumber = 0;
            for (int i = 0; i < arrLen - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    len++;
                }
                else
                {
                    if (len > bestLen)
                    {
                        bestNumber = arr[i];
                        bestLen = len;
                    }
                    len = 1;
                }
            }
            if (len > bestLen)
            {
                bestLen = len;
                bestNumber = arr[arrLen - 1];
            }
            // Print the array
            Console.Write("{");
            for (int i = 0; i < arrLen - 1; i++)
            {
                Console.Write(array[i] + ",");
            }
            Console.Write(array[arrLen - 1] + "}→");
            // Print the result
            Console.Write("{0}({1} times)",bestNumber,bestLen);
            Console.WriteLine();
        }
    }

