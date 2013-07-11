using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class RecursionInsteadNestedLoops
{

    //static int N = int.Parse(Console.ReadLine());
    static void MakeVariation(int[] arr, int index, int n)
    {
        if (index == arr.Length)
        {
            PrintArray(arr);
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                arr[index] = i;
                MakeVariation(arr, index + 1, n);
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
        Console.WriteLine("Enter ValueType for n:");
        int n = int.Parse(Console.ReadLine());
        int[] variations = new int[n];
        Console.WriteLine("n="+n+"->");
        Console.WriteLine();
        MakeVariation(variations, 0, n);

    }
}