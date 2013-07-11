using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class EmployeesSalaries
    {
        static int allSalaries = 0;
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

            string bossName = Console.ReadLine();
            Employee bigBoss = new Employee(bossName);
            employees.Add(bossName, bigBoss);

            for (int i = 1; i < n; i++)
            {
                string name = Console.ReadLine();
                Employee employee = new Employee(name);
                employees.Add(name, employee);
            }

            for (int i = 0; i < m; i++)
            {
                string line = Console.ReadLine();
                string[] names = line.Split(' ');
                string superiorName = names[0];
                for (int j = 1; j < names.Length; j++)
                {
                    employees[superiorName].Subrdinates.Add(employees[names[j]]);
                }
            }
            DFS(bigBoss);
            Console.WriteLine(allSalaries);

        }

        static void DFS(Employee root)
        {
            if (root.Subrdinates.Count == 0)
            {
                allSalaries += root.Salary;
                return;
            }

            int salary=0;
            foreach (Employee employee in root.Subrdinates)
            {
                DFS(employee);
                salary += employee.Salary;
            }
            root.Salary = salary;
            allSalaries += root.Salary;
        }
    }

    class Employee
    {
        public List<Employee> Subrdinates { get; private set; }
        public int Salary { get; set; }
        public string Name { get; set; }

        public Employee(string name)
        {
            this.Name = name;
            this.Salary = 1;
            this.Subrdinates = new List<Employee>();
        }
    }


