using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public static class IEnumerableExtended
    {
        public static T Sum<T>(this IEnumerable<T> someListOfValues) where T : IComparable
        {
            dynamic sum = 0;
            foreach (var item in someListOfValues)
            {
                sum += item;
            }
                return sum;
        }

        public static T Product<T>(this IEnumerable<T> someListOfValues) where T : IComparable
        {
            dynamic product = 1;

            foreach (var item in someListOfValues)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> someListOfValues) where T : IComparable
        {
            dynamic min = int.MaxValue;

            foreach (var item in someListOfValues)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> someListOfValues) where T : IComparable
        {
            dynamic max = int.MinValue;

            foreach (var item in someListOfValues)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> someListOfValues) where T : IComparable
        {
            dynamic sum = 0;
            int count = someListOfValues.Count();
            foreach (var item in someListOfValues)
            {
                sum += item;
            }

            return sum / count;
        }
    }

