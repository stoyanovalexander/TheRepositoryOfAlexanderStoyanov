using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter num=");
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            for (int i = 0; i < num; i++)
            {
                array[i] = i * 5;
            }
            for (int i = 0; i < num; i++)
            {
                Console.Write(" "+array[i]);
            }
            Console.WriteLine();
        }
    }

