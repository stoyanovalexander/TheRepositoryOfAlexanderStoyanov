using System;
using System.Threading;
using System.Globalization;
    class MathExpression
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            // Input data
            decimal N = decimal.Parse(Console.ReadLine());
            decimal M = decimal.Parse(Console.ReadLine());
            decimal P = decimal.Parse(Console.ReadLine());

            // Solve
            decimal result = (((N * N) + (1 / (M * P) + 1337)) / (N - (128.523123123m * P))) + (decimal)(Math.Sin((int)M % 180));
            Console.WriteLine("{0:0.000000}",result);
        }
    }

