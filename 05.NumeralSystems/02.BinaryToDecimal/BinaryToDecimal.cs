using System;
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("       Enter binary!!! number: ");
            int binaryNum = int.Parse(Console.ReadLine());
            int decRepresent = 0;
            int count = 0;
            while (binaryNum != 0)
            {
                decRepresent = (binaryNum%10)*((int)Math.Pow(2.0,count))+decRepresent;
                count++;
                binaryNum = binaryNum / 10;
            }
            Console.Write("The decimal representation is: ");
            Console.Write(decRepresent);
            Console.WriteLine();
        }
    }

