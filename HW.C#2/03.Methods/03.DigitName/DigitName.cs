using System;
    class DigitName
    {
        static void PrintWithLetters(int num)
        {
            int LastDigit = num % 10;
            switch(LastDigit)
            {
                case 0:
                    Console.Write("Zero"); break;
                case 1:
                    Console.Write("One"); break;
                case 2:
                    Console.Write("Two"); break;
                case 3:
                    Console.Write("Three"); break;
                case 4:
                    Console.Write("Four"); break;
                case 5:
                    Console.Write("Five"); break;
                case 6:
                    Console.Write("Six"); break;
                case 7:
                    Console.Write("Seven"); break;
                case 8:
                    Console.Write("Eight"); break;
                case 9:
                    Console.Write("Nine"); break;
                default:
                    Console.Write("There are some mistake");break;
            }
        }
        static void Main()
        {
            Console.Write("Enter some number: ");
            int someNum = int.Parse(Console.ReadLine());
            Console.Write("      →");
            PrintWithLetters(someNum);
            Console.WriteLine();
        }
    }

