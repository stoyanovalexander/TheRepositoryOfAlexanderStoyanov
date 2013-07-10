using System;
static class AFillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter n=");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = 1 + i + (4 * j);
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0:5}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}


