using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrganization
{
    public class Firm
    {
        public string Name{get; set;}
        public string Address { get; set; }
        public string ProducedProducts { get; set; }
        public List<Human> Owners { get; set; }
        public List<Worker> Workers { get; set; }
        public List<MachinesType> MachinesTypeInTheFirm { get; set; }      
    }
}
