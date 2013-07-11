using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class IEnumerableExtensions
{
   public static T MinEl<T>(this IEnumerable<T> enumaration)
        where T : IComparable<T>
    {
        T min=default(T);
        bool isSet = false;
        foreach (T item in enumaration)
        {
            if (!isSet)
            {
                isSet = true;
                min = item;
                continue;
            }
            if (item.CompareTo(min) < 0)
            {
                min = item;
            }
        }
        return min;
    }
   public static T MaxEl<T>(this IEnumerable<T> enumaration)
        where T : IComparable<T>
    {
        T max=default(T);
        bool isSet = false;
        foreach (T item in enumaration)
        {
            if (!isSet)
            {
                isSet = true;
                max = item;
                continue;
            }
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }
        return max; 
    }
   public static T AverageEl<T>(this IEnumerable<T> enumaration)
    {
        dynamic sum = 0;
        int count = 0;
        foreach (T item in enumaration)
        {
            count++;
            sum = sum + item;        
        }
        return (sum /count);
    }
   public static T ProductEl<T>(this IEnumerable<T> enumaration)
    {
        dynamic product = 1;
        foreach (T item in enumaration)
        {
            product = product * item;
        }
        return product;
    }
}
class Program
{
    static void Main(string[] args)
    {
        double[] arr = new double[] { 1d, 2d, 3d };
        Console.WriteLine("Min={0}", arr.MinEl());
        Console.WriteLine("Max={0}", arr.MaxEl());
        Console.WriteLine("Average={0}", arr.AverageEl());
        Console.WriteLine("Product={0}", arr.ProductEl());
    }
}

