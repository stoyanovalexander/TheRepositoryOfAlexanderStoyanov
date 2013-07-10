using System;
    class SumInArraay
    {
        static void Main()
        {
            Console.Write("Enter arrLen=");
            int arrLen = int.Parse(Console.ReadLine());
            Console.Write("Enter S=");
            int S= int.Parse(Console.ReadLine());
            int[] arr = new int[arrLen];
            // Fill the array
            for (int i = 0; i < arrLen; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // Solve
            string printIt = null;
            int max = (int)Math.Pow(2, arrLen) ;
            for (int i = 0; i < max; i++)
            {
                long sum=0;
                string result = null;
                for (int j = 0; j < arrLen; j++)
                { 
                    if (((i >> j) & 1) == 1)
                    {
                        sum = sum + arr[j];
                        if (sum == S)
                        {
                            result = result + arr[j];
                            printIt = result;
                        }
                        else
                        {
                            result = result + arr[j] + "+";
                        }
                    }
                }
            }
            if (printIt == null)
            {
                // Print the array
                Console.Write("{");
                for (int k = 0; k < arrLen - 1; k++)
                {
                    Console.Write(arr[k] + ",");
                }
                Console.Write(arr[arrLen - 1] + "},S=" + S + "→");
                Console.Write("No");
                Console.WriteLine();
            }
            else
            {
                // Print the array
                Console.Write("{");
                for (int i = 0; i < arrLen - 1; i++)
                {
                    Console.Write(arr[i] + ",");
                }
                Console.Write(arr[arrLen - 1] + "},S="+S+"→");
                // Print the result
                Console.Write("("+printIt+")");
                Console.WriteLine();
            }
        }
    }

