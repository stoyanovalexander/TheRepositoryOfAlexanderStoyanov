using System;
    class FillTheMatrixD
    {
        static void Main()
        {
            Console.Write("Enter num=");
        int num = int.Parse(Console.ReadLine());
           
        int counter = 0;
        int[,] spiralMatrix = new int[num, num];
        for (int p = 0; p <= (num / 2) - 1; p++) // p gives the unchangeble coordinate of the Row or the Column.
        {
            for (int k = p; k <= num - 2 - p; k++)  // →
            {
                spiralMatrix[p, k] = ++counter;
            }
            for (int k = p; k <= num - 2 - p; k++)  // ↓
            {
                spiralMatrix[k, num - 1 - p] = ++counter;
            }
            for (int k = p; k <= num - 2 - p; k++)  //  ←
            {
                spiralMatrix[num - 1 - p, num - 1 - k] = ++counter;
            }
            for (int k = p; k <= num - 2 - p; k++)  //  ↑
            {
                spiralMatrix[num - 1 - k, p] = ++counter;
            }

            if (num % 2 == 1) // num(1,3,5,7...) then with this fill the last number which is in the middle
            {
                int middle = num / 2;
                spiralMatrix[middle, middle] = ++counter;
            }
        }

        // Print the spiralMatrix
        for (int row = 0; row <= num - 1; row++)
        {
            for (int column = 0; column <= num - 1; column++)
            {
                Console.Write("{0,5}", spiralMatrix[row, column]);
            }
            Console.WriteLine();
            }
        }
    }

