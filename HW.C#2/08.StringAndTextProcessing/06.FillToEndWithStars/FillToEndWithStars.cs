using System;
    class FillToEndWithStars
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string text = Console.ReadLine();
            char star = '*';
            int length = 20;
            if (text.Length < length)
            {
                Console.WriteLine(text.PadRight(length,star));
            }
        }
    }

