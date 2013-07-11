using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ImplementPriorityQueue
    {
        static void Main()
        {
            PriorityQueue<int> siabongasPriorityQueue = new PriorityQueue<int>();

            siabongasPriorityQueue.Enqueue(10);
            siabongasPriorityQueue.Enqueue(12);
            siabongasPriorityQueue.Enqueue(15);
            siabongasPriorityQueue.Enqueue(14);
            siabongasPriorityQueue.Enqueue(13);
            Console.WriteLine("Peek is: {0} ", siabongasPriorityQueue.Peek());
            
            siabongasPriorityQueue.Dequeue();
            Console.WriteLine("Peek after dequeue is: {0}", siabongasPriorityQueue.Peek());

            siabongasPriorityQueue.Enqueue(15);
            siabongasPriorityQueue.Enqueue(20);
            siabongasPriorityQueue.Enqueue(12);
            siabongasPriorityQueue.Enqueue(11);
            Console.WriteLine("Peak after few more enqueues is: {0} ", siabongasPriorityQueue.Peek());
        }
    }

