using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrganization
{
    public class Section
    {
        public string Name { get; set; }
        public List<Worker> SectionWorkers { get; set; }
        public Worker MainWorker { get; set; }

        public Section(string name, List<Worker> sectionWorkers, Worker mainWorker)
        {
            this.Name = name;
            this.SectionWorkers = sectionWorkers;
            this.MainWorker = mainWorker;
        }
    }
}
