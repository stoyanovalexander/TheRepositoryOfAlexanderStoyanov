using System;
    class SpiralMatrix
    {
        static void Main()
        {
            Console.Write("Enter num=");
            uint num = uint.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("Enter bigger value of num");
            }
            else if (num > 19)
            {
                Console.WriteLine("Enter smaller value of num");
            }

            else if (num== 1)
            {
                Console.WriteLine("     "+num);
            }
            else if (num == 2)
            {
                Console.Write("1  2");
                Console.WriteLine();
                Console.Write("4  3");
                Console.WriteLine();
            }
            else
            {
                uint[,] spiralMatrix = new uint[num, num];
                for (uint col = 0; col <= num - 1; col++) //Give corect vavues of the elements of row 0 .
                {
                    spiralMatrix[0, col] = col + 1;
                }

                for (uint col = 1; col <= num - 2; col++) //Give the corect values of elements [spiralMatrix[num-1,1],spiralMatrix[num-1,num-2]]
                {
                    spiralMatrix[num - 1, col] = 3 * num - 2 - col;
                }

                //Give the corect values of the up quarter of matrix without row 0.
                uint upRows = num / 2 + num % 2;
                for (uint row = 1, value = 2; row <= upRows - 1; row++, value = value + 2)
                {
                    uint start = row - 1;
                    uint end = num - 1 - row;
                    for (uint col = start; col <= end; col++)
                    {
                        spiralMatrix[row, col] = (2 * value * num - value * value) + (col - start);
                    }
                }

                //Give the corect values of the bottom quarter of the matrix with out [spiralMatrix[num-1,1],spiralMatrix[num-1,num-2]].
                for (uint row = num - 2, value = 3; row >= upRows - 1 + 1; row--, value = value + 2)
                {
                    uint start = row;
                    uint end = num - row - 1;
                    for (uint col = start; col >= end; col--)
                    {
                        spiralMatrix[row, col] = (2 * value * num - value * value) + (start - col);
                    }
                }

                //Give the corect values of the right quarter of the matrix.
                uint rightCols = num / 2;
                uint leftCols = num - rightCols - 1;
                for (uint col = num - 1, value = 1; col >= num - 1 - rightCols; col--, value = value + 2)
                {
                    uint start = col;
                    uint end = num - 1 - col;
                    for (uint row = start; row >= end + 1; row--)
                    {
                        spiralMatrix[row, col] = (2 * value * num - value * value) - (start - row);
                    }
                }

                //Give the corect values of the left quarter of the matrix.
                for (uint col = 0, value = 2; col <= leftCols - 1; col++, value = value + 2)
                {
                    uint start = col + 1;
                    uint end = num - 1 - col;
                    for (uint row = start; row <= end; row++)
                    {
                        spiralMatrix[row, col] = (2 * value * num - value * value) - (row - start);
                    }
                }

                //Print the matrix.
                for (uint row = 0; row < spiralMatrix.GetLength(0); row++)
                {
                    for (uint col = 0; col < spiralMatrix.GetLength(1); col++)
                    {
                        Console.Write("{0,-4}", spiralMatrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }

