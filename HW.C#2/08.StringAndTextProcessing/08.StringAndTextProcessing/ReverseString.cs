using System;
using System.Text;
    class ReverseString
    {
        static void Reversing(string str)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }
            Console.WriteLine(reversed);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string: ");
            string text = Console.ReadLine();
            Reversing(text);
        }
    }

