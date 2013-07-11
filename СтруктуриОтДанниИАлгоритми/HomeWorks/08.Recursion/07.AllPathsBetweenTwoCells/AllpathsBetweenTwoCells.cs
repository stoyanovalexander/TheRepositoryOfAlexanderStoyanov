﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class AllpathsBetweenTwoCells
    {
        static string[,] labyrinth = 
        {
            {" ", "*", " ", "*", " ", " ", "*"},
            {"*", "*", " ", "*", " ", "*", " "},
            {" ", "*", " ", " ", " ", " ", " "},
            {" ", "*", "*", " ", "*", " ", " "},
            {" ", " ", " ", " ", " ", " ", "*"},
        };

        static void FindExit(int row, int col, int step)
        {
            if (row < 0 || col < 0 ||
                row >= labyrinth.GetLength(0) || col >= labyrinth.GetLength(1))
            {
                return;
            }

            if (labyrinth[row, col] == "e")
            {
                Console.WriteLine("Exit found at [{0},{1}]", row, col);
                PrintLabyrint();
            }

            if (labyrinth[row, col] != " ")
            {
                return;
            }

            labyrinth[row, col] = step.ToString();
            step++;
            FindExit(row, col - 1, step);
            FindExit(row - 1, col, step);
            FindExit(row, col + 1, step);
            FindExit(row + 1, col, step);

            labyrinth[row, col] = " ";
        }

        static void SetExit(int row, int col)
        {
            labyrinth[row, col] = "e";
        }

        static void PrintLabyrint()
        {
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    Console.Write("{0, 2} ", labyrinth[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main()
        {
            SetExit(0, 5);
   
            int row = 2;
            int col = 2;

            FindExit(row, col, 0);
        }
    }

