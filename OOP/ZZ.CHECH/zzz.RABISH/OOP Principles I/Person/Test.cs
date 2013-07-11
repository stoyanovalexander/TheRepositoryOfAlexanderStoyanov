using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Test
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
          {
              new Student( "Student1","1Lastname", 12 ),
              new Student( "Student2","2Lastname", 9 ),
              new Student( "Student3","3Lastname", 8 ),
              new Student( "Student4","4Lastname", 4 ),
              new Student( "Student5","5Lastname", 5 ),
              new Student( "Student6","6Lastname", 1 ),
              new Student( "Student7","7Lastname", 12 ),
              new Student( "Student8","8Lastname", 7 ),
              new Student( "Student9","9Lastname", 11 ),
              new Student( "Student10","10Lastname", 6 )
          };
            List<Worker> workers = new List<Worker>()
            {                      
                new Worker( "Woker1","1Lastname",1500, 52),
                new Worker( "Woker2","2Lastname",200, 60),
                new Worker( "Woker3","3Lastname",300, 168),
                new Worker( "Woker4","4Lastname",700, 34),
                new Worker( "Woker5","5Lastname",500, 24),
                new Worker( "Woker6","6Lastname",1200, 64),
                new Worker( "Woker7","7Lastname",500, 12),
                new Worker( "Woker8","8Lastname",800, 77),
                new Worker( "Woker9","9Lastname",500, 90),
                new Worker( "Woker10","10Lastname",1505, 66)
            };
            foreach (var item in students)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.Grade);
            }
            Console.WriteLine();
            students = students.OrderBy(student => student.Grade).ToList();
            foreach (var item in workers)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.MoneyPerHour());
            }
            workers = workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();

            List<Human> people = new List<Human>();
            people.AddRange(students);
            people.AddRange(workers);

            people = people.OrderBy(person => person.FirstName).ThenBy(person => person.LastName).ToList();
            foreach (var item in people)
            {
                Console.WriteLine(item.FirstName);
            }
            
        }
    }
}
