using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OccurencesOfNumInArray
{
    class OccurencesOfNumInArray
    {
        static void Main(string[] args)
        {
            double[] someArrOfDoubles = { 2.5, 3.6, 6.8, 8.9, 9.8, 2.5, 3.6, 2.5, 6.8 };
            Dictionary<double, int> dictionary = new Dictionary<double, int>();

            foreach (var number in someArrOfDoubles)
            {
                int count = 0;
                if (dictionary.ContainsKey(number))
                {
                    count = dictionary[number];
                }
                dictionary[number] = count + 1;
            }

            foreach (KeyValuePair<double, int> item in dictionary)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}
