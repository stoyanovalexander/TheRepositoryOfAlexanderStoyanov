using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrganization
{
    class FirmOrganizationTest
    {
        static void Main(string[] args)
        {
            Machine First = new Machine("RVD-400", "DPC-RVD", "1324ASD");
            First.PrintInfo();

        }
    }
}
