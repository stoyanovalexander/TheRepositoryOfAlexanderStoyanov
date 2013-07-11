using System;
using System.Collections.Generic;
using System.Linq;

    class ImplementmyLinkedList
    {
        static void Main()
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();
            myLinkedList.AddFirst(1);
            myLinkedList.AddLast(5000);
            myLinkedList.AddFirst(10);
            myLinkedList.AddLast(500);
            myLinkedList.AddAfter(myLinkedList.FirstElement.NextItem, 100000000);
            myLinkedList.AddBefore(myLinkedList.FirstElement.NextItem, 500000000);
            myLinkedList.PrintList();
            Console.WriteLine("the count={0}",myLinkedList.Count);

            Console.WriteLine();
            Console.WriteLine("after removing of some elements");
            myLinkedList.RemoveFirst();
            myLinkedList.RemoveLast();
            myLinkedList.PrintList();
            Console.WriteLine("the count={0}",myLinkedList.Count); 
        }
    }

