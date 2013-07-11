using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanStudentWorker
{
    class Worker : Human
    {
        private double weekSalary;
        private int workHoursPerDay;

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public Worker(string firstName,string lastName,double salary, int workHours):base(firstName,lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = salary;
            this.WorkHoursPerDay = workHours;
        }

        public double MoneyPerHour()
        {
            double moneyPerHour = WeekSalary / (WorkHoursPerDay * 5.0);
            return moneyPerHour;
        }

        public static int CompareMoneyPerHour(Worker one, Worker two)
        {
            return one.MoneyPerHour().CompareTo(two.MoneyPerHour());
        }
    }
}
