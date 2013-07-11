/* Read in MSDN about the keyword event in C# and how to publish events. Re-implement the above using .NET events and 
 * following the best practices.
 */

using System;
using System.Timers;


class ReimplementWithEvents
{
    static void Main()
    {
        Timer timer = new Timer();
        timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        timer.Interval = 1000;
        timer.Enabled = true;

        Console.WriteLine("Start timer:");
        Console.WriteLine("============");
        while (true) ;
    }

    private static void OnTimedEvent(object source, ElapsedEventArgs e)
    {
        DateTime time = DateTime.Now;
        Console.WriteLine("{0:HH:MM:ss ч.}", time);
    }
}

