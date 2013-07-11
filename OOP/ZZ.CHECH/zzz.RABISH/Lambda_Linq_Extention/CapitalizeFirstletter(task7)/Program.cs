using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;


public delegate void SimpleDelegate(int t);
public class Timer
{
    static void TestMethod(int t)
    {
        Console.WriteLine("I was called by a delegate.");
        Thread.Sleep(t * 1000);
    }
    static void Main()
    {
        Console.Write("t=");
        int t = int.Parse(Console.ReadLine());
        SimpleDelegate d = new SimpleDelegate(TestMethod);
        while (true)
        {
            d(t);
        }
        
    }
}
