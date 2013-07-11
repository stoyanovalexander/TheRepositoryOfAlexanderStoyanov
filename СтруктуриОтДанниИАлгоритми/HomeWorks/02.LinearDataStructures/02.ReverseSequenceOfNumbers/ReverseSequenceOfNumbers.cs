using System;
using System.Collections.Generic;
using System.Linq;

    class ReverseSequenceOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter the number of the numbers(positive one): ");
            int numberOfNumbers = int.Parse(Console.ReadLine());
            Stack<int> enteredNumbers = new Stack<int>();
            for (int i = 0; i < numberOfNumbers; i++)
            {
                Console.Write("Enter number: ");
                int theEnteredNumber = int.Parse(Console.ReadLine());
                enteredNumbers.Push(theEnteredNumber);
            }

            Console.WriteLine();
            Console.WriteLine("the entered numbers in REVERSED order");
            for (int i = 0; i < numberOfNumbers; i++)
            {
                int theNextNumber = enteredNumbers.Pop();
                Console.WriteLine(theNextNumber);
            }
        }
    }

