using System;
    class NumbersTextCorrespondence
    {
        static void Main()
        {
            Console.Write("Enter number[0,999]: ");
            ushort number = ushort.Parse(Console.ReadLine());
            if (number > 999)
            {
                Console.WriteLine("Enter smaller value of number");
            }
            else
            {
                byte hundreds = (byte)(number / 100);
                byte remainder100 = (byte)(number % 100);
                byte dozens = (byte)(remainder100 / 10);
                byte singles = (byte)(remainder100 % 10);

                string hundredsText = null;
                string dozensText = null;
                string singlesText = null;
                if (remainder100 != 0)
                {
                    if (hundreds > 0) // For numbers bigger than 100 dozens and singles are not with capital letter.
                    {
                        switch (hundreds)
                        {
                            case 1:
                                hundredsText = "One hundred and"; break;
                            case 2:
                                hundredsText = "Two hundred and"; break;
                            case 3:
                                hundredsText = "Three hundred and"; break;
                            case 4:
                                hundredsText = "Four hundred and"; break;
                            case 5:
                                hundredsText = "Five hundred and"; break;
                            case 6:
                                hundredsText = "Six hundred and"; break;
                            case 7:
                                hundredsText = "Seven hundred and"; break;
                            case 8:
                                hundredsText = "Eight hundred and"; break;
                            case 9:
                                hundredsText = "Nine hundred and"; break;
                            default:
                                Console.WriteLine("There is some mistake"); break;
                        }

                        if (dozens != 1)
                        {
                            switch (dozens)
                            {
                                case 0:
                                    dozensText = null; break;
                                case 2:
                                    dozensText = "twenty"; break;
                                case 3:
                                    dozensText = "thirty"; break;
                                case 4:
                                    dozensText = "forty"; break;
                                case 5:
                                    dozensText = "fifty"; break;
                                case 6:
                                    dozensText = "sixty"; break;
                                case 7:
                                    dozensText = "seventy"; break;
                                case 8:
                                    dozensText = "eighty"; break;
                                case 9:
                                    dozensText = "ninety"; break;
                                default:
                                    Console.WriteLine("There is some mistake"); break;
                            }
                            switch (singles)
                            {
                                case 1:
                                    singlesText = "one"; break;
                                case 2:
                                    singlesText = "two"; break;
                                case 3:
                                    singlesText = "three"; break;
                                case 4:
                                    singlesText = "four"; break;
                                case 5:
                                    singlesText = "five"; break;
                                case 6:
                                    singlesText = "six"; break;
                                case 7:
                                    singlesText = "seven"; break;
                                case 8:
                                    singlesText = "eight"; break;
                                case 9:
                                    singlesText = "nine"; break;
                                default:
                                    singlesText = null; break;
                            }
                        }
                        else // dozens=1;
                        {
                            switch (singles)
                            {
                                case 0:
                                    dozensText = "ten"; break;
                                case 1:
                                    dozensText = "eleven"; break;
                                case 2:
                                    dozensText = "twelve"; break;
                                case 3:
                                    dozensText = "thirteen"; break;
                                case 4:
                                    dozensText = "fourteen"; break;
                                case 5:
                                    dozensText = "fifteen"; break;
                                case 6:
                                    dozensText = "sixteen"; break;
                                case 7:
                                    dozensText = "seventeen"; break;
                                case 8:
                                    dozensText = "eighteen"; break;
                                case 9:
                                    dozensText = "nineteen"; break;
                                default:
                                    Console.WriteLine("There is some mistake"); break;
                            }
                        }
                    }
                    else // For numbers [0,99] dozens and singles my be with capital letter.(hundreds=0).
                    {
                        if (dozens > 1)
                        {
                            switch (dozens)
                            {
                                case 2:
                                    dozensText = "Twenty"; break;
                                case 3:
                                    dozensText = "Thirty"; break;
                                case 4:
                                    dozensText = "Forty"; break;
                                case 5:
                                    dozensText = "Fifty"; break;
                                case 6:
                                    dozensText = "Sixty"; break;
                                case 7:
                                    dozensText = "Seventy"; break;
                                case 8:
                                    dozensText = "Eighty"; break;
                                case 9:
                                    dozensText = "Ninety"; break;
                                default:
                                    Console.WriteLine("Ther is some mistake"); break;
                            }

                            switch (singles)
                            {
                                case 1:
                                    singlesText = "one"; break;
                                case 2:
                                    singlesText = "two"; break;
                                case 3:
                                    singlesText = "three"; break;
                                case 4:
                                    singlesText = "four"; break;
                                case 5:
                                    singlesText = "five"; break;
                                case 6:
                                    singlesText = "six"; break;
                                case 7:
                                    singlesText = "seven"; break;
                                case 8:
                                    singlesText = "eight"; break;
                                case 9:
                                    singlesText = "nine"; break;
                                default:
                                    singlesText = null; break;
                            }
                        }
                        else if (dozens == 1)
                        {
                            switch (singles)
                            {
                                case 0:
                                    dozensText = "Ten"; break;
                                case 1:
                                    dozensText = "Eleven"; break;
                                case 2:
                                    dozensText = "Twelve"; break;
                                case 3:
                                    dozensText = "Thirteen"; break;
                                case 4:
                                    dozensText = "Fourteen"; break;
                                case 5:
                                    dozensText = "Fifteen"; break;
                                case 6:
                                    dozensText = "Sixteen"; break;
                                case 7:
                                    dozensText = "Seventeen"; break;
                                case 8:
                                    dozensText = "Eighteen"; break;
                                case 9:
                                    dozensText = "Nineteen"; break;
                                default:
                                    Console.WriteLine("There is some mistake"); break;
                            }
                        }
                        else // dozens=0
                        {
                            switch (singles)
                            {
                                case 1:
                                    singlesText = "One"; break;
                                case 2:
                                    singlesText = "Two"; break;
                                case 3:
                                    singlesText = "Three"; break;
                                case 4:
                                    singlesText = "Four"; break;
                                case 5:
                                    singlesText = "Five"; break;
                                case 6:
                                    singlesText = "Six"; break;
                                case 7:
                                    singlesText = "Seven"; break;
                                case 8:
                                    singlesText = "Eight"; break;
                                case 9:
                                    singlesText = "Nine"; break;
                                default:
                                    Console.WriteLine("There is a mistake"); break;
                            }
                        }
                    }
                }

                else // Reminder100=0 .
                {
                    switch (hundreds)
                    {
                        case 0:
                            hundredsText = "Zero"; break;
                        case 1:
                            hundredsText = "One hundred"; break;
                        case 2:
                            hundredsText = "Two hundred"; break;
                        case 3:
                            hundredsText = "Three hundred"; break;
                        case 4:
                            hundredsText = "Four hundred"; break;
                        case 5:
                            hundredsText = "Five hundred"; break;
                        case 6:
                            hundredsText = "Six hundred"; break;
                        case 7:
                            hundredsText = "Seven hundred"; break;
                        case 8:
                            hundredsText = "Eight hundred"; break;
                        case 9:
                            hundredsText = "Nine hundred"; break;
                        default:
                            Console.WriteLine("Ther is some mistake"); break;
                    }
                }
                Console.WriteLine("{0} → {1} {2} {3}", number, hundredsText, dozensText, singlesText);
            }
        }
    }