/* Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
 * sum, product, min, max, average.
 */

using System;
using System.Collections.Generic;


class ExtensionMethodsUI
{
    static void Main()
    {
        List<int> age = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            age.Add(i * 5);
        }

        age.SetOfMethods();

        int[] products = new int[5];

        for (int i = 0; i < products.Length; i++)
        {
            products[i] = i+1;
        }

        products.SetOfMethods();
    }
}

