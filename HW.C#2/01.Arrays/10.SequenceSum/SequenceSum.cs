using System;
    class SequenceSum
    {
        static void Main()
        {
            Console.Write("Enter arrLen=");
            int arrLen = int.Parse(Console.ReadLine());
            Console.Write("Enter theSum=");
            int theSum = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLen];
            // Fill the array
            for (int i = 0; i < arrLen; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // Solve
            int sum = 0;
            int countI = -2;
            int countJ = -5;
            for (int i = 0; i < arrLen; i++)
            {
                for (int j = i; j < arrLen; j++)
                {
                    sum = sum + arr[j];
                    if (sum == theSum)
                    {
                        countJ = j;
                        countI = i;
                    }
                }
                sum = 0;
            }
            if (countJ < 0)
            {
                Console.WriteLine("sequence with sum=theSum does not exist in this array");
            }
            else
            {
                // Print the array
                Console.Write("{");
                for (int i = 0; i < arrLen - 1; i++)
                {
                    Console.Write(arr[i] + ",");
                }
                Console.Write(arr[arrLen - 1] + "},theSum="+theSum+"→");
                // Print the result
                if(countI==countJ)
                {
                    Console.Write("{"+arr[countI]+"}");
                }
                else
                {
                Console.Write("{");
                for (int i = countI; i < countJ; i++)
                {
                    Console.Write(arr[i]+",");
                }
                Console.Write(arr[countJ]+"}");
                }
            }
            Console.WriteLine();
        }
    }

