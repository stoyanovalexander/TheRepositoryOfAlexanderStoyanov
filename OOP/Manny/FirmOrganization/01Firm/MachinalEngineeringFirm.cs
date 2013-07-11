using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01Firm;

namespace FirmOrganization
{
    public class MachinalEngineeringFirm:IPrintable
    {
        public string Name{get; set;}
        public string Address { get; set; }
        public string ProducedProducts { get; set; }
        public Worker Owner { get; set; }
        public List<Worker> Workers { get; set; }
        public List<Machine> Machines { get; set; }
        public GiveTakeForMounthDeclare TheDeclaration { get; set; }

        public MachinalEngineeringFirm(string name,string address,string producedProducts,Worker owner,
            List<Worker> workers,List<Machine> machines,GiveTakeForMounthDeclare theDeclaration)
        {
            this.Name=name;
            this.Address=address;
            this.ProducedProducts=producedProducts;
            this.Owner=owner;
            this.Workers=workers;
            this.Machines = machines;
            this.TheDeclaration = theDeclaration;
        }

        public void PrintInfo()
        {
            Console.WriteLine("{0}, {1}, {2}, owner:{3}, workers num:{4}, machines num:{5} ", this.Name,
                this.Address, this.ProducedProducts,Owner.Name,this.Workers.Count,this.Machines.Count);
        }
    }
}
