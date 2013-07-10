using System;
    class SumOfFractions
    {
        static void Main()
        {
            double sum = 1;
            for (ushort i = 2; i <= 1000; i++)
            {
                sum=sum+(1/((Math.Pow(-1.0,(double)i))*i));
            }
            Console.WriteLine("sum="+sum);
        }
    }

