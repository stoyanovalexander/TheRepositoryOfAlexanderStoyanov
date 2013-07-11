using System;
using System.Collections.Generic;
using System.Linq;

class KnapsackProblem
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
    }

    public static List<Product> FindOptimalSolutionDynamic(Product[] products, int capacity)
    {
        if (capacity == 0)
        {
            return new List<Product>();
        }

        if (products.Length == 0)
        {
            return new List<Product>();
        }

        int[,] valuesArray = new int[products.Length, capacity + 1];
        int[,] keepArray = new int[products.Length, capacity + 1];
        for (int x = 0; x <= products.Length - 1; x++)
        {
            valuesArray[x, 0] = 0;
            keepArray[x, 0] = 0;
        }

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

        for (int x = 0; x <= products.Length - 2; x++)
        {
            for (int y = 1; y <= capacity; y++)
            {
                var currentproduct = products[x + 1];

                if (currentproduct.Weight > y)
                {
                    continue;
                }
                int valueWhenDropping = valuesArray[x, y];
                int valueWhenTaking = valuesArray[x, y - currentproduct.Weight] + currentproduct.Value;

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

        var bestproducts = new List<Product>();
        {
            int remainingSpace = capacity;
            int product = products.Length - 1;
            while (product >= 0 && remainingSpace >= 0)
            {
                if (keepArray[product, remainingSpace] == 1)
                {
                    bestproducts.Add(products[product]);
                    remainingSpace -= products[product].Weight;
                    product -= 1;
                }
                else
                {
                    product -= 1;
                }
            }
        }

        return bestproducts;
    }
}