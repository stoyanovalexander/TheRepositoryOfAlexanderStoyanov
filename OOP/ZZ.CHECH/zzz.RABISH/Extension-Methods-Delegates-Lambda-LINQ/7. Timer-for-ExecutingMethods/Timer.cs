/* Using delegates write a class Timer that has can execute certain method at each t seconds. */

using System;
using System.Diagnostics;
using System.Threading;


public delegate void UseTimer();

public class Timer
{
    static void TestMethod()
    {
        DateTime time = DateTime.Now;
        Console.WriteLine("{0:HH:mm:ss ч.}", time);
    }
    static void Main()
    {
        Console.WriteLine("Start timer");
        Console.WriteLine("===========");

        while (true)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Thread.Sleep(1000);

            UseTimer method = TestMethod;
            method();
        }
    }
}

