using System;
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[8];
            // Input data
            for (int i = 0; i < 8; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }

            // Solve
            int[] col = new int[8];
            for (int i = 7; i >= 0; i--)
            {
                for (int j = 0; j <= 7; j++)
                {
                    if (n[j] >= (int)Math.Pow(2, i))  // Or 1<<j
                    {
                        col[i]++;
                        n[j] = n[j] - (int)Math.Pow(2, i);  //Or 1<<j
                    }
                }
            }
            if ((col[6] + col[5] + col[4] + col[3] + col[2] + col[1] + col[0]) == 0)
            {
                Console.WriteLine(7);
                Console.WriteLine(0);
            }
            else if ((col[7]==col[5] + col[4] + col[3] + col[2] + col[1] + col[0]))
            {
                Console.WriteLine(6);
                Console.WriteLine(col[7]);
            }
            else if ((col[7]+col[6] == col[4] + col[3] + col[2] + col[1] + col[0]))
            {
                Console.WriteLine(5);
                Console.WriteLine(col[7]+col[6]);
            }
            else if ((col[7]+col[6]+col[5] ==col[3] + col[2] + col[1] + col[0]))
            {
                Console.WriteLine(4);
                Console.WriteLine(col[7]+col[6]+col[5]);
            }
            else if ((col[7]+col[6]+ col[5] + col[4] == col[2] + col[1] + col[0]))
            {
                Console.WriteLine(3);
                Console.WriteLine(col[2]+col[1]+col[0]);
            }
            else if ((col[7] + col[6] + col[5] + col[4] +col[3]== col[1] + col[0]))
            {
                Console.WriteLine(2);
                Console.WriteLine(col[1] + col[0]);
            }
            else if ((col[7] + col[6] + col[5] + col[4]+col[3]+ col[2] == col[0]))
            {
                Console.WriteLine(1);
                Console.WriteLine(col[0]);
            }
            else if ((col[7] + col[6] + col[5] + col[4] + col[3] + col[2] + col[1] == 0))
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

