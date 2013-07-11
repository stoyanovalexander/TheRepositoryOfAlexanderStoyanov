using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTry
{
    public enum CoffeeSize
    {
        Small=80,Normal=130,Double=260
    }C:\Telerik\OOP\JustTry\JustTry\CoffeeSize.cs

    public class Coffee
    {
        public CoffeeSize size;
        public Coffee(CoffeeSize size)
        {
            this.size = size;
        }
        public CoffeeSize Size
        {
            get { return size; }
        }
    }
}
