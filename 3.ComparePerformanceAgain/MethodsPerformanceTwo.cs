using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ComparePerformanceAgain
{
    class MethodsPerformanceTwo
    {
        static void Main(string[] args)
        {
            //Check SQUAREROOT performance
            Console.WriteLine("======================Check SQUAREROOT performance=========================");
            Console.WriteLine("FLOAT time for 1000 operations SQUAREROOT:   " + MethodsTwo.SquareRoot(3f));
            Console.WriteLine("DOUBLE time for 1000 operations SQUAREROOT:  " + MethodsTwo.SquareRoot(3.0d));
            Console.WriteLine("DECIMAL time for 1000 operations SQUAREROOT: " + MethodsTwo.SquareRoot(3.0m));
            Console.WriteLine();

            //Check NATURAL LOGARITHM performance
            Console.WriteLine("======================Check NATURAL LOGARITHM performance=========================");
            Console.WriteLine("FLOAT time for 1000 operations NATURAL LOGARITHM:   " + MethodsTwo.NaturalLogarithm(3f));
            Console.WriteLine("DOUBLE time for 1000 operations NATURAL LOGARITHM:  " + MethodsTwo.NaturalLogarithm(3.0d));
            Console.WriteLine("DECIMAL time for 1000 operations NATURAL LOGARITHM: " + MethodsTwo.NaturalLogarithm(3.0m));
            Console.WriteLine();

            //Check SIN performance
            Console.WriteLine("======================Check SIN performance=========================");
            Console.WriteLine("FLOAT time for 1000 operations SIN:   " + MethodsTwo.Sin(3f));
            Console.WriteLine("DOUBLE time for 1000 operations SIN:  " + MethodsTwo.Sin(3.0d));
            Console.WriteLine("DECIMAL time for 1000 operations SIN: " + MethodsTwo.Sin(3.0m));
            Console.WriteLine();
        }
    }
}
