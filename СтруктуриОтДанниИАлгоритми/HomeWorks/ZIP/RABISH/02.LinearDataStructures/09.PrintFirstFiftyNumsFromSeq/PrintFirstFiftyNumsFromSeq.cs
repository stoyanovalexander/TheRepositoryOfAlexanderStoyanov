using System;
using System.Collections.Generic;
using System.Linq;

    class PrintFirstFiftyNumsFromSeq
    {
        static void Main()
        {
            Console.Write("Enter the first number of the sequence: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(firstNumber);
            int printedNumbers = 0;

            // Printing firstNumber
            Console.WriteLine();
            Console.Write(firstNumber + "→");

            // Printing the first 50 numbers from the sequence
            int seqNumsToPrint = 50;
            while (printedNumbers < seqNumsToPrint-1)
            {
                int currentNumber = queue.Dequeue();
                Console.Write(currentNumber+", ");
                printedNumbers++;
                queue.Enqueue(currentNumber + 1);
                queue.Enqueue(2 * currentNumber + 1);
            }

            int fiftiedNumberInSeq = queue.Dequeue();
            Console.Write(fiftiedNumberInSeq);
            Console.WriteLine();
        }
    }

