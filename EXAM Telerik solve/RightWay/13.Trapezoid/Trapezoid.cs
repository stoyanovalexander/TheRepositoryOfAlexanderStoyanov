using System;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 2*n; i++)
            {
                if (i <= n)
                {
                    Console.Write('.');
                }
                else
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
            for (int i = 0; i <= n - 2; i++)
            {
                for (int j = 1; j <= 2 * n; j++)
                {
                    if ((j == n - i) || (j == 2 * n))
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
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write('*');
            }
        }
    }

