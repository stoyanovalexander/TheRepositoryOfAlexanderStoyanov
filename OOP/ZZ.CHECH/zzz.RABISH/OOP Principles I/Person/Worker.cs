using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Worker : Human
    {
        public double WeekSalary { get; private set; }
        public double WorkHoursPerDay { get; private set; }

        public Worker(string firstName, string lastName, double salary, double workHours)
            : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
            this.WeekSalary = salary;
            this.WorkHoursPerDay = workHours;
        }

        public double MoneyPerHour()
        {
            return WeekSalary / (WorkHoursPerDay * 5.0);
        }
    }
}
