using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanStudentWorker
{
    class TestHumanstudentworker
    {
        static void Main(string[] args)
        {
            //Fill StudentsList 
            List<Student> studentsList = new List<Student>(10) 
            {
                new Student(10, "Nikolay", "Naidenov"),
                new Student(8, "Georgi", "Ivanov"),
                new Student(1, "Filip", "Genov"),
                new Student(12, "Zdravki", "Gospodinov"),
                new Student(10, "Ignat", "Ignatov"),
                new Student(2, "Simeon", "Iliev"),
                new Student(8, "Anton", "Filipov"),
                new Student(7, "Andrei", "Lubenov"),
                new Student(11, "Gosho", "Liubenov"),
                new Student(10, "Cvetan", "Cvetanov"),
            };
            //END Fill StudentsList 
            List<Worker> workersList = new List<Worker>(10)
            {
                new Worker("Asen","Asenov",5.6,6),
                new Worker("Peter","Asenov",5.2,5),
                new Worker("Asen","Qnkov",7.3,6),
                new Worker("Rosen","Popov",7.6,3),
                new Worker("Lilian","Lilov",5.6,9),
                new Worker("Kamen","Asenov",7.6,8),
                new Worker("Qvor","Asenov",5.4,8),
                new Worker("Rosen","Rumenov",7.6,9),
                new Worker("Huren","Chakr",8.6,8),
                new Worker("Angel","Angelov",5.6,7),
            };
         
            var sortedStudents = from student in studentsList
                                orderby student.Grade ascending
                                select student;

            Console.WriteLine("========== STUDENTS ==========");

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0,-12} {1,-12}: {2} ",student.FirstName,student.LastName,student.Grade);
            }
            
            workersList = workersList.OrderByDescending(worker => worker.MoneyPerHour()).ToList();
            Console.WriteLine();
            Console.WriteLine("========== WORKERS ============");
            foreach (var worker in workersList)
            {
                Console.WriteLine("{0,-12} {1,-12}: {2}",worker.FirstName,worker.LastName,worker.MoneyPerHour());
            }
            
            // HUMAN LIST  
            List<Human> humanList = new List<Human>(20);
            humanList.AddRange(studentsList);
            humanList.AddRange(workersList);
         
            var sortHuman = from person in humanList
                            orderby person.FirstName ascending, person.LastName ascending
                            select person;
            Console.WriteLine();
            Console.WriteLine("========== HUMAN ==========");
            foreach (var person in sortHuman)
            {
                Console.WriteLine("{0,-12} {1,-12}",person.FirstName,person.LastName);
            }
        }
    }
}