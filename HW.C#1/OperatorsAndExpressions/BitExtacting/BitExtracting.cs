using System;
class BitExtracting
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a position:");
        byte position = byte.Parse(Console.ReadLine());
        if (position > 31)
        {
            Console.WriteLine("Enter position<32");
        }
        else
        {
            int mask = 1 << position;
            int result = mask & number;
            byte bit = (byte)(result >> position);
            Console.WriteLine("number=" + number + "  has  bit=" + bit + "  on  position=" + position);
        }
    }
}
