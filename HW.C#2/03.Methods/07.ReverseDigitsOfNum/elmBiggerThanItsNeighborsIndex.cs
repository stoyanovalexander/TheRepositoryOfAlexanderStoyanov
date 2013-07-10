using System;
    class elmBiggerThanItsNeighborsIndex
    {
        static int CompareNeighbors(int[] array)
        {
            if (array[0] > array[1])
            {
                return 0;
            }

            for (int i = 1; i < array.Length-1; i++)
            {
                if ((array[i] > array[i + 1]) && (array[i] > array[i - 1]))
                {
                    return i;
                }
            }

            if (array[array.Length - 1] > array[array.Length - 2])
            {
                return array.Length - 1;
            }

                return -1;
        }
        static void Main()
        {
            Console.Write("Enter arrLen=");
            int arrLen = int.Parse(Console.ReadLine());
            int[] someArr = new int[arrLen];
            Console.WriteLine("Enter someArr");
            // Fill the array
            for (int i = 0; i < arrLen; i++)
            {
                someArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The position of first element bigger than its neighbors → " + CompareNeighbors(someArr));
        }
    }

