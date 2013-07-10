using System;
    class trapezoid
    {
        static void Main()
        {
            // Input data
            int N = int.Parse(Console.ReadLine());

            // Solve
            for (int i = 1; i <= 2*N; i++)
            {
                if (i <= N) Console.Write('.');
                else Console.Write('*');
            }
            Console.WriteLine();

            for (int i = 0; i <= N - 2; i++)
            {
                for (int j = 1; j <= 2 * N; j++)
                {
                    if ((j == N - i) || (j == 2 * N)) Console.Write('*');
                    else Console.Write('.');
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 2 * N; i++)
            {
                Console.Write('*');
            }
        }
    }

