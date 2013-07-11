using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


        public static class Timer
        {
            public static Stopwatch measure = new Stopwatch();

            public static void DoIteEachTSeconds(int t, TimerDel someMethod)
            {
                if (measure.ElapsedTicks > t*1000000)
                {
                    someMethod();
                    measure.Restart();
                }
            }

            public delegate void TimerDel();
        }


