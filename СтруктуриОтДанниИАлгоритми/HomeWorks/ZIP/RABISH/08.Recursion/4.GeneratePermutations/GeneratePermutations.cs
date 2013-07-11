using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class GeneratePermutations
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
                Console.Write("(");
                for (int i = 0; i <= len; i++)
                {
                    if (i == arr.Length)
                    {
                        Console.Write(arr[i]);
                    }
                    else {
                        Console.Write(arr[i] + " ");
                    }
                }
                Console.Write("), ");




                //Console.Write("(");

                //for (int j = 0; j < arr.Length; j++)
                //{
                //    if (j == arr.Length - 1)
                //    {
                //        Console.Write(arr[j]);
                //    }
                //    else
                //    {
                //        Console.Write(arr[j] + " ");
                //    }
                //}
                //Console.Write("), ");
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
            Console.Write("enter some number n: ");
            int n = int.Parse(Console.ReadLine());
            int[] theNumbers = new int[n];
            Console.Write("n=" + n + "→");
            for (int i = 1; i <= n; i++)
            {
                theNumbers[i - 1] = i;
            }
            Permute(theNumbers, 0, theNumbers.Length - 1);
        }
    }

