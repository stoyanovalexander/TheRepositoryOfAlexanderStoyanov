using System;
    class BonusPoints
    {
        static void Main()
        {
            Console.Write("Enter number of points[1,9]: ");
            byte points = byte.Parse(Console.ReadLine());
            switch (points)
            {
                case 1:
                        Console.WriteLine("pointsWithBonus=" + points*10); break;
                case 2:
                    Console.WriteLine("pointsWithBonus=" + points*10); break;
                case 3:
                    Console.WriteLine("pointsWithBonus=" + points*10); break;


                case 4:
                    Console.WriteLine("pointsWithBonus=" + points*100); break;
                case 5:
                    Console.WriteLine("pointsWithBonus=" + points*100); break;
                case 6:
                    Console.WriteLine("pointsWithBonus=" + points*100); break;


                case 7:
                    Console.WriteLine("pointsWithBonus=" + points*1000); break;
                case 8:
                    Console.WriteLine("pointsWithBonus=" + points*1000); break;
                case 9:
                    Console.WriteLine("pointsWithBonus=" + points*1000); break;

                default:
                    Console.WriteLine("There is same mistake"); break;

            }
        }
    }
