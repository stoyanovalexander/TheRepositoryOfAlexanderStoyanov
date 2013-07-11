using System;

/* 5. Define a class BitArray64 to hold 64 bit values 
 * inside an ulong value. Implement IEnumerable<int> 
 * and Equals(…), GetHashCode(), [], == and !=. */

// All credit for this solution goes to Stojan Tankovski (a.k.a. tankovski)
class MainBitArray64
{
    static void Main()
    {
        int numInt = 123456789;
        Console.WriteLine(Convert.ToString(numInt, 2).PadLeft(64, '0'));

        ulong numUlong = 123456789;
        BitArray64 bits = new BitArray64(numUlong);

        foreach (var bit in bits)
        {
            Console.Write(bit);
        }
        Console.WriteLine();
        Console.WriteLine();

        BitArray64 bits2 = new BitArray64((ulong)8766);
        Console.WriteLine(bits.Equals(bits2));
        Console.WriteLine(bits == bits2);
        Console.WriteLine(bits != bits2);
        Console.WriteLine();

        Console.WriteLine(bits);

        Console.WriteLine(bits[0]);

        Console.WriteLine();
    }
}

