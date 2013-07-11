using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrganization
{
    public class Product
    {
        public string Name { get; set; }
        public int PriceToDo { get; set; }
        public int HoursToDoo { get; set; }
        public Matirial TheMatirial { get; set; }

        public Product(string name, int priceToDo, int hoursToDo, Matirial theMatirial)
        {
            this.Name = name;
            this.PriceToDo = priceToDo;
            this.HoursToDoo = hoursToDo;
            this.TheMatirial = theMatirial;

        }
    }
}
