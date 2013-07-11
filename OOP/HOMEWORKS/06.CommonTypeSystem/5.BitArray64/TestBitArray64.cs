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

            BitArray64 number = new BitArray64(7);

            // print bits of the ulong number
            foreach (var bit in number)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            // make second BitArray
            BitArray64 number2 = new BitArray64(7);

            Console.WriteLine(number.Equals(number2));

            // indexer starts from young bits
            Console.WriteLine(number[2]);
            // print hash code
            Console.WriteLine(number.GetHashCode());

            // change bit
            number[4] = 1;
            // print the changed number and his bits
            Console.WriteLine(number.Number);
            foreach (var bit in number)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
        }
    }
}
