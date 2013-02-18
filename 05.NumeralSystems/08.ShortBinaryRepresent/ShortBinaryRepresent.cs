using System;
using System.Collections.Generic;
    class ShortBinaryRepresent
    {
        static void Main(string[] args)
        {
            Console.Write("        Enter SHORT Number: ");
            short signNum = short.Parse(Console.ReadLine());
            List<int> binaryDigits = new List<int>();
            if (signNum < 0)
            {
                binaryDigits.Add(1);
            }
            else
            {
                binaryDigits.Add(0);
            }
            signNum =(short)Math.Abs(signNum);
            // Fill List<> of binaryDigits
            for (int i = 1; i < 16;i++ )
            {
                binaryDigits.Add(signNum % 2);
                signNum = (short)(signNum / 2);
            }
            Console.Write("The binary representation is: ");
            // Print the result in signed magnitede
            Console.Write(binaryDigits[0]);
            for (int i = 15; i > 0; i--)
            {
                Console.Write(binaryDigits[i]);
            }
            Console.WriteLine();
        }
    }

