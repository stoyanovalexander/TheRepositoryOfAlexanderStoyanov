using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RiskWinRiskLoseStupidTwo
{
    class RiskWinRiskLoseStupidTwo
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            int countOfTraps = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < start.Length; i++)
            {
                int startDigit = start[i] - '0';
                int endDigit = end[i] - '0';

                count += Math.Min(Math.Abs(startDigit - endDigit), 10-Math.Abs((startDigit - endDigit)));
            }

            Console.WriteLine(count);
        }
    }
}
