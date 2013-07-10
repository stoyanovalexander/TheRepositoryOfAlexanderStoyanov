using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    class MassageInBottle
    {
        static void Main(string[] args)
        {
            string code = Console.ReadLine();
            string chip = Console.ReadLine();
            char[] letter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm' };
            string noFirst = chip.Trim(letter);
            Console.WriteLine(noFirst);
            string[] numbers = noFirst.Split(letter);
            char[] capLetters = new char[numbers.Length];
            int count = 0;
            for (int i = 0; i < chip.Length; i++)
            {
                if (chip[i] >= 'A' && chip[i] <= 'Z')
                {
                    capLetters[count] = chip[i];
                    count++;
                }
            }
        }
    }

