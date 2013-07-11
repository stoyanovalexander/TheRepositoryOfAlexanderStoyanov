using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CombinationsWithDuplicates
    {
        static void MakeCombination(int[] arr, int index, int currentNum, int n)
        {
            if (index == arr.Length)
            {
                PrintArray(arr, n);
            }
            else
            {
                for (int i = currentNum; i <= n; i++)
                {
                    arr[index] = i;
                    MakeCombination(arr, index + 1, i , n);
                }
            }
        }
        static void PrintArray(int[] arr, int n)
        {
            Console.Write("(");

            for (int j = 0; j < arr.Length; j++)
            {
                if (j == arr.Length - 1)
                {
                    Console.Write(arr[j]);
                }
                else
                {
                    Console.Write(arr[j] + " ");
                }
            }
            Console.Write("), ");


        }
        static void Main()
        {
            Console.WriteLine("Enter value for n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter and value for k:");
            int k = int.Parse(Console.ReadLine());

            Console.Write("n={0}", n);
            Console.Write(", ");
            Console.Write("k={0}", k);
            Console.Write("→");
            int[] combinationArr = new int[k];
            MakeCombination(combinationArr, 0, 1, n);
            Console.WriteLine();
        }
    }
