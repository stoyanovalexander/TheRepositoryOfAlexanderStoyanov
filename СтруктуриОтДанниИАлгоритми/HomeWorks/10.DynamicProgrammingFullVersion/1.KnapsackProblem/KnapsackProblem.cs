using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Product[] products = new Product[]{
                                    new Product("Shugar", 3, 2),
                                    new Product("Vodka", 8, 12),
                                    new Product("Cheese", 4, 5),
                                    new Product("Nuts", 1, 2),
                                    new Product("Wine", 2, 4),
                                    new Product("Wiskey", 7, 13)
        };

        int capacity = 10;
        Console.Write("Best choice: ");
        Console.WriteLine(String.Join(" ", FindOptimalSolutionDynamic(products, capacity).Select(r => r.Name)));
        //Console.WriteLine("Recursive: " + String.Join(" ", FindOptimalSolutionRecursive(products, capacity).Select(r => r.Name)));

    }

    public static List<Product> FindOptimalSolutionDynamic(Product[] products, int capacity)
    {
        // for the recursive implementation

        if (capacity == 0)
            return new List<Product>();

        if (products.Length == 0)
            return new List<Product>();


        // row X contains the maximal value using products[0..X]
        // valuesArray[X,Y]: contains the maximal value for capacity = Y using products[0..X]

        // the max solution using products[0..X+1] for capacity Y is:
        // (let currentproduct = products[X+1])
        // a) the max solution for the same capacity without currentproduct, i.e. valuesArray[X,Y]
        // b) the max solution for capacity (Y - currentproduct.Weight), without currentproduct, + currentproduct.Value
        // i.e. valuesArray[X,Y - currentproduct.Weight] + currentproduct.Value

        int[,] valuesArray = new int[products.Length, capacity + 1];

        // keepArray[X,Y]: if product X is included in the maximal solution for capacity Y

        int[,] keepArray = new int[products.Length, capacity + 1];


        // fill the base cases 

        // capacity 0 => maximum solution is 0, with no products taken

        for (int x = 0; x <= products.Length - 1; x++)
        {
            valuesArray[x, 0] = 0;
            keepArray[x, 0] = 0;
        }

        // only 1 product => either we take it or we don't

        for (int y = 1; y <= capacity; y++)
        {
            if (products[0].Weight <= y)
            {
                valuesArray[0, y] = products[0].Value;
                keepArray[0, y] = 1;
            }
            else
            {
                valuesArray[0, y] = 0;
                keepArray[0, y] = 0;
            }
        }


        // now fill the table

        for (int x = 0; x <= products.Length - 2; x++)
        {
            for (int y = 1; y <= capacity; y++)
            {
                var currentproduct = products[x + 1];

                if (currentproduct.Weight > y)
                    continue;

                // decide whether we take or drop the current product


                int valueWhenDropping = valuesArray[x, y];
                int valueWhenTaking = valuesArray[x, y - currentproduct.Weight] + currentproduct.Value;

                // which is better?

                if (valueWhenTaking > valueWhenDropping)
                {
                    valuesArray[x + 1, y] = valueWhenTaking;
                    keepArray[x + 1, y] = 1;
                }
                else
                {
                    valuesArray[x + 1, y] = valueWhenDropping;
                    keepArray[x + 1, y] = 0;
                }
            }
        }

        // debug output
        // PrintMatrix(valuesArray, products.Length - 1, products);
        // PrintMatrix(keepArray, products.Length - 1, products);


        // the maximal value is in cell [products.Length - 1, capacity]
        // find the products that make up the optimal solution by walking
        // back through keepArray

        var bestproducts = new List<Product>();

        {
            int remainingSpace = capacity;
            int product = products.Length - 1;

            while (product >= 0 && remainingSpace >= 0)
            {
                // if we've taken the product

                if (keepArray[product, remainingSpace] == 1)
                {
                    // go up and left

                    bestproducts.Add(products[product]);
                    remainingSpace -= products[product].Weight;
                    product -= 1;
                }
                else
                {
                    // else go up

                    product -= 1;
                }
            }
        }

        return bestproducts;
    }

    //public static List<Product> FindOptimalSolutionRecursive(Product[] products, int capacity)
    //{
    //    // base cases

    //    if (capacity <= 0 || products.Length == 0)
    //        return new List<Product>();


    //    // decide whether we take or drop the current product

    //    var x = products.Length - 1;
    //    var currentproduct = products[x];

    //    var bestWhenDropping = FindOptimalSolutionRecursive(products.Take(x).ToArray(), capacity);

    //    if (capacity < currentproduct.Weight)
    //        return bestWhenDropping;

    //    var bestWhenTaking = FindOptimalSolutionRecursive(products.Take(x).ToArray(), capacity - currentproduct.Weight);

    //    bestWhenTaking.Add(currentproduct);


    //    var valueWhenTaking = bestWhenTaking.Sum(i => i.Value);
    //    var valueWhenDropping = bestWhenDropping.Sum(i => i.Value);

    //    if (valueWhenTaking > valueWhenDropping)
    //    {
    //        return bestWhenTaking;
    //    }
    //    else
    //    {
    //        return bestWhenDropping;
    //    }
    //}

    //// hacky debugging helper
    //public static void PrintMatrix(int[,] mx, int untilRow, Product[] products)
    //{
    //    const int FOO = 8;
    //    // Console.Write(new string(' ', FOO));

    //    Console.Write("R W  V |");

    //    for (int col = 0; col < mx.GetLength(1); ++col)
    //    {
    //        Console.Write((col + "").PadLeft(2, ' ').PadRight(3, ' '));
    //    }
    //    Console.WriteLine();
    //    Console.WriteLine(new string('-', FOO + mx.GetLength(1) * 3));

    //    for (int row = 0; row <= untilRow; ++row)
    //    {
    //        Console.Write("{0} ", row);
    //        Console.Write("{0:0} ", products[row].Weight);
    //        Console.Write("{0:0} |", (products[row].Value + "").PadLeft(2, ' '));

    //        for (int col = 0; col < mx.GetLength(1); ++col)
    //        {
    //            Console.Write("{0:00} ", mx[row, col]);
    //        }
    //        Console.WriteLine();
    //    }
    //    Console.WriteLine();

    //}
}