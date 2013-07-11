using System;
using System.Collections.Generic;
using System.Linq;

    class ImplementQueue
    {
        static void Main()
        {
            LinkedQueue<string> myQueue = new LinkedQueue<string>();

            for (int i = 0; i < 10; i++)
            {
                myQueue.Push(i+" "+i+" "+i+" Siabonga Nomwete");
            }
            Console.WriteLine("the Peek:"+myQueue.Peek());
            Console.WriteLine("the count(after pushing)="+myQueue.Count);
            Console.WriteLine();

            int theCount = myQueue.Count; 
            //INTERESTING if I put myQueue.Count in the "for" directly then "pop" not all but the half of elements in myQueue
            for (int i = 0; i < theCount; i++)
            {
                Console.WriteLine(myQueue.Pop());
            }

            Console.WriteLine();
            Console.WriteLine("the count(after poping all)="+myQueue.Count);
            Console.WriteLine();
        }
    }

