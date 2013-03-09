using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortStodentsWithLambada
{
    class SortStudentsWithLambadaAndLinq
    {
        static void Main(string[] args)
        {
            Student[] myPeople = new Student[3];

            Student firstStudent = new Student();
            firstStudent.firstName = "Ivan";
            firstStudent.lastName = "Popov";
            myPeople[0] = firstStudent;

            Student secondStudent = new Student();
            secondStudent.firstName = "Huren";
            secondStudent.lastName = "Tekin";
            myPeople[1] = secondStudent;

            Student thirdStudent = new Student();
            thirdStudent.firstName = "Iasen";
            thirdStudent.lastName = "Asenov";
            myPeople[2] = thirdStudent;
            Console.WriteLine("SORTED WITH LAMBADA");
            LambadaSorting(myPeople);
            Console.WriteLine();
            Console.WriteLine("SORTED WITH LINQ");
            LinqSorting(myPeople);
        }

        static void LambadaSorting(Student[] someArrOfStudents)
        {
            var arrAfterSort = someArrOfStudents.OrderByDescending(x => x.firstName).ThenByDescending(x => x.lastName);
            foreach (var student in arrAfterSort)
            {
                Console.WriteLine("{0} {1}",student.firstName,student.lastName);
            }
        }

        static void LinqSorting(Student[] someArrOfStudents)
        {
            var arrAfterSort =
                from student in someArrOfStudents
                orderby student.firstName descending, student.lastName descending
                select student;
            foreach (var student in arrAfterSort)
            {
                Console.WriteLine("{0} {1}",student.firstName,student.lastName);
            }
        }
    }
}
