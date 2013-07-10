using System;
    class BinaryDigitsCount
    {
        static void Main()
        {
            byte B = byte.Parse(Console.ReadLine());
            ushort N = ushort.Parse(Console.ReadLine());
            for (ushort position = 1; position <= N; position++)
            {
                byte reminder;
                int counter=0;
                uint number = uint.Parse(Console.ReadLine());
                while (number > 0)
                {
                    reminder = (byte)(number % 2);
                    if (reminder == B)
                    {
                        counter = counter + 1;
                    }
                    number = number / 2;
                }
           
                Console.WriteLine(counter);
            }
        }
    }

