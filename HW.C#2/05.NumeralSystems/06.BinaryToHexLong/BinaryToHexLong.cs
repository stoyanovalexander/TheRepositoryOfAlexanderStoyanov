using System;
    class BinaryToHexLong
    {
        static void Main()
        {
            Console.WriteLine("Enter BINARY number: ");
            string binNumber = Console.ReadLine();
            string theSwitch = ".";
            int count = 0;
            for(int i=0;i<binNumber.Length;i++)
            {
                theSwitch =theSwitch +binNumber[i];
                count++;
                if (count == 3)
                {
                    switch (theSwitch)
                    {
                        case "0000":
                            Console.Write("0"); break;
                        case ".0001":
                            Console.Write("1"); break;
                        case "0010":
                            Console.Write("2"); break;
                        case "0011":
                            Console.Write("3"); break;
                        case "0100":
                            Console.Write("4"); break;
                        case "0101":
                            Console.Write("5"); break;
                        case "0110":
                            Console.Write("6"); break;
                        case "0111":
                            Console.Write("7"); break;
                        case "1000":
                            Console.Write("8"); break;
                        case "1001":
                            Console.Write("9"); break;
                        case "1010":
                            Console.Write("A"); break;
                        case "1011":
                            Console.Write("B"); break;
                        case "1100":
                            Console.Write("C"); break;
                        case "1101":
                            Console.Write("D"); break;
                        case "1110":
                            Console.Write("E"); break;
                        case "1111":
                            Console.Write("F"); break;
                        default:
                            Console.WriteLine("Ther must have some mistake!!!"); break;
                    }
                    theSwitch = ".";
                    count = 0;
                }
            }
        }
    }

