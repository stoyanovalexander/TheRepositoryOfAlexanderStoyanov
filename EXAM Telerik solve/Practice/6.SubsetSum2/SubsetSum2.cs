using System;
    class SubsetSum2
    {
        static void Main()
        {
            // Input data
            long S = long.Parse(Console.ReadLine());
            long N = long.Parse(Console.ReadLine());
            long[] num=new long[N];
            for (long i = 0; i < N; i++)
            {
                num[i] = long.Parse(Console.ReadLine());
            }

            // Solve
            long count = 0;
            long sum = 0;
            long allVariants =(long)Math.Pow(2, N) - 1;
            for (long i = 1; i <= allVariants; i++)
            {
                for (int k = 0; k < N; k++)
                {
                    if (((i >> k) % 2) == 1)
                    {
                        sum = sum + num[k];
                    }
                }
                if (sum == S) count++;
                sum = 0;
            }
            Console.WriteLine(count);
        }
    }

