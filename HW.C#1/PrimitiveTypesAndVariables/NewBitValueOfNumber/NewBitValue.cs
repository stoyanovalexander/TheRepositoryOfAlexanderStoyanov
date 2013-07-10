using System;
    class NewBitValue
    {
        static void Main()
        {
            Console.WriteLine("enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a position: ");
            byte position = byte.Parse(Console.ReadLine());
            if (position > 31)
            {
                Console.WriteLine("Enter position<32");
            }
            else
            {
                Console.WriteLine("Enter value of bit[0,1]: ");
                byte value = byte.Parse(Console.ReadLine());
                if (value > 1)
                {
                    Console.WriteLine("Enter a value<2");
                }
                else
                {
                    int mask = 1<<position;
                    int notMask = ~mask;
                    int zeroOnPosition = number & notMask;
                    int valueMask=value<<position;
                    int newNumber = zeroOnPosition | valueMask;
                    Console.WriteLine("newNumber="+newNumber + "  when the bit on  position=" + position + "  has  value=" + value);
                }
            }
        }
    }