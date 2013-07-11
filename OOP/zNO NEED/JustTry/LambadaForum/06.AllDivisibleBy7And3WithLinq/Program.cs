using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.AllDivisibleBy7And3WithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            var selectedNums =
            from num in numbers
            where num % 21 == 0
            select num;

            foreach (var num in selectedNums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
