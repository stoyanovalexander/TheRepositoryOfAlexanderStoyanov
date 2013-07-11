using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class AllPassebleCellsAreas
    {
        static string[,] someLabyrinth = 
        {
            {" ", "*", " ", "*", " ", " ", " "},
            {"*", "*", " ", "*", " ", "*", " "},
            {" ", " ", "*", "*", " ", " ", "*"},
            {" ", "*", "*", "*", "*", "*", " "},
            {" ", " ", " ", "*", " ", " ", " "},
        };

        static void FindBiggestArea(int rows, int cols)
        {
            int step = 0;
            int count = 0;

            PrintLabyrint();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (someLabyrinth[i, j] == " ")
                    {
                        FindArea(i, j, step, ref count);
                        step++;
                        PrintLabyrint();
                    }
                }
            }
        }

        static void FindArea(int row, int col, int step, ref int count)
        {
            if (row < 0 || col < 0 ||
                row >= someLabyrinth.GetLength(0) || col >= someLabyrinth.GetLength(1))
            {
                return;
            }

            if (someLabyrinth[row, col] != " ")
            {
                return;
            }

            someLabyrinth[row, col] = step.ToString();
            count++;

            FindArea(row, col - 1, step, ref count);
            FindArea(row - 1, col, step, ref count);
            FindArea(row, col + 1, step, ref count);
            FindArea(row + 1, col, step, ref count);
        }

        static void PrintLabyrint()
        {
            for (int i = 0; i < someLabyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < someLabyrinth.GetLength(1); j++)
                {
                    Console.Write("{0, 2} ", someLabyrinth[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            FindBiggestArea(someLabyrinth.GetLength(0), someLabyrinth.GetLength(1));
        }
    }

