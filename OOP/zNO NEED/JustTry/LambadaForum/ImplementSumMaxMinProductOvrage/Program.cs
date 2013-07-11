using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementSumMaxMinProductOvrage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            numbers[0] = 1;

            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Product());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Average());
        }
    }
}
