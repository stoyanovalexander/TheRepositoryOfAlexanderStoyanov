using System;
using System.Collections.Generic;
    class FromSToDNumSystem
    {
        static void Main()
        {
            // Conver from "s" numeral system to decimal
            Console.Write("               Enter base of numeral system[2,16] - s=");
            int s = int.Parse(Console.ReadLine());
            Console.Write("               Enter base of numeral system[2,16] - d=");
            int d = int.Parse(Console.ReadLine());
            Console.Write("          Enter number in numeral system with base {0}: ",s);
            int numToConvert = int.Parse(Console.ReadLine());
            int convertedNum = 0;
            int count = 0;
            while (numToConvert != 0)
            {
                convertedNum = (numToConvert % 10) * ((int)Math.Pow(s, count)) + convertedNum;
                count++;
                numToConvert =numToConvert / 10;
            }
            // Convert from decimal numeral system to "d" numeral system
            List<int> dNumSystemDigits = new List<int>();
            // Fill List<> of binaryDigits
            while (convertedNum != 0)
            {
                dNumSystemDigits.Add(convertedNum % d);
                convertedNum = convertedNum / d;
            }

            Console.Write("The representation in numeral system with base {0} is: ",d);
            // Print the result
            for (int i = dNumSystemDigits.Count - 1; i >= 0; i--)
            {
                Console.Write(dNumSystemDigits[i]);
            }
            Console.WriteLine();
        }
    }

