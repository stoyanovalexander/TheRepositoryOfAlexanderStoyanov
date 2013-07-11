using System;

    public class MinimumEditDistance
    {
        private const decimal CostDelete = 0.9M;
        private const decimal CostInsert = 0.8M;
        private const decimal CostReplace = 1M;
        private static decimal[,] table;

        public static void Main()
        {
            var result1 = Calcolate("siabonga", "nomwete");
            Console.WriteLine("Words: siabonga -> nomwete");
            Console.WriteLine("cost ="+result1);
            Console.WriteLine();

            var result2 = Calcolate("huren", "nlchl");
            Console.WriteLine("Words: huren -> nlchl");
            Console.WriteLine("cost ="+result2);
            Console.WriteLine();

            var result3 = Calcolate("Semra", "Ozungioz");
            Console.WriteLine("Words: Semra -> Ozungioz");
            Console.WriteLine("cost ="+result3);
        }

        public static decimal Calcolate(string word1, string word2)
        {
            int n = word1.Length;
            int m = word2.Length;
            table = new decimal[n + 1, m + 1];

            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            for (int row = 0; row <= n; row++)
            {
                table[row, 0] = row * CostDelete;
            }

            for (int col = 0; col <= m; col++)
            {
                table[0, col] = col * CostDelete;
            }

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= m; col++)
                {
                    decimal cost = (word2[col - 1] == word1[row - 1]) ? 0 : CostReplace;
                    decimal delete = table[row - 1, col] + CostDelete;
                    decimal replace = table[row - 1, col - 1] + cost;
                    decimal insert = table[row, col - 1] + CostInsert;

                    table[row, col] = Math.Min(Math.Min(delete, insert),replace);
                }
            }

            return table[n, m];
        }
    }

