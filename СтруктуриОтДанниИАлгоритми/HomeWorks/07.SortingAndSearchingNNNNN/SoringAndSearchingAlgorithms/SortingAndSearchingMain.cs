using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoringAndSearchingAlgorithms
{
    class SortingAndSearchingMain
    {
        static void Main()
        {
            var unsortedCollectionOne = new SortableCollection<int>(new[] { 3, 5, 8, 11, 2, 9, 111, 21, 333, 44 });
            Console.Write("unsortedCollectionOne: ");
            for (int i = 0; i < unsortedCollectionOne.Items.Count; i++)
            {
                Console.Write(unsortedCollectionOne.Items[i]+" ");
            }
            Console.WriteLine();

            Console.Write("unsortedCollectionOne after use of SelectionSorter: ");
            unsortedCollectionOne.Sort(new SelectionSorter<int>());
            for (int i = 0; i < unsortedCollectionOne.Items.Count; i++)
            {
                Console.Write(unsortedCollectionOne.Items[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            var unsortedCollectionTwo = new SortableCollection<int>(new[] { 7, 5, 8, 11, 2, 9, 1, 21, 3, 44 });
            Console.Write("unsortedCollectionTwo: ");
            for (int i = 0; i < unsortedCollectionOne.Items.Count; i++)
            {
                Console.Write(unsortedCollectionOne.Items[i] + " ");
            }
            Console.WriteLine();

            Console.Write("unsortedCollectionTwo after use of QuickSorter: ");
            unsortedCollectionTwo.Sort(new Quicksorter<int>());
            for (int i = 0; i < unsortedCollectionTwo.Items.Count; i++)
            {
                Console.Write(unsortedCollectionTwo.Items[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            var unsortedCollectionThree = new SortableCollection<int>(new[] { 10, 5, 56, 11, 2, 9, 9, 21, 3, 99 });
            Console.Write("unsortedCollectionThree: ");
            for (int i = 0; i < unsortedCollectionThree.Items.Count; i++)
            {
                Console.Write(unsortedCollectionThree.Items[i] + " ");
            }
            Console.WriteLine();

            Console.Write("unsortedCollectionThree after use of MergeSorter: ");
            unsortedCollectionThree.Sort(new Quicksorter<int>());
            for (int i = 0; i < unsortedCollectionThree.Items.Count; i++)
            {
                Console.Write(unsortedCollectionThree.Items[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Linear search in unsortedCollectionThree 'after sorting' of 21->");
            Console.Write(unsortedCollectionThree.LinearSearch(21));
            Console.WriteLine();
            Console.Write("Linear search in unsortedCollectionThree 'after sorting' of 12345678->");
            Console.Write(unsortedCollectionThree.LinearSearch(12345678));
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Binary search in unsortedCollectionThree 'after sorting' of 21->");
            Console.Write(unsortedCollectionThree.BinarySearch(21));
            Console.WriteLine();
            Console.Write("Binary search in unsortedCollectionThree 'after sorting' of 12345678->");
            Console.Write(unsortedCollectionThree.BinarySearch(12345678));
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Shuffle:");
            unsortedCollectionThree.Shuffle();
            for (int i = 0; i < unsortedCollectionThree.Items.Count; i++)
            {
                Console.Write(unsortedCollectionThree.Items[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
