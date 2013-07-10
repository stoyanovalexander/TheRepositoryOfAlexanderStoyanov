using System;
    class MaxSumOfK
    {
        static void Main()
        {
            Console.Write("Enter arrayLen=");
            int arrayLen = int.Parse(Console.ReadLine());
            Console.Write("Enter sequenceLen=");
            int sequenceLen = int.Parse(Console.ReadLine());
            int[] array=new int[arrayLen];
            // Fill the array
            for (int i = 0; i < arrayLen; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            // Solve
            int bestSum = int.MinValue;
            int sum =0;
            // Find sum of first K elements
            int firstMember= 0;
            for (int i = 0; i < sequenceLen; i++)
            {
                sum = sum + array[i];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    firstMember = i;
                }
            }

            for (int i = 1; i <= arrayLen - sequenceLen; i++)
            {
                sum = sum - array[i - 1] + array[i + sequenceLen - 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    firstMember = i;
                }
            }
            // Put the result on the console
            Console.Write("{");
            for (int i = 0; i < arrayLen - 1; i++)
            {
                Console.Write(array[i] + ",");
            }
            Console.Write(array[arrayLen- 1] + "}→{");
            for (int i = firstMember; i <(sequenceLen+firstMember-1); i++)
            {
                Console.Write(array[i]+ ",");
            }
            Console.Write(array[firstMember+sequenceLen-1] + "}");
            Console.WriteLine();
        }
    }

