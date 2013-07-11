using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SubsetsOfKElements
{
    class SubsetsOfKElements
    {
        static string[] set = { "si", "hu", "do", "iv" };
        static void GenerateSubsets(int startIndex, int index, string[] result, string[] setOfStrings)
        {
            if (index > result.Length - 1)
            {
                PrintArray(result);
            }
            else
            {
                for (int i = startIndex; i < setOfStrings.Length; i++)
                {
                    if (index < result.Length)
                    {
                        result[index] = setOfStrings[i];
                    }
                    GenerateSubsets(i + 1, index + 1, result, setOfStrings);
                }
            }
        }

        static void PrintArray(string[] subSet)
        {
            Console.Write("(");
            for (int i = 0; i < subSet.Length; i++)
            {
                if (i == subSet.Length - 1)
                {
                    Console.Write(subSet[i]);
                }
                else
                {
                    Console.Write(subSet[i] + "  ");
                }
            }
            Console.Write("), ");
        }

        static void Main()
        {
            Console.WriteLine("Enter[1,4] k:");
            int k = int.Parse(Console.ReadLine());
            Console.Write("set{");
            for (int i = 0; i < set.Length - 1; i++)
            {
                Console.Write(set[i] + ", ");
            }
            Console.Write(set[set.Length - 1] + "}");
            Console.Write(", k=" + k + " ");
            Console.WriteLine();

            string[] result = new string[k];
            GenerateSubsets(0, 0, result, set);
            Console.WriteLine();
        }
    }
}
