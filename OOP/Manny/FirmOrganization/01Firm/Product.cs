using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrganization
{
    public class Product:IProductGainable,IPrintable
    {
        public string Name { get; set; }
        public double PriceToDo { get; set; }
        public int HoursToDo { get; set; }
        public double PriceToSell { get; set; }
        public Matirial TheMatirial;

        //public Matirial TheMatirial
        //{
        //    get { return this.theMatirial; }
        //    set { this.theMatirial = value; }
        //}

        public Product(string name, double priceToDo, int hoursToDo,double priceToSell,Matirial theMatirial)
        {
            this.Name = name;
            this.PriceToDo = priceToDo;
            this.HoursToDo = hoursToDo;
            this.PriceToSell = priceToSell;
            this.TheMatirial =theMatirial;
        }

        public double CalculatingProductGain()
        {
            return this.PriceToSell - this.PriceToDo;
        }

        public void PrintInfo()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", this.Name,
                this.PriceToDo, this.HoursToDo,this.PriceToSell,this.TheMatirial);
        } 
    }
}
