using System;
    class SequenceInMatrix
    {
        static void Main()
        {
            Console.Write("Enter n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m=");
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];

            // Fill the matrix
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("matrix[{0},{1}]=", row, col);
                    matrix[row, col] = Console.ReadLine();
                }
            }

            string theString = null;
            int bestCount = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    // Count sequences ↓→ diagonal
                    int count = 1;
                    int rowNext = row + 1;
                    int colNext = col + 1;
                    while ((rowNext < n) && (colNext < m) && (matrix[row, col] == matrix[rowNext, colNext]))
                    {
                        rowNext++;
                        colNext++;
                        count++;
                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                        theString = matrix[row, col];
                    }

                    // Count sequences↓← diagonal
                    count = 1;
                    rowNext = row + 1;
                    colNext = col - 1;
                    while ((rowNext < n) && (colNext > 0) && (matrix[row, col] == matrix[rowNext, colNext]))
                    {
                        rowNext++;
                        colNext--;
                        count++;
                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                        theString = matrix[row, col];
                    }

                    // Count sequence → lines
                    count = 1;
                    rowNext = row;
                    colNext = col + 1;
                    while ((rowNext < n) && (colNext < m) && (matrix[row, col] == matrix[rowNext, colNext]))
                    {
                        colNext++;
                        count++;
                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                        theString = matrix[row, col];
                    }

                    // Count sequence ↓ lines
                    count = 1;
                    rowNext = row + 1;
                    colNext = col;
                    while ((rowNext < n) && (colNext < m) && (matrix[row, col] == matrix[rowNext, colNext]))
                    {
                        rowNext++;
                        count++;
                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                        theString = matrix[row, col];
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

            Console.WriteLine();
            // Print the longest sequence
            Console.Write("→");
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(" " + theString + " ");
            }
            //Console.Write(bestCount);
            Console.WriteLine();
        }
    }

