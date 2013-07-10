using System;
    class BitsExchange
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            uint number=uint.Parse(Console.ReadLine());
            uint mask = 7;
            uint maskOne = mask << 3;
            uint bit3Bit4Bit5 = number & maskOne;
            uint maskTwo = mask << 24;
            uint bit24Bit25Bit26 = number & maskTwo;
            uint notMaskOne = ~ maskOne;
            uint notMaskTwo= ~ maskTwo;
            uint zerosB3B4B5B24B25B26 = (number & notMaskOne) & notMaskTwo;
            bit3Bit4Bit5 = bit3Bit4Bit5 << 21;
            bit24Bit25Bit26 = bit24Bit25Bit26 >> 21;
            uint lastMask = bit3Bit4Bit5 | bit24Bit25Bit26;
            uint changedNumber = zerosB3B4B5B24B25B26 | lastMask;
            Console.WriteLine(number+"  After changing bits 3,4,5 with 24,25,26 is  changedNamber="+changedNumber);
        }
    }

