using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanStudentWorker
{
    class TestHumStudWorker
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
          { 
              new Student( "Student1","S1Lastname", 9 ),
              new Student( "Student2","S2Lastname", 7 ),
              new Student( "Student3","S3Lastname", 3 ),
              new Student( "Student4","S4Lastname", 4 ),
              new Student( "Student5","S5Lastname", 5 ),
              new Student( "Student6","S6Lastname", 8 ),
              new Student( "Student7","S7Lastname", 2 ),
              new Student( "Student8","S8Lastname", 1 ),
              new Student( "Student9","S9Lastname", 10 ),
              new Student( "Student10","S10Lastname", 6 )
          };

            foreach (var item in students)
            {
                Console.WriteLine(item.FirstName + " Grade = " + item.Grade);
            }


            students = students.OrderBy(student => student.Grade).ToList();

            Console.WriteLine("----Sorted----");
            foreach (var item in students)
            {
                Console.WriteLine(item.FirstName + " Grade = " + item.Grade);
            }

            //  Initialize an array of 10 workers and sort them by money per hour in descending order.
            List<Worker> workers = new List<Worker>()
          { 
              new Worker( "Worker1","W1Lastname", 250, 20 ),
              new Worker( "Worker2","W2Lastname", 350, 20 ),
              new Worker( "Worker3","W3Lastname", 50, 20 ),
              new Worker( "Worker4","W4Lastname", 1500, 20 ),
              new Worker( "Worker5","W5Lastname", 800, 20 ),
              new Worker( "Worker6","W6Lastname", 210, 20 ),
              new Worker( "Worker7","W7Lastname", 30, 20 ),
              new Worker( "Worker8","W8Lastname", 145, 20 ),
              new Worker( "Worker9","W9Lastname", 731, 20 ),
              new Worker( "Worker10","W10Lastname", 235, 20 )
          };

            foreach (var item in workers)
            {
                Console.WriteLine(item.FirstName + " Money per Hour= " + item.MoneyPerHour());
            }


            workers = workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();

            Console.WriteLine("----Sorted----");
            foreach (var item in workers)
            {
                Console.WriteLine(item.FirstName + " Money per Hour= " + item.MoneyPerHour());
            }

            Console.WriteLine("----Merged lists and sorted----");

            var mergedlists = workers.Concat<Human>(students).ToList();
            mergedlists = mergedlists.OrderBy(list => list.FirstName).ThenBy(list => list.LastName).ToList();

            foreach (var item in mergedlists)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
