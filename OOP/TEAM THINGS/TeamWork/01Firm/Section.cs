using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrganization
{
    public class Section:IPrintable
    {
        public string Name { get; set; }
        public List<Worker> SectionWorkers { get; set; }
        public Worker Monitor { get; set; }

        public Section(string name, List<Worker> sectionWorkers, Worker monitor)
        {
            this.Name = name;
            this.SectionWorkers = sectionWorkers;
            this.Monitor = monitor;
        }

        public void PrintInfo()
        {
            Console.WriteLine("{0}, {1}, {2}", this.Name,
                this.Monitor.Name, this.SectionWorkers.Count);
        }
    }
}
