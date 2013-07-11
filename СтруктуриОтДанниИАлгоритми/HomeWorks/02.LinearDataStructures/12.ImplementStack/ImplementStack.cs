using System;
using System.Collections.Generic;
using System.Linq;

    class ImplementStack
    {
        static void Main()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);


            int[] stackToArray = myStack.ToArray();
            Console.Write("{");
            for (int i = 0; i < stackToArray.Length-1; i++)
            {
                Console.Write(stackToArray[i] + ", ");
            }

            Console.Write(stackToArray[stackToArray.Length-1]+"}");
            Console.WriteLine();
            Console.WriteLine("the count="+myStack.Count);

            Console.WriteLine();
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Peek());
            Console.WriteLine("the count="+myStack.Count);

            Console.WriteLine(myStack.Contains(111));

            myStack.Clear();
            Console.WriteLine("the count="+myStack.Count);
        }
    }

