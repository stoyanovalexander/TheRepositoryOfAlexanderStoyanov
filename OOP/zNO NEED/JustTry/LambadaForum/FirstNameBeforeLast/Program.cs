﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNameBeforeLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] myClass = new Student[3];

            Student firstStudent = new Student();
            firstStudent.firstName = "Ivan";
            firstStudent.secondName = "Zabunov";
            myClass[0] = firstStudent;

            Student secondStudent = new Student();
            secondStudent.firstName = "Teodor";
            secondStudent.secondName = "Andonov";
            myClass[1] = secondStudent;

            Student thirdStudent = new Student();
            thirdStudent.firstName = "Pesho";
            thirdStudent.secondName = "Ylov";
            myClass[2] = thirdStudent;

            var sortedClass =
                from student in myClass
                where student.firstName.CompareTo(student.secondName) == -1
                select student;

            foreach (var student in sortedClass)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.secondName);
            }
        }
    }
}
