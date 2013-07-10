using System;
    class MaximalSequence
    {
        static void Main()
        {
            Console.Write("Enter the arrayLength=");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array=new int[arrayLength];
            // Fill the array
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            // Solve
            int len = 1;
            int bestLen = 0;
            int bestNumber = 0;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    len++;
                }
                else
                {
                    if (len > bestLen)
                    {
                        bestNumber = array[i];
                        bestLen = len;
                    }
                    len = 1;
                }
            }
            if (len > bestLen)
            {
                bestLen = len;
                bestNumber = array[arrayLength - 1];
            }
            // Put the result on the console
            Console.Write("{");
            for (int i = 0; i < arrayLength-1; i++)
            {
                Console.Write(array[i]+",");
            }
            Console.Write(array[arrayLength-1] + "}→{");
            for (int i = 0; i < bestLen - 1; i++)
            {
                Console.Write(bestNumber+",");
            }
            Console.Write(bestNumber+"}");
            Console.WriteLine();
        }
    }

