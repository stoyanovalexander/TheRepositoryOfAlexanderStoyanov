using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanStudentWorker
{
    class Worker:Human
    {
        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public Worker(string firstName, string lastName, double salary, double workHours)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = salary;
            this.WorkHoursPerDay = workHours;
        }

        public double MoneyPerHour()
        {
            return WeekSalary / (WorkHoursPerDay * 5.0);
        }

        public static int CompareMoneyPerHour(Worker one, Worker two)
        {
            return one.MoneyPerHour().CompareTo(two.MoneyPerHour());
        }
    }
}
