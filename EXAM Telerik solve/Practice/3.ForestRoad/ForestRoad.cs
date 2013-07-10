using System;
    class ForestRoad
    {
        static void Main()
        {
            // Input Data
            int N = int.Parse(Console.ReadLine());
            // Solve
            for (int i = 1; i <= N; i++)
            {
                for (int k = 1; k <= N; k++)
                {
                    if (k == i)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= (N - 1); i++)
            {
                for (int k = 1; k <= N; k++)
                {
                    if (k == N - i)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }

