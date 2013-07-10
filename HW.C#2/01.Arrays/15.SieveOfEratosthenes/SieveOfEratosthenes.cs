using System;
    class SieveOfEratosthenes
    {
        static void Main()
        {
            bool[] arr = new bool[10001];
            for (int i = 2; i < 3164; i++)
            {
                if (arr[i] == false)
                {
                    for (int j = i+1; j < 10001; j++)
                    {
                        if (j % i == 0)
                        {
                            arr[j] = true;                           
                        }
                    }
                }
            }

            for (int i = 2; i < 10001; i++)
            {
                if (arr[i] == false)
                {
                    Console.Write("  "+i+"  ");
                }
            }
        }
    }

