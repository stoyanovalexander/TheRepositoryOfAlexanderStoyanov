using System;

namespace Exception
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            try
            {
                int start = 1;
                int end = 100;

                int testInt = int.Parse(Console.ReadLine());

                if (testInt < start || testInt > end)
                {
                    throw new InvalidRangeException<int>(1, 100, "Out of range");
                }
            }
            catch (InvalidRangeException<int> myException)
            {
                Console.WriteLine("The number must be between {0} and {1}!", myException.Start, myException.End);
            }

            try
            {
                DateTime start = new DateTime(1980, 1, 1);
                DateTime end = new DateTime(2013, 12, 31);
                Console.Write("Date: ");
                int date = int.Parse(Console.ReadLine());
                Console.Write("Month: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());
                DateTime testDateTime = new DateTime(year, month, date);
                if (testDateTime < start || testDateTime > end)
                {
                    throw new InvalidRangeException<DateTime>(start, end, "Date out of range!");
                }
            }
            catch (InvalidRangeException<DateTime> myException)
            {
                Console.WriteLine("The date must be between {0} and {1}!", myException.Start, myException.End);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}