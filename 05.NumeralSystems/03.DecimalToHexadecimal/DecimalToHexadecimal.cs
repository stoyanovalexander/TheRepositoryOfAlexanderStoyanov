using System;
using System.Collections.Generic;
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("             Enter DECIMAL number: ");
            int decimalNum = int.Parse(Console.ReadLine());
            List<string> hexDigits = new List<string>();
            int hexSwitch = 0;
            // Fill the List of hexDigits
            while (decimalNum != 0)
            {
                hexSwitch = decimalNum % 16;
                decimalNum = decimalNum / 16;
                switch (hexSwitch)
                { 
                    case 0:
                        hexDigits.Add("0");break;
                    case 1:
                        hexDigits.Add("1"); break;
                    case 2:
                        hexDigits.Add("2"); break;
                    case 3:
                        hexDigits.Add("3"); break;
                    case 4:
                        hexDigits.Add("4"); break;
                    case 5:
                        hexDigits.Add("5"); break;
                    case 6:
                        hexDigits.Add("6"); break;
                    case 7:
                        hexDigits.Add("7"); break;
                    case 8:
                        hexDigits.Add("8"); break;
                    case 9:
                        hexDigits.Add("9"); break;
                    case 10:
                        hexDigits.Add("A"); break;
                    case 11:
                        hexDigits.Add("B"); break;
                    case 12:
                        hexDigits.Add("C"); break;
                    case 13:
                        hexDigits.Add("D"); break;
                    case 14:
                        hexDigits.Add("E"); break;
                    case 15:
                        hexDigits.Add("F"); break;
                    default:
                        Console.WriteLine("There must have some mistake!!!");; break;
                }
            }
            Console.Write("The hexadecimal representation is: ");
            // Print the result
            for (int i = hexDigits.Count - 1; i >= 0; i--)
            {
                Console.Write(hexDigits[i]);
            }
            Console.WriteLine();
        }
    }

