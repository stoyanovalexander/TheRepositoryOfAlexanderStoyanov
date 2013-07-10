using System;
    class WorkDays
    {
        public static DateTime[] holidays ={new DateTime(2012,01,01),new DateTime(2012,03,03),new DateTime(2012,02,14),
                                          new DateTime(2012,12,24),new DateTime(2012,12,25),new DateTime(2012,09,22),
                                          new DateTime(2012,12,31),new DateTime(2013,01,01),new DateTime(2013,01,02)};
        static void CountingWorkDays(DateTime day)
        {
            int count = 0;
            DateTime theDay = DateTime.Today;
            while (theDay != day)
            {
                if ((theDay.DayOfWeek != DayOfWeek.Saturday) && ((theDay.DayOfWeek != DayOfWeek.Sunday)))
                {
                    count++;
                    for (int i = 0; i < holidays.Length; i++)
                    {
                        if (holidays[i] == theDay)
                        {
                            count--;
                        }
                    }
                }
               theDay=theDay.AddDays(-1);
            }
            Console.Write(count);
        }
        static void Main()
        {
            Console.WriteLine("Enter day-2012,12,12-");
            DateTime day = DateTime.Parse(Console.ReadLine());
            CountingWorkDays(day);
            Console.Write(" : were work days between today and entered day");
            Console.WriteLine();
        }
    }

