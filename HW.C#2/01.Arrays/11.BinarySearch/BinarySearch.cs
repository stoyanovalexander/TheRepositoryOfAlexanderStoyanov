using System;
    class BinarySearch
    {
        static int BinarySearching(int[] arr, int num)
        {
            int indexMin = 0;
            int indexMax = arr.Length - 1;
            int indexMid = 0;
            while (indexMax >= indexMin)
            {
                indexMid = (indexMin + indexMax) / 2;
                if (num >arr[indexMid])
                {
                    indexMin = indexMid + 1;
                }
                else if (num < arr[indexMid])
                {
                    indexMax = indexMid - 1;
                }
                else // if(indexMid==num)
                {
                    return indexMid;
                }
            }
            return -1;
        }
        static void Main()
        {
            Console.Write("Enter arrLen=");
            int arrLen = int.Parse(Console.ReadLine());
            Console.Write("Enter theNum=");
            int theNum = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLen];
            // Fill the array which must contain theNum
            for (int i = 0; i < arrLen; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // Solve
            Console.Write("The possition of theNum is: ");
            Console.Write(BinarySearching(arr,theNum));
            Console.WriteLine();
        }
    }
 
