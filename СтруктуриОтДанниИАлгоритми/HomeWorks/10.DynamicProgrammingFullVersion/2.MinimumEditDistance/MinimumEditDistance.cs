namespace MinimumEditDistance
{
    using System;

    /// <summary>
    /// Write a program to calculate the "Minimum Edit Distance" (MED) between two words. MED(x, y) is the minimal sum of costs of edit operations used to transform x to y. Sample costs are given below:
    /// cost (replace a letter) = 1
    /// cost (delete a letter) = 0.9
    /// cost (insert a letter) = 0.8
    /// Example: x = "developer", y = "enveloped" -> cost = 2.7
    /// delete ‘d’:  "developer" -> "eveloper", cost = 0.9
    /// insert ‘n’:  "eveloper" -> "enveloper", cost = 0.8
    /// replace ‘r’ -> ‘d’:  "enveloper" -> "enveloped", cost = 1
    ///
    /// Link with explanation: http://www.let.rug.nl/kleiweg/lev/
    /// </summary>
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
           //PrintCostsTable();
            Console.WriteLine();

            var result2 = Calcolate("huren", "nlchl");
            Console.WriteLine("Words: huren -> nlchl");
            Console.WriteLine("cost ="+result2);
            //PrintCostsTable();
            Console.WriteLine();

            var result3 = Calcolate("Semra", "Ozungioz");
            Console.WriteLine("Words: Semra -> Ozungioz");
            Console.WriteLine("cost ="+result3);
            //PrintCostsTable();
        }

        /// <summary>
        /// Compute the distance between two words.
        /// </summary>
        public static decimal Calcolate(string word1, string word2)
        {
            int n = word1.Length;
            int m = word2.Length;
            table = new decimal[n + 1, m + 1];

            // Step 1: Base case 0
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Step 2: Fill cost of deletions
            for (int row = 0; row <= n; row++)
            {
                table[row, 0] = row * CostDelete;
            }

            for (int col = 0; col <= m; col++)
            {
                table[0, col] = col * CostDelete;
            }

            // Step 3: Calculate and choose min cost operation
            // ----------------------------------
            // |diag Cell  | above Cell           |
            // -----------------------------------
            // |           | min (above + delete, |
            // |left Cell  |      diag + replace, |
            // |           |      left + insert)  |
            // ----------------------------------
            for (int row = 1; row <= n; row++)
            {
                // Step 4
                for (int col = 1; col <= m; col++)
                {
                    // Step 5: Calculate the cost of replacing. If the letters are equal it is 0, otherwise its the replace operation cost
                    decimal cost = (word2[col - 1] == word1[row - 1]) ? 0 : CostReplace;

                    // Step 6: Find the minimal cost operation of the 3 possible
                    decimal delete = table[row - 1, col] + CostDelete;
                    decimal replace = table[row - 1, col - 1] + cost;
                    decimal insert = table[row, col - 1] + CostInsert;

                    table[row, col] = Math.Min(
                        Math.Min(delete, insert),
                        replace);
                }
            }

            // Step 7: Take and return the result (most down-right cell)
            return table[n, m];
        }

        //public static void PrintCostsTable()
        //{
        //    Console.WriteLine("Costs table");
        //    for (int i = 0; i < table.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < table.GetLength(1); j++)
        //        {
        //            Console.Write("{0, 4} ", table[i, j]);
        //        }

        //        Console.WriteLine();
        //    }
        //}
    }
}
