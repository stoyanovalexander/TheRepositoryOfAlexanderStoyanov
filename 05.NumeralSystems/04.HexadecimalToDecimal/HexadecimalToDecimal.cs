using System;
    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.Write("Enter HEXADECIMAL number: ");
            string hexNumber = Console.ReadLine();
            int decNumber = 0;
            // Solve
            for (int i = hexNumber.Length - 1,j=0; i >= 0; i--,j++)
            {
                switch (hexNumber[i])
                { 
                    case '0':
                        decNumber = decNumber + (0 * ((int)Math.Pow(16.0, j)));break;
                    case '1':
                        decNumber = decNumber + (1 * ((int)Math.Pow(16.0, j)));break;
                    case '2':
                        decNumber = decNumber + (2 * ((int)Math.Pow(16.0, j)));break;
                    case '3':
                        decNumber = decNumber + (3 * ((int)Math.Pow(16.0, j)));break;
                    case '4':
                        decNumber = decNumber + (4 * ((int)Math.Pow(16.0, j)));break;
                    case '5':
                        decNumber = decNumber + (5 * ((int)Math.Pow(16.0, j)));break;
                    case '6':
                        decNumber = decNumber + (6 * ((int)Math.Pow(16.0, j)));break;
                    case '7':
                        decNumber = decNumber + (7 * ((int)Math.Pow(16.0, j)));break;
                    case '8':
                        decNumber = decNumber + (8 * ((int)Math.Pow(16.0, j)));break;
                    case '9':
                        decNumber = decNumber + (9 * ((int)Math.Pow(16.0, j)));break;
                    case 'A':
                    case 'a':
                        decNumber = decNumber + (10 * ((int)Math.Pow(16.0, j)));break;
                    case 'B':
                    case 'b':
                        decNumber = decNumber + (11 * ((int)Math.Pow(16.0, j)));break;
                    case 'C':
                    case 'c':
                        decNumber = decNumber + (12 * ((int)Math.Pow(16.0, j)));break;
                    case 'D':
                    case 'd':
                        decNumber = decNumber + (13* ((int)Math.Pow(16.0, j)));break;
                    case 'E':
                    case 'e':
                        decNumber = decNumber + (14* ((int)Math.Pow(16.0, j)));break;
                    case 'F':
                    case 'f':
                        decNumber = decNumber + (15* ((int)Math.Pow(16.0, j)));break;
                    default:
                        Console.WriteLine("There must have some mistake!!!");break;
                }
            }
            Console.Write("The DECIMAL representation is: ");
            // Print the result
            Console.Write(decNumber);
            Console.WriteLine();
        }
    }

