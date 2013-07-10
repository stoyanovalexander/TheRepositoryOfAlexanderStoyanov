using System;
    class RemoveMinElements
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
            int maxCount=0;
            string printIt=null;
            int max = (int)Math.Pow(2, arrLen);
            for (int i = 0; i < max; i++)
            {
                int previos=int.MinValue;
                int count = 0;
                string result = null;
                for (int j = 0; j < arrLen; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        if(arr[j]>=previos)
                        {
                        result = result + arr[j] + ",";
                        count++;
                        previos=arr[j];
                        }
                        else
                        {
                            count=0;
                            break;
                        }
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    printIt = result;
                }
            }
                // Print the array
                Console.Write("{");
                for (int i = 0; i < arrLen - 1; i++)
                {
                    Console.Write(arr[i] + ",");
                }
                Console.Write(arr[arrLen - 1] + "}→");
                // Print the result
                Console.Write("{" + printIt + "}");
                Console.WriteLine();
        }
    }
