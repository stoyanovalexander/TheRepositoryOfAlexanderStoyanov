using System;
using System.Collections.Generic;
class AllCombinations
{
    static int N = int.Parse(Console.ReadLine());
    static int K = int.Parse(Console.ReadLine());
    static void MakeCombination(int[] arr, int index, int currentNum)
    {
        if (index == arr.Length)
        {
            PrintArray(arr);
        }
        else
        {
            for (int i = currentNum; i <= N; i++)
            {
                arr[index] = i;
                MakeCombination(arr, index + 1, i + 1);
            }
        }
    }
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] combinationArr = new int[K];
        MakeCombination(combinationArr, 0, 1);
    }
}