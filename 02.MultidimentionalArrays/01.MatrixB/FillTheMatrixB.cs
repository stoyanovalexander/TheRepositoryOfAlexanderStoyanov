using System;
    class FillTheMatrixB
    {
        static void Main()
        {
             Console.Write("Enter n=");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        // Fill the array
        for (int i = 0; i < n; i++)
        {
            // Fill even cols(0,2,4...) of the array
            for (int j = 0; j < n; j=j+2)
            {
                matrix[i, j] = 1 + i + (n * j);
            }

            // Fill odd cols(1,3,5...) of the array
            for (int j = 1; j < n; j = j + 2)
            {
                matrix[i, j] = (n * j + n) - i;
            }
        }

        // Print the array
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,5}", matrix[i, j]);
            }
            Console.WriteLine();
            }
        }
    }

