using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitArray64
{
    class TestBitArray64
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========PRINT THE FIRSTNUMBER IN BINARY REPRESENTATION==========");
            BitArray64 firstNumber = new BitArray64(333);
            foreach (var bit in firstNumber)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            Console.WriteLine("The hash code of firstNumber is:{0}",firstNumber.GetHashCode());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=========PRINT THE SECONDNUMBER IN BINARY REPRESENTATION==========");
            BitArray64 secondNumber = new BitArray64(333);
            foreach (var bit in secondNumber)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            Console.WriteLine("The hash code of secondNumber is:{0}", secondNumber.GetHashCode());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=========PRINT THE THIRDNUMBER IN BINARY REPRESENTATION==========");
            BitArray64 thirdNumber = new BitArray64(666);
            foreach (var bit in firstNumber)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            Console.WriteLine("The hash code of thirdNumber is:{0}", thirdNumber.GetHashCode());
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("firstNumber==secondNumber: "+firstNumber.Equals(secondNumber));
            Console.WriteLine("-------------CHECK WITH '==' --------------------");
            if (firstNumber == secondNumber)
            {
                Console.WriteLine("firstNumber==secondNumber");
            }
            else
            {
                Console.WriteLine("firstNumber!=secondNumber");
            }
            Console.WriteLine("-------------- CHECK WITH '!='---------------------");
            if (firstNumber != secondNumber)
            {
                Console.WriteLine("firstNumber!=secondNumber");
            }
            else
            {
                Console.WriteLine("firstNumber==secondNumber");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("firstNumber==thirdNumber: " + firstNumber.Equals(thirdNumber));
            Console.WriteLine("-------------CHECK WITH '==' --------------------");
            if (firstNumber == thirdNumber)
            {
                Console.WriteLine("firstNumber==thirdNumber");
            }
            else
            {
                Console.WriteLine("firstNumber!=thirdNumber");
            }
            Console.WriteLine("-------------- CHECK WITH '!='---------------------");
            if (firstNumber != thirdNumber)
            {
                Console.WriteLine("firstNumber!=thirdNumber");
            }
            else
            {
                Console.WriteLine("firstNumber==thirdNumber");
            }
            Console.WriteLine();
            Console.WriteLine();
            // indexer starts from young bits
           
            Console.WriteLine("the value of bit firstNumber[11]={0}",firstNumber[11]);
          

            // change bit
            firstNumber[11] = 1;
            Console.WriteLine("AFTER CHANGE FIRSTNUMBER[11]=1 FIRSTNUBER IN DEC REPRESENTATIO IS:");
            Console.WriteLine(firstNumber.Number);
            Console.WriteLine("AFTER CHANGE FIRSTNUMBER[11]=1 FIRSTNUBER IN BIN REPRESENTATIO IS:");
            foreach (var bit in firstNumber)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
        }
    }
}
