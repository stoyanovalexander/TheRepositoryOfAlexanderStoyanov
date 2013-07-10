using System;
    class ExtractingSentanceswithWord
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter word: ");
            string word = Console.ReadLine();
            string[] sentance = text.Split('.');
            for (int i = 0; i < sentance.Length; i++)
            {
                int index = -1;
                index = sentance[i].IndexOf(word);
                if ((index == 0) && (sentance[i][index + word.Length] == ' ' || sentance[i][index + word.Length] == '.'))
                {
                    Console.WriteLine(sentance[i]);
                }
                if ((index > 0) && (sentance[i][index - 1] == ' ' || sentance[i][index - 1] == '.')
                    && (sentance[i][index + word.Length] == ' ' || sentance[i][index + word.Length] == '.'))
                {
                    Console.WriteLine(sentance[i]);
                }
            }
        }
    }

