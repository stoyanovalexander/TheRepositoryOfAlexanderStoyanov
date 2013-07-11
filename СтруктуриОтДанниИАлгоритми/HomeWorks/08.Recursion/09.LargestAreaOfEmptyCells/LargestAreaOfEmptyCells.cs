using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class LargestAreaOfEmptyCells
    {
        static string[,] labyrinth = 
        {
            {" ", " ", " ", "*", " ", " ", " "},
            {"*", "*", " ", "*", " ", "*", " "},
            {" ", "*", " ", " ", " ", " ", " "},
            {" ", "*", "*", "*", "*", "*", " "},
            {" ", " ", " ", "*", " ", " ", " "},
        };

        static void FindBiggestArea(int rows, int cols)
        {
            int step = 0;
            int area = 0;
            int maxArea = 0;
            int number = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (labyrinth[i, j] == " ")
                    {
                        FindArea(i, j, step, ref area);
                        if (area >= maxArea)
                        {
                            maxArea = area;
                            number = step;
                        }
                        area = 0;
                        step++;
                    }
                }
            }

            PrintLabyrint(number.ToString());
            Console.Write("Biggest area is {0}'s=", number);
            Console.WriteLine(maxArea);
        }


        static void FindArea(int row, int col, int step, ref int count)
        {
            if (row < 0 || col < 0 ||
                row >= labyrinth.GetLength(0) || col >= labyrinth.GetLength(1))
            {
                return;
            }

            if (labyrinth[row, col] != " ")
            {
                return;
            }

            labyrinth[row, col] = step.ToString();
            count++;

            FindArea(row, col - 1, step, ref count);
            FindArea(row - 1, col, step, ref count);
            FindArea(row, col + 1, step, ref count);
            FindArea(row + 1, col, step, ref count);
        }

        static void PrintLabyrint(string number)
        {
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i, j] == number || labyrinth[i, j] == "*")
                    {
                        Console.Write("{0, 2} ", labyrinth[i, j]);
                    }
                    else
                    {
                        Console.Write("{0, 2} ", " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            FindBiggestArea(labyrinth.GetLength(0), labyrinth.GetLength(1));
        }
    }

