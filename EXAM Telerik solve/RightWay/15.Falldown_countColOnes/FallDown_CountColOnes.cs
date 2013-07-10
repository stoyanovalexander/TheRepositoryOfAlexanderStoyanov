using System;
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[8];
            // Input data
            for (int i = 0; i < 8; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
            }

            // Solve
            int[] count = new int[8];
            int[] y = new int[8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((x[j] & (1 << i)) != 0)
                    {
                        count[i]++;
                    }
                }
            }

            //  for (int i = 0; i < 8; i++)
            // {
            //   Console.WriteLine(count[i]);
            //}

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (count[j] >= (8 - i)) y[i] = y[i] + (1 << j); //(int)Math.Pow(2,j);
                }
            }
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(y[i]);
            }
        }
    }

