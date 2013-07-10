using System;
    class MatrixWithNumbers
    {
        static void Main()
        {
            Console.Write("Enter number of the rows and cols of the Matrix: ");
            byte rowsAndColsNum = byte.Parse(Console.ReadLine());
            if (rowsAndColsNum < 1)
            {
                Console.WriteLine("Enter bigger value of rowsAndColsNum");
            }
            else if (rowsAndColsNum > 19)
            {
                Console.WriteLine("Enter smaller value of rowsAndColsNum");
            }
            else
            {
                for (byte rows = 1; rows <= rowsAndColsNum; rows++)
                {
                    for (byte number = rows; number <= rows + rowsAndColsNum - 1; number++) 
                    {
                        Console.Write("{0,-3}",number);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
