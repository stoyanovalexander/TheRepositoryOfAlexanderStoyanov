using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Firm
{
    public struct GiveTakeForMounthDeclare
    {
        public double Give { get; set; }
        public double Take { get; set; }

        public GiveTakeForMounthDeclare(double give, double take):this()
        {
            this.Give = give;
            this.Take = take;
        }

        public override string ToString()
        {
            return string.Format("The Firm give for last moonth: {0}, and take: {1}", Give,Take);
        }
    }
}
