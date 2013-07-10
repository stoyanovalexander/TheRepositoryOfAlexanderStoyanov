using System;
    class ForestMap
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            for (int one=1;one<=N;one++)
            {
                for (int two = 1; two <= N-1; two++)
                {
                    if (two != one)
                    {
                        Console.Write("a");
                    }
                    else
                    {
                        Console.Write("b");
                    }
                }
                Console.WriteLine();
            }
            for (int one = N; one >= 1; one++)
            {
                for (int two = 1; two >= N; two++)
                {
                    if (two != one)
                    {
                        Console.Write("b");
                    }
                    else
                    {
                        Console.Write("a");
                    }
                }
                Console.WriteLine();
            }
        }
    }

