using System;
class Permutations
{
    static void Swap(ref int first, ref int second)
    {
        int forSwap = first;
        first = second;
        second = forSwap;
    }
    static void Permute(int[] arr, int current, int len)
    {
        if (current == len)
        {
            for (int i = 0; i <= len; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = current; i <= len; i++)
            {
                Swap(ref arr[i], ref arr[current]);
                Permute(arr, current + 1, len);
                Swap(ref arr[i], ref arr[current]);
            }
        }
    }
    static void Main(string[] args)
    {
        Console.Write("enter some number num= ");
        int num = int.Parse(Console.ReadLine());
        int[] theNumbers = new int[num];
        for (int i = 1; i <= num; i++)
        {
            theNumbers[i - 1] = i;
        }
        Permute(theNumbers, 0, theNumbers.Length - 1);
    }
}

