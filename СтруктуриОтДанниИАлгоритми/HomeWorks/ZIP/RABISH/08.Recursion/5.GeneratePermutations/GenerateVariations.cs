using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.GeneratePermutations
{
    class GenerateVariations
    {
        //static int K = int.Parse(Console.ReadLine());
        static string[] set={"si","hu","do","iv"};
        static void MakeVariation(string[] arr, int index)
        {
            if (index == arr.Length)
            {
                PrintArray(arr);
            }
            else
            {
                for (int i = 0; i < set.Length; i++)
                {
                    arr[index] = set[i];
                    MakeVariation(arr, index + 1);
                }
            }
        }
        static void PrintArray(string[] arr)
        {
            Console.Write("(");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i]);
                }
                else {
                    Console.Write(arr[i]+"  ");
                }
            }
            Console.Write("), ");
        }
        static void Main()
        {
            Console.WriteLine("Enter k:");
            int k = int.Parse(Console.ReadLine());
            int n = set.Length;
            Console.WriteLine();
            Console.Write("n="+n+", ");
            Console.Write("k="+k+", ");
            Console.Write("set{");
            for (int i = 0; i < set.Length-1; i++)
            {
                Console.Write(set[i]+", ");
            }
            Console.Write(set[set.Length-1]+"}=>");

            string[] variations = new string[k];
            MakeVariation(variations, 0);
            Console.WriteLine();
        }
    }
}
