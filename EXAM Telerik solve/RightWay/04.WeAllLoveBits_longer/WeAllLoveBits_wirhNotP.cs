using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Input data
            uint N = uint.Parse(Console.ReadLine());
            uint[] P = new uint[N];
            for (uint i = 0; i < N; i++)
            {
                P[i] = uint.Parse(Console.ReadLine());
            }

            // Solve
            uint[] Pnew = new uint[N];
            uint[] notP = new uint[N];
            uint[] reverseP = new uint[N];
            int power = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j < 100; j++)
                {
                    if ((P[i] / (1 << j)) == 0)
                    {
                        notP[i] = P[i] ^ (uint)((1 << j) - 1);
                        power = j - 1;
                        break;
                    }
                }
                for (int j = power, k = 0; j >= 0; j--, k++)
                {
                    if (P[i] >= (1 << j))//(uint)Math.Pow(2, j))
                    {
                        P[i] = P[i] - 1 << j;//(uint)Math.Pow(2, j);
                        reverseP[i] = reverseP[i] + (uint)(1 << k);//(uint)Math.Pow(2, k);
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                Pnew[i] = (P[i] ^ notP[i]) & reverseP[i];
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(Pnew[i]);
            }
        }
    }

