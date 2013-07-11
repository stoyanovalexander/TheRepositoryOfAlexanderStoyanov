using System;
using System.Collections.Generic;
using System.Linq;


public static class SetOfExtensionMethods
{
    public static T Sum<T>(this IEnumerable<T> enumerableToSum)
    {
        dynamic sum = default(T);
        if (enumerableToSum == null)
        {
            throw new ArgumentNullException("The List cannot be null");
        }
        else
        {
            foreach (var item in enumerableToSum)
            {
                sum += item;
            }
            return sum;
        }
    }

    public static T Product<T>(this IEnumerable<T> enumerableToProduct)
    {
        dynamic product = 1;
        if (enumerableToProduct == null)
        {
            throw new ArgumentNullException("The List cannot be null");
        }
        else
        {
            foreach (var item in enumerableToProduct)
            {
                product *= item;
            }
            return product;
        }
    }

    public static T MinValue<T>(this IEnumerable<T> enumerableToMinValue)
    {
        dynamic minValue = default(T);
        if (enumerableToMinValue == null || !enumerableToMinValue.Any())
        {
            throw new ArgumentNullException("The List cannot be null or empty");
        } 
        else
        {
            foreach (var item in enumerableToMinValue)
            {
                if (minValue > item)
                {
                    minValue = item;
                }
            }
            return minValue;
        }
    }

    public static T MaxValue<T>(this IEnumerable<T> enumerableToMaxValue)
    {
        dynamic maxValue = default(T);
        if (enumerableToMaxValue == null || !enumerableToMaxValue.Any())
        {
            throw new ArgumentNullException("The List cannot be null or empty");
        }
        else
        {
            foreach (var item in enumerableToMaxValue)
            {
                if (maxValue < item)
                {
                    maxValue = item;
                }
            }
            return maxValue;
        }
    }

    public static T Average<T>(this IEnumerable<T> enumerableToAverage)
    {
        dynamic sum = default(T);
        dynamic count = default(T);

        if (enumerableToAverage == null)
        {
            throw new ArgumentNullException("The List cannot be null");
        }
        else
        {
            foreach (var item in enumerableToAverage)
            {
                sum += item;
                count++;
            }

            dynamic average = sum / count;

            return average;
        }
    }

    public static void SetOfMethods<T>(this IEnumerable<T> enumerable)
    {
        Console.WriteLine("IEnumerable<T> parameters:");
        Console.WriteLine("==========================\n");
        Console.WriteLine("Sum of elements: {0}", enumerable.Sum());
        Console.WriteLine("Product ot elements: {0}", enumerable.Product());
        Console.WriteLine("Minimal Value: {0}", enumerable.MinValue());
        Console.WriteLine("Maximal Value: {0}", enumerable.MaxValue());
        Console.WriteLine("Average Value: {0}\n", enumerable.Average());
    }
}