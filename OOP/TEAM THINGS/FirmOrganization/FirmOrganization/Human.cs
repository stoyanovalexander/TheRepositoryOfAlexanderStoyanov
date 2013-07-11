using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrganization
{
    public abstract class Human
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public char Sex { get; set; }
        public int EGN { get; set; }
        public string Phone { get; set; }
    }
}
