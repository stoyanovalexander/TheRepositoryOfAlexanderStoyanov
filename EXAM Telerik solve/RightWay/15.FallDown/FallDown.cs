using System;
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[8];
            for (int i = 0; i < 8; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            for (int falls = 1; falls <= 7; falls++)
            { 
                for(int numOfN=7;numOfN>=1;numOfN--)
                {
                    for(int bit=0;bit<8;bit++)
                    {
                        if ((((n[numOfN] >> bit) & 1) == 0) && (((n[numOfN - 1] >> bit) & 1) == 1))
                        {
                            n[numOfN] = n[numOfN] | (1 << bit);
                            n[numOfN - 1] = n[numOfN - 1] & (~(1 << bit));
                        }
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }

