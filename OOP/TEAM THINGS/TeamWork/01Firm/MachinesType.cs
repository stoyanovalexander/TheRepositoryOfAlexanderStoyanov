using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrganization
{
    public class MachinesType:IPrintable
    {
        public string TheType { get; set; }
        public Worker Monitor { get; set; }
        public List<Machine> Machines { get; set; }

        public MachinesType(string theType, Worker monitor , List<Machine> machines)
        {
            this.TheType = theType;
            this.Monitor = monitor;
            this.Machines = machines;
        }

        public void PrintInfo()
        {
            Console.WriteLine("{0}, {1}, {2}", this.TheType,
                this.Monitor.Name, this.Machines.Count);
        }


    }
}
