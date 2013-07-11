using System;

namespace _5.HandsShake
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            N = N/2;

            double catalanN = 1;
            //if (N == 0)
            //// catalan0=(2*0)!/((0+1)!*0!)=1/1= 1
            //{
            //    Console.WriteLine("catalanN=" + 1);
            //}
            //else if (N == 1)
            //// catalan1=(1*2)!/((1+1)!*1!)=2/2= 1
            //{
            //    Console.WriteLine("catalanN=" + 1);
            //}
            //else
            //{
                for (uint divisor = 2, dividend = 2 * (uint)N; divisor <= N; divisor++, dividend--)
                //catalan5=(2*5)!/((5+1)!*5!)=10!/(6!*5!)=(10*9*8*7)/(2*3*4*5)= (10/2) * (9/3) * (8/4) * (7/5)
                {
                    catalanN = catalanN * ((double)dividend / (double)divisor);
                }
                Console.WriteLine(catalanN);
            //}
        }
    }
}
