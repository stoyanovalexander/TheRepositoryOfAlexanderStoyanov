using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 5, 7, 3, 15, 49, 21, 5, 28, 15, 140, 210 };
        var someNUmbers = arr.ToList().FindAll(x => ((x % 3 == 0) && (x % 7 == 0)));
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" {0}", arr[i]);
        }
        Console.WriteLine();
        foreach (var item in someNUmbers)
        {
            Console.Write(" {0}", item);
        }
        var someNumbersLinq =
            from number in arr
            where ((number % 7 == 0) && (number % 3 == 0))
            select number;
        Console.WriteLine();
        foreach (var item in someNumbersLinq)
        {
            Console.Write(" {0}", item);
        }
        Console.WriteLine();
    }
}