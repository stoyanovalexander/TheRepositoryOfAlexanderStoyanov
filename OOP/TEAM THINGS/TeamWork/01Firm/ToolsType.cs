using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrganization
{
    public class ToolsType:IPrintable
    {
        public string NameOfTheType { get; set; }
        public List<Tool> Tools { get; set; }

        public ToolsType(string nameOfTheType, List<Tool> tools)
        {
            this.NameOfTheType = nameOfTheType;
            this.Tools = tools;
        }
   
        public void PrintInfo()
        {
            Console.WriteLine("{0}, {1}",this.NameOfTheType,this.Tools.Count);
        }
    }
}
