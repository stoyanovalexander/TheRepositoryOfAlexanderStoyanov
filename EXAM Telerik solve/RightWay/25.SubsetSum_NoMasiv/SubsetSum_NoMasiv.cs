using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Input data
            long S = long.Parse(Console.ReadLine());
            long N = long.Parse(Console.ReadLine());
            long n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16;
            n1 = n2 = n3 = n4 = n5 = n6 = n7 = n8 = n9 = n10 = n11 = n12 = n13 = n14 = n15 = n16 = 0L;
            for (int i = 1; i <= N; i++)
            {
                if (i == 1)
                {
                    n1 = long.Parse(Console.ReadLine());
                }
                if (i == 2)
                {
                    n2 = long.Parse(Console.ReadLine());
                }
                if (i == 3)
                {
                    n3 = long.Parse(Console.ReadLine());
                }
                if (i == 4)
                {
                    n4 = long.Parse(Console.ReadLine());
                }
                if (i == 5)
                {
                    n5 = long.Parse(Console.ReadLine());
                }
                if (i == 6)
                {
                    n6 = long.Parse(Console.ReadLine());
                }
                if (i == 7)
                {
                    n7 = long.Parse(Console.ReadLine());
                }
                if (i == 8)
                {
                    n8 = long.Parse(Console.ReadLine());
                }
                if (i == 9)
                {
                    n9 = long.Parse(Console.ReadLine());
                }
                if (i == 10)
                {
                    n10 = long.Parse(Console.ReadLine());
                }
                if (i == 11)
                {
                    n11 = long.Parse(Console.ReadLine());
                }
                if (i == 12)
                {
                    n12 = long.Parse(Console.ReadLine());
                }
                if (i == 13)
                {
                    n13 = long.Parse(Console.ReadLine());
                }
                if (i == 14)
                {
                    n14 = long.Parse(Console.ReadLine());
                }
                if (i == 15)
                {
                    n15 = long.Parse(Console.ReadLine());
                }
                if (i == 16)
                {
                    n16 = long.Parse(Console.ReadLine());
                }
            }
            // Solve
            long iMax = (long)Math.Pow(2, N) - 1;
            long sum = 0;
            long count = 0;
            for (long i = 1; i <= iMax; i++)
            {
                for (int k = 1; k <= N; k++)
                {
                    if (((i >> (k - 1)) & 1) == 1)
                    {
                        if (k == 1) sum = sum + n1;
                        if (k == 2) sum = sum + n2;
                        if (k == 3) sum = sum + n3;
                        if (k == 4) sum = sum + n4;
                        if (k == 5) sum = sum + n5;
                        if (k == 6) sum = sum + n6;
                        if (k == 7) sum = sum + n7;
                        if (k == 8) sum = sum + n8;
                        if (k == 9) sum = sum + n9;
                        if (k == 10) sum = sum + n10;
                        if (k == 11) sum = sum + n11;
                        if (k == 12) sum = sum + n12;
                        if (k == 13) sum = sum + n13;
                        if (k == 14) sum = sum + n14;
                        if (k == 15) sum = sum + n15;
                        if (k == 16) sum = sum + n16;
                    }

                }
                if (sum == S)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

