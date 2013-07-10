using System;
    static class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= (n/2); i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == i) Console.Write('\\');
                    else if (j == (n - i + 1)) Console.Write('/');
                    else if (j == ((n / 2) + 1)) Console.Write('|');
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }


            for (int i = 1; i <= n; i++)
            {
                if (i == ((n / 2) + 1)) Console.Write('*');
                else
                {
                    Console.Write('-');
                }
            }
            Console.WriteLine();


            for (int i = (n / 2); i >= 1; i--)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == i) Console.Write('/');
                    else if (j == (n - i + 1)) Console.Write('\\');
                    else if (j == ((n / 2)+1 )) Console.Write('|');
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }

