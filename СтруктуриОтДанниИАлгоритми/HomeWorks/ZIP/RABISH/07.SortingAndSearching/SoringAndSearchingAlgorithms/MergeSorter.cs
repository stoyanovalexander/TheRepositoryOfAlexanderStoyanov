using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoringAndSearchingAlgorithms
{
    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("The list can not be null!");
            }

            IList<T> sortedList = this.MergeSort(list);

            list.Clear();
            foreach (T item in sortedList)
            {
                list.Add(item);
            }
        }

        private IList<T> MergeSort(IList<T> list)
        {
            if (list.Count <= 1) 
            {
                return list;
            }

            int middle = list.Count / 2;

            IList<T> left = new List<T>();
            for (int index = 0; index < middle; index++)
            {
                left.Add(list[index]);
            }

            IList<T> right = new List<T>(); 
            for (int index = middle; index < list.Count; index++)
            {
                right.Add(list[index]);
            }

            left = this.MergeSort(left);
            right = this.MergeSort(right);

            return this.Merge(left, right);
        }

        private IList<T> Merge(IList<T> left, IList<T> right)
        {
            IList<T> mergedCollection = new List<T>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0].CompareTo(right[0]) <= 0)
                    {
                        mergedCollection.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        mergedCollection.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                else if (right.Count > 0)
                {
                    mergedCollection.Add(right[0]);
                    right.RemoveAt(0);
                }
                else if (left.Count > 0)
                {
                    mergedCollection.Add(left[0]);
                    left.RemoveAt(0);
                }
            }

            return mergedCollection;
        }
    }
}
