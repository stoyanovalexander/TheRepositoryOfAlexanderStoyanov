using System;
    class HexadecimalToBinary
    {
        static void Main()
        {
            Console.Write("    Enter HEXADECIMAL number: ");
            string hexNumber = Console.ReadLine();
            Console.Write("The BINARY representation is: ");
            // Print the result
            for(int i=0;i<hexNumber.Length;i++)
            {
                switch (hexNumber[i])
                { 
                    case '0':
                        Console.Write("0000");break;
                    case '1':
                        Console.Write("0001"); break;
                    case '2':
                        Console.Write("0010"); break;
                    case '3':
                        Console.Write("0011"); break;
                    case '4':
                        Console.Write("0100"); break;
                    case '5':
                        Console.Write("0101"); break;
                    case '6':
                        Console.Write("0110"); break;
                    case '7':
                        Console.Write("0111"); break;
                    case '8':
                        Console.Write("1000"); break;
                    case '9':
                        Console.Write("1001"); break;
                    case 'A':
                    case 'a':
                        Console.Write("1010"); break;
                    case 'B':
                    case 'b':
                        Console.Write("1011"); break;
                    case 'C':
                    case 'c':
                        Console.Write("1100"); break;
                    case 'D':
                    case 'd':
                        Console.Write("1101"); break;
                    case 'E':
                    case 'e':
                        Console.Write("1110"); break;
                    case 'F':
                    case 'f':
                        Console.Write("1111"); break;
                    default:
                        Console.WriteLine("Ther must have some mistake!!!"); break;
                }
            }
            Console.WriteLine();
        }
    }

