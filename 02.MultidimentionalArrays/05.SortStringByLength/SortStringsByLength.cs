using System;
    class SortStringsByLength
    {
        static void Main(string[] args)
        {
            Console.Write("Enter arrLen= ");
            int arrLen = int.Parse(Console.ReadLine());
            string[] arrToSort = new string[arrLen];
            int[] length = new int[arrLen];
            for (int i = 0; i < arrLen; i++)
            {
                Console.Write("arrToSortByLen[{0}]= ",i);
                arrToSort[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            SortingByLength(arrToSort);
            for (int i = 0; i < arrLen; i++)
            {
                Console.Write("arrSorted[{0}]= ",i);
                Console.Write(arrToSort[i]);
                Console.WriteLine();
            }
        }
        static string[] SortingByLength(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Length > array[j].Length)
                    {
                        string forChange = array[i];
                        array[i] = array[j];
                        array[j] = forChange;

                    }
                }
            }
            return array;
        }
    }

