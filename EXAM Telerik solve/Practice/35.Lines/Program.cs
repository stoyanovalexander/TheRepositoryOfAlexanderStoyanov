using System;
    class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[8];
            // Input data
            for (int i = 0; i < 8; i++)
            {
                N[i] = int.Parse(Console.ReadLine());
            }

            // Solve
            int[] P = new int[8];
            int[] N2 = new int[8];
            int num = 1;
            int biggest = 0;
            int count = 0;
            for (int i = 0; i < 8; i++)
            {
                N2[i] = N[i];
            }
            for (int i = 7; i >= 0; i--)
            {
                for (int j = 0; j <= 7; j++)
                {
                    if (N2[j] >= (int)Math.Pow(2, i))  // Or (1<<i)
                    {
                        P[i] = P[i] + (int)Math.Pow(2, j);  // Or (1<<i)
                        N2[j] = N2[j] - (int)Math.Pow(2, i);  // Or (1<<i)
                    }
                }
            }
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    if (N[i] >= (int)Math.Pow(2, j))
                    {
                        count++;
                        N[i] = N[i] - (int)Math.Pow(2, j);
                    }
                    else if (count == biggest)
                    {
                        num++;
                        count = 0;
                    }
                    else if (count > biggest)
                    {
                        biggest = count;
                        count = 0;
                    }
                }
            }
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    if (P[i] >= (int)Math.Pow(2, j))
                    {
                        count++;
                        P[i] = P[i] - (int)Math.Pow(2, j);
                    }
                    else if (count == biggest)
                    {
                        num++;
                        count = 0;
                    }
                    else if (count > biggest)
                    {
                        biggest = count;
                        count = 0;
                    }
                }
            }
            if (biggest == 1)
            {
                num = num / 2;
            }
            Console.WriteLine(biggest);
            Console.WriteLine(num);
        }
    }

