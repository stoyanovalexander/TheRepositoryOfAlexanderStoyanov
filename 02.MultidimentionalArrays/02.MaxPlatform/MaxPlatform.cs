using System;
    class MaxPlatform
    {
        static void Main()
        {
            Console.Write("Enter n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m=");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];

            // Fill the matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("matrix[{0},{1}]=", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Find the maximal sum platfrm of size 3x3
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            // Print the matrix
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("{0,6} ", matrix[row, col]);
                }
                Console.WriteLine();
            }

            // Print the max Platform
            Console.WriteLine("The maxPlatform is:");
            Console.WriteLine("{0}  {1}  {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
            Console.WriteLine("{0}  {1}  {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
            Console.WriteLine("{0}  {1}  {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
            Console.WriteLine("maxSum is:" + bestSum);
        }
    }

