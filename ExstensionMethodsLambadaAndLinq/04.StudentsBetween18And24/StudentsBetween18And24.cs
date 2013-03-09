using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class StudentsBetween18And24
    {
        static void Main(string[] args)
        {

            Student[] myPeople = new Student[3];

            Student firstStudent = new Student();
            firstStudent.firstName = "Ivan";
            firstStudent.lastName = "Popov";
            firstStudent.age = 19;
            myPeople[0] = firstStudent;

            Student secondStudent = new Student();
            secondStudent.firstName = "Huren";
            secondStudent.lastName = "Tekin";
            secondStudent.age = 24;
            myPeople[1] = secondStudent;

            Student thirdStudent = new Student();
            thirdStudent.firstName = "Iasen";
            thirdStudent.lastName = "Asenov";
            thirdStudent.age = 33;
            myPeople[2] = thirdStudent;
            CheckAge(myPeople);
        }

        static void CheckAge(Student[] someArrOfStudent)
        {
            var arrAfterCheck =
                from student in someArrOfStudent
                where student.age >= 18 && student.age <= 24
                select student;
            foreach (var student in arrAfterCheck)
            {
                Console.WriteLine("{0} {1}",student.firstName,student.lastName);
            }
        }
    }

