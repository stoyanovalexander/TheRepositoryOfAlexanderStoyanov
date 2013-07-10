using System;
    class MaximalSumInArr
    {
        static void Main()
        {
            Console.Write("Enter arrLen=");
            int arrLen = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLen];
            // Fill the array
            for (int i = 0; i < arrLen; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // Solve
            int bestSum = int.MinValue;
            int sum = 0;
            int countI = -2;
            int countJ = -5;
            for (int i = 0; i < arrLen-1; i++)
            {
                sum = arr[i];
                for (int j = i+1; j < arrLen; j++)
                {
                    sum = sum + arr[j];
                    if (sum> bestSum)
                    {
                        bestSum = sum;
                        countJ = j;
                        countI = i;
                    }
                }
                sum = 0;
            }
            // Print the array
            Console.Write("{");
            for (int i = 0; i < arrLen - 1; i++)
            {
                Console.Write(arr[i] + ",");
            }
            Console.Write(arr[arrLen - 1] + "}→{");
            // Print the result
            for (int i = countI; i < countJ; i++)
            {
                Console.Write(arr[i] + ",");
            }
            Console.Write(arr[countJ] + "}");
                
    
            Console.WriteLine();
        }
    }

