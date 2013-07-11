using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrganization
{
    public class Machine:IPrintable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }

        public Machine(string name, string type, string serialNumber)
        {
            this.Name = name;
            this.Type = type;
            this.SerialNumber = serialNumber;
        }

        public void PrintInfo()
        {
            Console.WriteLine("The Machine Type:{0}, the Machine name:{1}, the Mchine serialNumber is{2}:", this.Type,
                this.Name, this.SerialNumber);
        }
    }
}
