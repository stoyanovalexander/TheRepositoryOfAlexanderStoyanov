using System;
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int currentBit = 0;
            int firstOneBit = 0;
            int previosBit = 0;
            int lend = 0;
            int dancingBitsCount = 0;
            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int j = 31; j >= 0; j--)
                {
                    currentBit = (num >> j) & 1;
                    if (currentBit == 1)
                    {
                        firstOneBit = j;
                        break;
                    }
                }
                for (int j = firstOneBit; j >= 0; j--)
                {
                    currentBit = (num >> j) & 1;
                    if (currentBit == previosBit)
                    {
                        lend++;
                    }
                    else
                    {
                        if (lend == K)
                        {
                            dancingBitsCount++;
                        }
                        lend = 1;
                    }
                    previosBit = currentBit;
                }
            }
            if (lend == K)
            {
                dancingBitsCount++;
            }
            Console.WriteLine(dancingBitsCount);
        }
    }

