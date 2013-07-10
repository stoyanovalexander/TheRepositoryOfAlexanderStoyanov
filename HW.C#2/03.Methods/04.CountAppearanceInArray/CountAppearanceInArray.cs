using System;
    class CountAppearanceInArray
    {
        static void CountingAppeatance(int[] array, int num)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (num == array[i])
                {
                    count++;
                }
            }
            Console.WriteLine("the number "+num+" appearse in the array "+count+" times");
        }
        static void Main()
        {
            Console.Write("Enter arrLen=");
            int arrLen = int.Parse(Console.ReadLine());
            Console.Write("Enter someNum=");
            int someNum = int.Parse(Console.ReadLine());
            int[] someArr=new int[arrLen];
            Console.WriteLine("Enter someArr");
            // Fill the array
            for (int i = 0; i < arrLen; i++)
            {
                someArr[i] = int.Parse(Console.ReadLine());
            }
            CountingAppeatance(someArr, someNum);
        }
    }

