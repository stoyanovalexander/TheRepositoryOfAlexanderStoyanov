using System;
    class WhichDayIsToday
    {
        static void Main()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Today is "+today.DayOfWeek);
        }
    }

