using System;

    class BinPasswords
    {
        // input example: 100***10***01  output: 2^6=64 (power is the number of '*')
        // input example: 1*10**1  output: 2^3=8
        static void Main()
        {
            string input = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    count++;
                }
            }

            long output = 1 << count;
            Console.WriteLine(output);
        }
    }

