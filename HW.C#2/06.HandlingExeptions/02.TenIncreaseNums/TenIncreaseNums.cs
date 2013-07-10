using System;
    class TenIncreaseNums
    {
        static void ReadNumber(int start, int end)
        {
                Random rand = new Random();
                int num = rand.Next(start, end + 1);
                checkingStartNum(start);
                checkingEndNum(end);
                Console.WriteLine(num);
        }
        static void checkingStartNum(int start)
        {
            if (start < 2)
            {
                throw new ArithmeticException("Small start number!");
            }
        }
        static void checkingEndNum(int end)
        {
            if (end > 99)
            {
                throw new ArithmeticException("Big end number!");
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter start elementvalue(1,10): ");
            try
            {
                int start = int.Parse(Console.ReadLine());
                int end = start + 5;
                Console.WriteLine();
                ReadNumber(start, end);
                for (int i = 0; i < 9; i++)
                {
                    start = end + 1;
                    end = start + 5;
                    ReadNumber(start, end);
                }
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid number!");
            }
        }
    }

