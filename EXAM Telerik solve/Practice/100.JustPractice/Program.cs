using System;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int p = int.Parse(Console.ReadLine());
                int newP = 0;
                while (p > 0)
                {
                    newP = newP << 1;
                    if ((p & 1) == 1)
                    {
                        newP = newP | 1;
                    }
                    p = p >> 1;

                }
            }
        }
    }

