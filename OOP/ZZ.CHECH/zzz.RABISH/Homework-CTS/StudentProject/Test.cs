using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    class Test
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>() {
            new Student("Pesho", "Velkov", "Petrov", "7837834665"),
            new Student("Stoyan", "Ivanov", "Petrov", "345345", "Sample Address 111", "434555623",
                "samplemail@sample.com", 2, Specialty.BussinessMan, Faculty.Economy, University.UNSS),
            new Student("Evlogi", "Petrov", "Atanasov", "434566565"),
            new Student("Danail", "Keracudov", "Traminerov", "67744545")
            };
            foreach (var item in studentList)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            Console.WriteLine(studentList[0].Equals(studentList[1]));
            Console.WriteLine(studentList[0] != studentList[2]);
            Console.WriteLine(studentList[0] == studentList[3]);

            Student cloneStudent = studentList[0].Clone();
            Console.WriteLine("Student Clone:");
            Console.WriteLine(cloneStudent);

            Console.WriteLine();
            Console.WriteLine("Sorting to demonstrate IComparable...");
            studentList.Sort();
            foreach (var item in studentList)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

        }
    }
}