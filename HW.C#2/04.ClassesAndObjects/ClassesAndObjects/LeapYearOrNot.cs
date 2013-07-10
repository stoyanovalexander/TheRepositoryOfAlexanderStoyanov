using System;
class LeapYearOrNot
    {
        static void Main()
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("The year: {0} is Leap", year);
            }
            else
            {
                Console.WriteLine("The year: {0} is NOT!!! leap",year);
            }
        }
    }

