using System;
class BinarySearch
{
    static int BinSearch(int[] arr, int theNum)
    {
        int iMax = arr.Length - 1;
        int iMin = 0;
        while (iMax >= iMin)
        {
            int iMidpoint = (iMin + iMax) / 2;
            if (arr[iMidpoint] < theNum)
            {
                iMin = iMidpoint + 1;
            }
            else if (arr[iMidpoint] > theNum)
            {
                iMax = iMidpoint - 1;
            }
            else
            {
                return iMidpoint;
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
        // TheSolve
        Console.WriteLine(BinSearch(arr, theNum));
    }
}

 