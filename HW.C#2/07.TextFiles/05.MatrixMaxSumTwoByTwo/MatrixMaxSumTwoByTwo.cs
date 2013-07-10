using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
    class MatrixMaxSumTwoByTwo
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("TheMatrix.txt",Encoding.GetEncoding("UTF-8"));
            StreamWriter writer = new StreamWriter("TheMaxPlatform.txt", false, Encoding.GetEncoding("UTF-8"));
            int matrixSize = 0;
            int row = 0;
            int col = 0;
            string line = "";
            string number = "";
            using (reader)
            {
                using (writer)
                {
                    line = reader.ReadLine();
                    matrixSize = int.Parse(line);
                    int[,] matrix = new int[matrixSize, matrixSize];
                    line = reader.ReadLine();
                    while (line != null)
                    {
                        foreach (var symbol in line)
                        {
                            if (symbol != ' '||symbol=='\n'||symbol=='\r')
                            {
                                number = number + symbol;
                            }
                            else
                            {
                                matrix[row, col] = int.Parse(number);
                                col++;
                                number = "";
                            }
                        }
                        //matrix[row, col] = int.Parse(number);
                        col = 0;
                        row++;
                        number = " ";
                        line = reader.ReadLine();
                    }
                    writer.WriteLine(FindingMaxPlatform(matrix));
                }
                       
            }
        }
        static int FindingMaxPlatform(int[,] matrix)
        {
            int currentSum = 0;
            int maxSum = int.MinValue;
            for(int row=0;row<matrix.GetLength(0)-1;row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, (col + 1)] + matrix[(row + 1), col] + matrix[(row + 1), (col + 1)];
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                    }
                    currentSum = 0;
                }
            }
            return maxSum;
        }
    }

