/* Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the 
 * built-in extension methods and lambda expressions. Rewrite the same with LINQ.
 */


using System;
using System.Linq;

class DivisibleBy7and3
{
    static void Main()
    {
        int[] array = new int[100];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }

        //Select divisible numbers using LINQ
        var divisible1 =
            from number in array
            where number % 7 == 0 && number % 3 == 0
            select number;

        Console.WriteLine("Print divisible of 7 and 3 with LINQ");
        Console.WriteLine("====================================");
        foreach (var item in divisible1)
        {
            Console.WriteLine(item);
        }

        //Select divisible numbers using Lambda Expression
        var divisible2 = array
            .Where(x => x % 7 == 0 && x % 3 == 0)
            .Select(x => x);     

        Console.WriteLine("\nPrint divisible of 7 and 3 with Lambda Expression");
        Console.WriteLine("=================================================");
        foreach (var item in divisible2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}

