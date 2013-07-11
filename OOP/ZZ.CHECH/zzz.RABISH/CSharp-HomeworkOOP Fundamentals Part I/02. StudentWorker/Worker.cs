using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.StudentWorker
{
    public class Worker : Human
    {
        //Fields.
        public double WorkSalary;
        public byte WorkHoursPerDay;

        //Constructor.
        public Worker()
        { 
        }
        public Worker(string firstName, string lastName, double workSalary, byte workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WorkSalary = workSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        //Methods.
        public double MoneyPerHour(double workSalary, byte hoursPerDay)
        {
            return workSalary / ((double)hoursPerDay * 5);
        }
    }
}
