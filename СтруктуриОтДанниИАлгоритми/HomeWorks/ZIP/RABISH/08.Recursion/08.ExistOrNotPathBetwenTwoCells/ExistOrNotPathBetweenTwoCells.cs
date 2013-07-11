using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ExistOrNotPathBetweenTwoCells
    {
        static void FindExit(string[,] labyrinth, int row, int col, int step, ref bool isFound)
        {
            if (row < 0 || col < 0 || isFound ||
                row >= labyrinth.GetLength(0) || col >= labyrinth.GetLength(1))
            {
                return;
            }

            if (labyrinth[row, col] == "e")
            {
                isFound = true;
            }

            if (labyrinth[row, col] != " ")
            {
                return;
            }

            labyrinth[row, col] = step.ToString();
            step++;

            FindExit(labyrinth, row, col - 1, step, ref isFound);
            FindExit(labyrinth, row - 1, col, step, ref isFound);
            FindExit(labyrinth, row, col + 1, step, ref isFound);
            FindExit(labyrinth, row + 1, col, step, ref isFound);

            labyrinth[row, col] = " ";
        }

        static void SetExit(string[,] labyrinth, int row, int col)
        {
            labyrinth[row, col] = "e";
        }

        static string[,] InitEmptyLabyrinth(int rows, int cols)
        {
            string[,] labyrinth = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    labyrinth[i, j] = " ";
                }
            }

            return labyrinth;
        }

        static void Main(string[] args)
        {
            int row = 4;
            int col = 0;

            string[,] emptyLabyrinth = InitEmptyLabyrinth(100, 100);
            SetExit(emptyLabyrinth, 50, 69);
            bool isFound = false;
            FindExit(emptyLabyrinth, row, col, 0, ref isFound);
            Console.WriteLine("In emptyLabirinth path between [{0}, {1}] and[13, 44] EXIST: {2}", row, col, isFound);
            Console.WriteLine();
            Console.WriteLine();

            string[,] labyrinth = 
            {
                {" ", " ", " ", "*", " ", " ", " "},
                {"*", "*", " ", "*", " ", "*", " "},
                {" ", " ", " ", " ", " ", " ", " "},
                {" ", "*", "*", "*", "*", "*", " "},
                {" ", " ", " ", " ", " ", " ", " "},
                {" ", "*", "*", "*", "*", "*", " "},
            };
            SetExit(labyrinth, 5, 3);
            isFound = false;
            FindExit(labyrinth, row, col, 0, ref isFound);
            Console.WriteLine("In labirinth path between [{0}, {1}] and[13, 44] EXIST: {2}", row, col, isFound);
            Console.WriteLine();
        }
    }

