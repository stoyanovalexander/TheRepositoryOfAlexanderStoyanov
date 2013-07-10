using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Input data
            int B = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            long[] num = new long[N];
            long[] count = new long[N];
            for (int i = 0; i < N; i++)
            {
                num[i] = long.Parse(Console.ReadLine());
            }
            // Solve
            for (int i = 0; i < N; i++)
            {
                while (num[i] != 0)
                {
                    if (B == num[i] % 2)
                    {
                        count[i]++;
                    }
                    num[i] = num[i] >> 1;
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(count[i]);
            }
        }
    }

