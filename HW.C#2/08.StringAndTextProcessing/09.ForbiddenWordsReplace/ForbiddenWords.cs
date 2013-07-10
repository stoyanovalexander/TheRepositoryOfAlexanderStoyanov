using System;
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter string with forbidden words: ");
            string forbidden = Console.ReadLine();
            string[] wordsForbid = forbidden.Split(',');
            string[] stars = new string[wordsForbid.Length];

            for (int i = 0; i < wordsForbid.Length; i++)
            {
                for (int k = 0; k < wordsForbid[i].Length; k++)
                {
                    stars[k] = '*';
                }
            }
                for (int i = 0; i < wordsForbid.Length; i++)
                {
                    int index = text.IndexOf(wordsForbid[i]);
                    if ((index == 0) && (text[index + wordsForbid.Length] == ' ' || text[index + wordsForbid.Length] == '.'))
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

