using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoringAndSearchingAlgorithms
{
    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("The list can not be null!");
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                int minElementIndex = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j].CompareTo(list[minElementIndex]) < 0)
                    {
                        minElementIndex = j;
                    }
                }

                if (minElementIndex != i)
                {
                    T swap = list[i];
                    list[i] = list[minElementIndex];
                    list[minElementIndex] = swap;
                }
            }
        }
    }
}
