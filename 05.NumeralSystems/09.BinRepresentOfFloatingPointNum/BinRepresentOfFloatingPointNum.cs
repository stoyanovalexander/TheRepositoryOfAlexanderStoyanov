using System;
using System.Collections.Generic;
    class BinRepresentOfFloatingPointNum
    {
        static string GettingHalfBytes(float number)
        {
            byte[] bytes = BitConverter.GetBytes(number);
            Array.Reverse(bytes);
            string result = BitConverter.ToString(bytes);
            return result;
        }
		//This comment is only a demo 
        static void Main()
        {
            Console.Write("Enter floating point number:");
            float num = Single.Parse(Console.ReadLine());
            string transformToBinary = "";
            string theResult = GettingHalfBytes(num);
            for (int i = 0; i < theResult.Length; i++)
            {
                switch (theResult[i])
                { 
                    case '0':
                        transformToBinary = transformToBinary + "0000"; break;
                    case '1':
                        transformToBinary = transformToBinary + "0001"; break;
                    case '2':
                        transformToBinary = transformToBinary + "0010"; break;
                    case '3':
                        transformToBinary = transformToBinary + "0011"; break;
                    case '4':
                        transformToBinary = transformToBinary + "0100"; break;
                    case '5':
                        transformToBinary = transformToBinary + "0101"; break;
                    case '6':
                        transformToBinary = transformToBinary + "0110"; break;
                    case '7':
                        transformToBinary = transformToBinary + "0111"; break;
                    case '8':
                        transformToBinary = transformToBinary + "1000"; break;
                    case '9':
                        transformToBinary = transformToBinary + "1001"; break;
                    case 'A':
                        transformToBinary = transformToBinary + "1010"; break;
                    case 'B':
                        transformToBinary = transformToBinary + "1011"; break;
                    case 'C':
                        transformToBinary = transformToBinary + "1100"; break;
                    case 'D':
                        transformToBinary = transformToBinary + "1101"; break;
                    case 'E':
                        transformToBinary = transformToBinary + "1110"; break;
                    case 'F':
                        transformToBinary = transformToBinary + "1111"; break;
                    case 'a':
                        transformToBinary = transformToBinary + "1010"; break;
                    case 'b':
                        transformToBinary = transformToBinary + "1011"; break;
                    case 'c':
                        transformToBinary = transformToBinary + "1100"; break;
                    case 'd':
                        transformToBinary = transformToBinary + "1101"; break;
                    case 'e':
                        transformToBinary = transformToBinary + "1110"; break;
                    case 'f':
                        transformToBinary = transformToBinary + "1111"; break;
                }
            }
            Console.WriteLine("sign={0}",transformToBinary[0]);
            Console.WriteLine("exponent={0}{1}{2}{3}{4}{5}{6}{7}", transformToBinary[1], transformToBinary[2],transformToBinary[3],
                transformToBinary[4], transformToBinary[5], transformToBinary[6], transformToBinary[7], transformToBinary[8]);
            Console.WriteLine("mantissa={0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}"
                , transformToBinary[9], transformToBinary[10], transformToBinary[11], transformToBinary[12], transformToBinary[13]
                , transformToBinary[14], transformToBinary[15], transformToBinary[16], transformToBinary[17], transformToBinary[18]
                , transformToBinary[19], transformToBinary[20], transformToBinary[21], transformToBinary[22], transformToBinary[23]
                , transformToBinary[24], transformToBinary[25], transformToBinary[26], transformToBinary[27], transformToBinary[28]
                , transformToBinary[29], transformToBinary[30], transformToBinary[31]);
        }
    }

