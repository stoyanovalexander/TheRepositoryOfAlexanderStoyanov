using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RiskWinRiskLose
{
    class RiskWinRiskLoseStupidOne
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int digitStart = start % 10;
            int digitEnd = end % 10;
            int count=0;
            int diference = Math.Abs(digitStart - digitEnd);
            if (diference < 5)
            {
                count += diference;
            }
            else
            {
                count += (10 - diference);
            }



            digitStart = (start/10)%10;
            digitEnd = (end/10)%10;
            if (diference < 5)
            {
                count += diference;
            }
            else
            {
                count += (10 - diference);
            }


            digitStart = (start / 100) % 10;
            digitEnd = (end / 100) % 10;
            if (diference < 5)
            {
                count += diference;
            }
            else
            {
                count += (10 - diference);
            }


            digitStart = (start / 1000) % 10;
            digitEnd = (end / 1000) % 10;
            if (diference < 5)
            {
                count += diference;
            }
            else
            {
                count += (10 - diference);
            }



            digitStart = (start / 10000) % 10;
            digitEnd = (end / 10000) % 10;
            if (diference < 5)
            {
                count += diference;
            }
            else
            {
                count += (10 - diference);
            }

            Console.WriteLine(count);
        }
    }
}
