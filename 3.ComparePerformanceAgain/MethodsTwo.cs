using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3.ComparePerformanceAgain
{
    class MethodsTwo
    {
        public static dynamic SquareRoot(dynamic number)
        {
            if (number is decimal)
            {
                dynamic theSquareRoot = 0;
                Stopwatch timer = new Stopwatch();
                timer.Start();
                for (dynamic i = 0; i < 1000; i++)
                {
                    theSquareRoot = Math.Sqrt((double)number); // Math.Sqrt does not work with decimal
                }
                timer.Stop();
                return timer.Elapsed;
            }
            else
            {
                dynamic theSquareRoot = 0;
                Stopwatch timer = new Stopwatch();
                timer.Start();
                for (dynamic i = 0; i < 1000; i++)
                {
                    theSquareRoot = Math.Sqrt(number);
                }
                timer.Stop();
                return timer.Elapsed;
            }
        }

        public static dynamic Sin(dynamic number)
        {
            if (number is decimal)
            {
                dynamic theSin = 0;
                Stopwatch timer = new Stopwatch();
                timer.Start();
                for (dynamic i = 0; i < 1000; i++)
                {
                    theSin = Math.Sin((double)number); // Math.Sin does not work with decimal
                }
                timer.Stop();
                return timer.Elapsed;
            }
            else
            {
                dynamic theSin = 0;
                Stopwatch timer = new Stopwatch();
                timer.Start();
                for (dynamic i = 0; i < 1000; i++)
                {
                    theSin = Math.Sin(number);
                }
                timer.Stop();
                return timer.Elapsed;
            }
        }

        public static dynamic NaturalLogarithm(dynamic number)
        {
            if (number is decimal)
            {
                dynamic theNaturalLogarithm = 0;
                Stopwatch timer = new Stopwatch();
                timer.Start();
                for (dynamic i = 0; i < 1000; i++)
                {
                    theNaturalLogarithm = Math.Log((double)number);  // Math.Log does not work with decimal
                }
                timer.Stop();
                return timer.Elapsed;
            }
            else
            {
                dynamic theNaturalLogarithm = 0;
                Stopwatch timer = new Stopwatch();
                timer.Start();
                for (dynamic i = 0; i < 1000; i++)
                {
                    theNaturalLogarithm = Math.Log(number);
                }
                timer.Stop();
                return timer.Elapsed;
            }
        }
    }
}
