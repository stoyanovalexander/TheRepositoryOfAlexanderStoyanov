using System;
class Variations
{
    static int N = int.Parse(Console.ReadLine());
    static int K = int.Parse(Console.ReadLine());
    static void MakeVariation(int[] arr, int index)
    {
        if (index == arr.Length)
        {
            PrintArray(arr);
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                arr[index] = i;
                MakeVariation(arr, index + 1);
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
        int[] variations = new int[K];
        MakeVariation(variations, 0);
    }
}
