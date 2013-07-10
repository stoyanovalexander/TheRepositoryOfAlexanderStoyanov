using System;
    class CompareArrays
    {
        static void Main()
        {
            Console.Write("Enter num=");
            int num=int.Parse(Console.ReadLine());
            int[] arrayOne = new int[num];
            int[] arrayTwo = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write("arrayOne[{0}]: ",i);
                arrayOne[i] = int.Parse(Console.ReadLine());
                Console.Write("arrayTwo[{0}]: ", i);
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num; i++)
            {
                if (arrayOne[i] < arrayTwo[i])
                {
                    Console.WriteLine(arrayOne[i]+"<"+arrayTwo[i]);
                }
                else if (arrayOne[i] > arrayTwo[i])
                {
                    Console.WriteLine(arrayOne[i]+ "> "+arrayTwo[i]);
                }
                else // if (arrayOne[i] > arrayTwo[i])
                {
                    Console.WriteLine(arrayOne[i] +"="+ arrayTwo[i]);
                }
            }
        }
    }

