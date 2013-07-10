using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Input data
            int N = int.Parse(Console.ReadLine());
            long[] num = new long[N];
            for (int i = 0; i < N; i++)
            {
                num[i] = long.Parse(Console.ReadLine());
            }

            // Solve
            for (int i = 0; i < N; i++)
            {
                int count = 1;
                for (int j = 0; j < N; j++)
                {
                    if (j == i) continue;
                    if (num[i] == num[j]) count++;
                }
                if ((count % 2) == 1)
                {
                    Console.WriteLine(num[i]);
                    break;
                }

            }
        }
    }

