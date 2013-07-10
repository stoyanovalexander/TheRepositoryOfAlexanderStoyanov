using System;
using System.Collections.Generic;
    class BinaryNumToHexNum
    {
        static void Main()
        {
            Console.Write("Enter Binary(begining with one)!!! number: ");
            int binaryNum = int.Parse(Console.ReadLine());
            List<int> switchDigits = new List<int>();
            // Fill the List of switchDigit
            if (binaryNum == 0)
            {
                switchDigits.Add(0);
            }
            else
            {
                while (binaryNum != 0)
                {
                    switchDigits.Add(binaryNum % 10000);
                    binaryNum = binaryNum / 10000;
                }
            }
            Console.Write("        The hexadecimal representation is: ");
            // Print the result
            for (int i = switchDigits.Count - 1; i >= 0; i--)
            {
                switch (switchDigits[i])
                { 
                    case 0:
                        Console.Write("0");break;
                    case 1:
                        Console.Write("1"); break;
                    case 10:
                        Console.Write("2"); break;
                    case 11:
                        Console.Write("3"); break;
                    case 100:
                        Console.Write("4"); break;
                    case 101:
                        Console.Write("5"); break;
                    case 110:
                        Console.Write("6"); break;
                    case 111:
                        Console.Write("7"); break;
                    case 1000:
                        Console.Write("8"); break;
                    case 1001:
                        Console.Write("9"); break;
                    case 1010:
                        Console.Write("A"); break;
                    case 1011:
                        Console.Write("B"); break;
                    case 1100:
                        Console.Write("C"); break;
                    case 1101:
                        Console.Write("D"); break;
                    case 1110:
                        Console.Write("E"); break;
                    case 1111:
                        Console.Write("F"); break;
                    default:
                        Console.WriteLine("There must have some mistake!!!");break;
                }
            }
            Console.WriteLine();
        }
    }

