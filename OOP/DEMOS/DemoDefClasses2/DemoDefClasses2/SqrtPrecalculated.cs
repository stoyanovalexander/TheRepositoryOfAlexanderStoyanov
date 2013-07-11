using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDefClasses2
{
    class SqrtPrecalculated
    {
        public const int maxValue = 10000;
        private static int[] sqrtValues;
        static SqrtPrecalculated()
        {
            sqrtValues = new int[maxValue + 1];
            for (int i = 0; i < sqrtValues.Length; i++)
            {
                sqrtValues[i] = (int)Math.Sqrt(i);
            }
        }
        public static int GetSqrt(int value)
        {
            return sqrtValues[value];
        }
    }
}
