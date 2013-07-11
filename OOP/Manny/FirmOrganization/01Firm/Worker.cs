using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrganization
{
    public class Worker:Human,IGainable,IPrintable
    {
        public int YearsInTheFirm { get; set; }
        public int WorkHours { get; set; }
        public string Section { get; set; }
        public string TypeMachines { get; set; }
        public double MoneyPerHour { get; set; }

        public Worker(string name, string address, char sex, string egn, string phone, int yearsInTheFirm, int workHours,
            string section, string typeMachines, double moneyPerHour)
            : base(name, address, sex, egn, phone)
        {
            this.YearsInTheFirm = yearsInTheFirm;
            this.WorkHours = workHours;
            this.Section = section;
            this.TypeMachines = typeMachines;
            this.MoneyPerHour = moneyPerHour;
        }

        public double GainCalculating()
        {
            return this.WorkHours * this.MoneyPerHour;
        }

        public void PrintInfo()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", this.Name,
                this.Address, this.Sex,this.EGN,this.Phone,this.YearsInTheFirm,this.WorkHours,this.Section,this.TypeMachines
                ,this.MoneyPerHour);
        }
    }
}
