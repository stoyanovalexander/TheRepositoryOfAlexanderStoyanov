using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrganization
{
    public class MachinesType
    {
        public string NameOfTheType { get; set; }
        public int NumberOfMachines { get; set; }
        public List<Machine> Machines { get; set; }

        public MachinesType(string nameOfTheType, int numberOfMachines, List<Machine> machines)
        {
            this.NameOfTheType = nameOfTheType;
            this.NumberOfMachines = numberOfMachines;
            this.Machines = machines;
        }

    }
}
