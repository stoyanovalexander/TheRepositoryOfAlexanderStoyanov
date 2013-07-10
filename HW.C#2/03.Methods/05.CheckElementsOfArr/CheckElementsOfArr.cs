using System;
    class CheckElementsOfArr
    {
        static void CompareNeighbors(int[] array,int position)
        {
            if ((position==0)&&(array[position] > array[1]))
            {
                Console.WriteLine("the element at position {0} is bigger than its neighbors",position);
            }

            else if ((position == array.Length-1) && (array[position] > array[array.Length-2]))
            {
                Console.WriteLine("the element at position {0} is bigger than its neighbors", position);
            }

            else if ((position > 0) && (position < array.Length - 1) && (array[position] > array[position - 1]) &&
                (array[position] > array[position + 1]))
            {
                Console.WriteLine("the element at position {0} is bigger than its neighbors", position);
            }
            else if((position>=0)&&(position<array.Length))
            {
                Console.WriteLine("the element at position {0} is NOT!!! bigger than its neighbors", position);  
            }
        }
        static void Main()
        {
            Console.Write("Enter arrLen=");
            int arrLen = int.Parse(Console.ReadLine());
            Console.Write("Enter somePosition=");
            int somePosition = int.Parse(Console.ReadLine());
            int[] someArr = new int[arrLen];
            Console.WriteLine("Enter someArr");
            // Fill the array
            for (int i = 0; i < arrLen; i++)
            {
                someArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine();
            CompareNeighbors(someArr,somePosition);
        }
    }

