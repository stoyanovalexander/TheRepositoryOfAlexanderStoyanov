using System;

namespace BitArray
{
    /// <summary>
    /// Tests Bit array functionality.
    /// </summary>
    public class BitArrayTest
    {
        /// <summary>
        /// Main entry point for Bit Array Testing.
        /// </summary>
        public static void Main()
        {
            BitArray64 num = new BitArray64(4);
            Console.WriteLine("First:");
            Console.WriteLine(num);

            BitArray64 secondNum = new BitArray64(5);
            Console.WriteLine("Second:");
            Console.WriteLine(secondNum);

            secondNum[0] = 0;
            Console.WriteLine("Edited Second:");
            Console.WriteLine(secondNum);

            Console.Write("Fisrt equals second: ");
            Console.WriteLine(num.Equals(secondNum));

            Console.Write("Fisrt == second: ");
            Console.WriteLine(num == secondNum);

            Console.Write("Fisrt != second: ");
            Console.WriteLine(num != secondNum);

            // IEnumerable number = new BitArray64(2);
        }
    }
}