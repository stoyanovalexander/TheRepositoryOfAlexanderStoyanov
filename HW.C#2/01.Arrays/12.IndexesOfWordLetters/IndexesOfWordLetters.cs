using System;
    class IndexesOfWordLetters
    {
        static void Main()
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 
                             'n', 'o','p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("Write some word");
            string word = Console.ReadLine();
            int len = word.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (word[i] == arr[j])
                    {
                        Console.Write(" "+j+" ");
                    }
                }
            }
        }
    }

