using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
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
        CheckNames(myPeople);
    }

    static void CheckNames(Student[] someArrOfStudents)
    {
        var arrAfterCheck =
               from student in someArrOfStudents
               where student.firstName.CompareTo(student.lastName) == -1
               select student;

        foreach (var student in arrAfterCheck)
        {
            Console.WriteLine("{0} {1}", student.firstName, student.lastName);
        }
    }
}
