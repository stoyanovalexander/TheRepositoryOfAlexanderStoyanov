using System;
    class Program
    {
        static void Main(string[] args)
        {
            long s = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            long count = 0;
            long[] num = new long[n];
            for (long i = 0; i < n; i++)
            {
                num[i] = long.Parse(Console.ReadLine());
            }
            long combinations=(long)Math.Pow(2.0,n)-1;  // 1<<n-1
            for (long i = 1; i <= combinations; i++)
            {
                long sum=0;
                for (int j = 0; j < n; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        sum = sum + num[j];
                    }
                }
                if (sum == s)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

