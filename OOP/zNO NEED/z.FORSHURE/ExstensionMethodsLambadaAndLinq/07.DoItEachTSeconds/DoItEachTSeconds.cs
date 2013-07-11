using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _07.DoItEachTSeconds
{
    class DoItEachTSeconds
    {
        static void Main(string[] args)
        {
            Timer.TimerDel theTask = PrintMyName;
            Timer.measure.Start();
            while (true)
            {
                Timer.DoIteEachTSeconds(5, theTask);
            }
        }

        public static void PrintMyName()
        {
            Console.WriteLine("Alexander");
        }
    }
}
