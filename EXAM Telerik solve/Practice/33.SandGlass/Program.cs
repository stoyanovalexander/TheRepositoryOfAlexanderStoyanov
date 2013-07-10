using System;
    class Program
    {
        static void Main(string[] args)
        {
            // input data
            int N = int.Parse(Console.ReadLine());

            // Solve
            for (int i = 0; i <= N / 2; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    if ((j > i) && (j <=( N - i)))
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
            for (int i = (N / 2) - 1; i >= 0;i-- )
            {
                for (int j = 1; j <= N; j++)
                {
                    if ((j > i) && (j <= (N - i)))
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

