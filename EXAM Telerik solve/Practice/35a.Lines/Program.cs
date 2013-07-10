using System;
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[8];
            for (int i = 0; i < 8; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            int rowBits = 0;
            int cell = 0;
            int len = 0;
            int biggestLen=0;
            int count = 0;

            for (int i = 0; i < 8; i++)
            {
                rowBits = n[i];
                len = 0;
                for (int col = 0; col < 8; col++)
                {
                    cell = (rowBits >> col) & 1;
                    if (cell == 1)
                    {
                        len++;
                        if (len > biggestLen)
                        {
                            biggestLen = len;
                            count = 0;
                        }
                        if (len == biggestLen)
                        {
                            count++;
                        }
                    }
                    else
                    {
                        len = 0;
                    }
                }
            }

            // ROWS
            for (int col = 0; col < 8; col++)
            {
                len = 0;
                for (int row = 0; row < 8; row++)
                {
                    rowBits = n[row];
                    cell = (rowBits >> col) & 1;
                    if (cell == 1)
                    {
                        len++;
                        if (len > biggestLen)
                        {
                            biggestLen = len;
                            count = 0;
                        }
                        if (len == biggestLen)
                        {
                            count++;
                        }
                    }
                    else
                    {
                        len = 0;
                    }
                }
            }
            if (biggestLen == 1)
            {
                count = count / 2;
            }
            Console.WriteLine(biggestLen);
            Console.WriteLine(count);
        }
    }

