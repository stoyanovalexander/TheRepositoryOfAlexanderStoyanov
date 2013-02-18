using System;
    class FillTheMatrixC
    {
        static void Main()
        {
            Console.Write("Enter n=");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            // Fill Down left half of the array
            int count = 0;
            int iCount = 0;
            int jCount = 1;
            int previous = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    matrix[i, j] = previous + iCount + jCount;  // 3=1+2!; 6=3+3!; 10=6+4!; 15=10+5!...  2! 3! 4! 5!...
                    previous = matrix[i, j];
                    jCount++;
                }
                iCount++;   // 2=1+1!; 4=2+2!; 7=4+3!; 11=7+4!...   1! 2! 3! 4!...
                count = count + iCount-1;
                previous = count;
                jCount = 1;
            }

            // Fill Up right half of the array
            jCount=0;    
            previous = n * n + 1;
            for (int i = 0; i < (n-1); i++)
            {
                for (int j = i + 1; j <n; j++)
                {
                    matrix[i, j] = matrix[i, j - 1] - jCount+n;   
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

