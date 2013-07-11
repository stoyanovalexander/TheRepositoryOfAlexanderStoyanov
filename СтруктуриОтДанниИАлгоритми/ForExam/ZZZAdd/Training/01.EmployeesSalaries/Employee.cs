using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Employee
    {
        public List<Employee> Subordinates { get; set; }
        public int Salary { get; set; }
        public string Name { get; set; }

        public Employee(string name)
        {
            this.Name = name;
            this.Salary = 1;
            this.Subordinates = new List<Employee>();
        }
    }

