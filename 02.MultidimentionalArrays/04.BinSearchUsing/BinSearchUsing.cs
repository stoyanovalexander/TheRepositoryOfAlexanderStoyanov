using System;
class BinSearchUsing
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter INT number arr[{0}]= ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(arr);
        if (arr[0] > k)
        {
            Console.WriteLine("There are no smoller numbers than k ");
        }
        else
        {
            int result;
            int IndexOfElement = Array.BinarySearch(arr, k);
            if (IndexOfElement >= 0)
            {
                result = arr[IndexOfElement];
            }
            else
            {
                result = arr[~IndexOfElement - 1];
            }
            Console.WriteLine("[The latgest number in this array <=k] = " + result);
        }
    }
}