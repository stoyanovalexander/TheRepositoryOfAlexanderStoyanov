using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoringAndSearchingAlgorithms
{
    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("The list can not be null!");
            }

            this.QuickSort(list, 0, list.Count - 1);
        }

        private void QuickSort(IList<T> list, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            int partitionIndex = this.Partition(list, startIndex, endIndex);
            this.QuickSort(list, startIndex, partitionIndex - 1);
            this.QuickSort(list, partitionIndex + 1, endIndex);
        }

        private int Partition(IList<T> list, int startIndex, int endIndex)
        {
            T pivot = list[endIndex];
            int index1 = startIndex - 1;
            for (int index2 = startIndex; index2 < endIndex; index2++)
            {
                if (list[index2].CompareTo(pivot) < 0)
                {
                    index1++;

                    T swap = list[index1];
                    list[index1] = list[index2];
                    list[index2] = swap;
                }
            }

            T swap1 = list[index1 + 1];
            list[index1 + 1] = list[endIndex];
            list[endIndex] = swap1;

            return index1 + 1;
        }
    }
}
