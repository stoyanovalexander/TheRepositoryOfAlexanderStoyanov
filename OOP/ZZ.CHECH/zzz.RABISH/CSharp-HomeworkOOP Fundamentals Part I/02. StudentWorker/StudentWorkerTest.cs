using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentWorker
{
    class StudentWorkerTest
    {
        static void Main()
        {
            Console.WriteLine("======= Student Test ========\n");
            List<Student> students = new List<Student> 
            { 
                new Student("Mario", "Mitkov", 5),
                new Student("Marin", "Rashev", 3),
                new Student("Kiril", "Raykov", 6),
                new Student("Johnatan", "Smith", 4),
                new Student("David", "Koch", 4),
                new Student("Martin", "Aleksandrov", 6),
                new Student("Kalin", "Peshev", 3),
                new Student("Georgi", "Sotirov", 6),
                new Student("Denis", "Mitkov", 5),
                new Student("Ivan", "Hristov", 3)
            };
            var sortedStudents = students.OrderBy(student => student.Grade);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Student name: {0} {1}, Grade: {2}", student.FirstName, student.LastName, student.Grade);
            }
            Console.WriteLine();
            Console.WriteLine("======= Worker Test =======\n");

            List<Worker> workers = new List<Worker>
            {
                new Worker("Krasimir", "Stoyanov", 220, 7),
                new Worker("Bai", "Ivan", 140, 8),
                new Worker("Malin", "Miroslavov", 190, 7),
                new Worker("Georgi", "Krystev", 200, 8),
                new Worker("Evgeni", "Mareshkov", 120, 6),
                new Worker("Bai", "Pesho of Vraca", 340, 8),
                new Worker("Aleksandar", "Malinov", 400, 8),
                new Worker("Svetlana", "Masleva", 280, 9),
                new Worker("Kamelia", "Manova", 440, 8),
                new Worker("Kurnelia", "Ninova", 150, 12)
            };

            var sortedWorkers = workers.OrderBy(worker => worker.MoneyPerHour(worker.WorkSalary, worker.WorkHoursPerDay));

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine("Worker name: {0} {1}, Week salary: {2}, Money / hour: {3}", worker.FirstName, worker.LastName, worker.WorkSalary, worker.MoneyPerHour(worker.WorkSalary, worker.WorkHoursPerDay));

            }

            Console.WriteLine();
            Console.WriteLine("======== Merged and Sorted =========");

            var mergedStudentsWorkers = workers.Concat<Human>(students);

            var studentWorkers = mergedStudentsWorkers.OrderBy(studentWorker => studentWorker.FirstName).ThenBy(studentWorker => studentWorker.LastName);

            foreach (var studentWorker in studentWorkers)
            {
                Console.WriteLine("Name: {0} {1}", studentWorker.FirstName, studentWorker.LastName);
            }
        }
    }
}
