using System;
    class FillTheMatrixC2
    {
        static void Main()
        {
            Console.Write("Enter n=");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            //Found matrix[0,0]
            int count = 1;
            int iCount = 0;
            for (int i = 0; i < n; i++)
            {
                iCount++;
                count = count + iCount - 1;
            }

            // Diagonal \
            for (int i = 0; i < n; i++)
            {
                matrix[i, i] = count;
                count++;
            }

            // Up Right
            int jCount = 0;    
            for (int i = 0; i < (n - 1); i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    matrix[i, j] = matrix[i, j - 1] - jCount + n;  
                    jCount++;
                }
                jCount = 0;
            }

            // down Left
            jCount = 0;
            for (int i = 1; i <n ; i++)
            {
                for (int j = i - 1; j >=0 ; j--)
                {
                    matrix[i, j] = matrix[i, j + 1] + jCount - n;
                    jCount++;
                }
                jCount = 0;
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

