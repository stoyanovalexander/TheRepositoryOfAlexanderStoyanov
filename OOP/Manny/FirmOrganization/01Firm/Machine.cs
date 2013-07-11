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
            Console.WriteLine("Name: {0}, Type: {1}, serialNumber: {2}", this.Name,
                this.Type, this.SerialNumber);
        }
    }
}
