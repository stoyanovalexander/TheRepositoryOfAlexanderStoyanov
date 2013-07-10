using System;
    class RectanglesArea
    {
        static void Main()
        {
            Console.WriteLine("Enter the height:");
            uint height = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width:");
            uint width = uint.Parse(Console.ReadLine());
            ulong area = (ulong)height * width;
            Console.WriteLine("area="+area);
        }
    }
