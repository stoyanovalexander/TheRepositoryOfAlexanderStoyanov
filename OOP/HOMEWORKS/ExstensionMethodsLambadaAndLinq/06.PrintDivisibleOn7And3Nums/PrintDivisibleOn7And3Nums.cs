using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrintDivisibleOn7And3Nums
{
    class PrintDivisibleOn7And3Nums
    {
        static void Main(string[] args)
        {
            int[] someArr = new int[1001];
            for (int i = 0; i < someArr.Length; i++)
            {
                someArr[i] = i;
            }
            Console.WriteLine("WITH LAMBADA");
            LambadaChecking(someArr);
            Console.WriteLine();
            Console.WriteLine("WITH LINQ");
            LinqChecking(someArr);
        }

        static void LambadaChecking(int[] someArr)
        {
            var numsAfterCheck = someArr.Where(x => x % 21 == 0);
            foreach (var number in numsAfterCheck)
            {
                Console.WriteLine(number);
            }
        }

        static void LinqChecking(int[] someArr)
        {
            var numsAfterCheck =
                from number in someArr
                where number % 21 == 0
                select number;
            foreach (var number in numsAfterCheck)
            {
                Console.WriteLine(number);
            }
        }
    }
}
