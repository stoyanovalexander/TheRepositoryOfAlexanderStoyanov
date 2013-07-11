using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1To3.StudentInfo
{
    class TestStudentInfo
    {
        static void Main()
        {
            Student first = new Student("Boyan", "Hristov", "Georgiev", 123, "Sofia, 48, Vasil Levski Blvd",
                "98888888", "boyan@abv.bg", University.UNSS, Faculty.InformaticsFaculty, Specialty.IT, 1);

            Console.WriteLine("Original:" + first);

            Student cloned = first.Clone();

            Console.WriteLine("Cloned:{0}", cloned);

            Console.WriteLine("First and Cloned are the same students: {0}", first.Equals(cloned));

            Console.WriteLine(new string('-', 50));

            cloned.SSN = 2323;
            Console.WriteLine("Cloned :{0} with changed SSN", cloned);
            Console.WriteLine("Original of the cloned {0}", first);

            Console.WriteLine("First and Cloned are the same students after the change of SSN of cloned: {0}", first.Equals(cloned));
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Other three students:");
            Student second = new Student("Ivanka", "Ivanova", "Kancheva", 12111, "Sofia, 64, Hristo Botev Blvd",
                "088888128", "ivanka@abv.bg", University.NewBulgarianUniversity, Faculty.LiteratureFaculty, Specialty.IT, 2);
            Console.WriteLine(second);
            Student third = new Student("Penka", "Mincheva", "Manolova", 23400, "Sofia, 44, Hristo Botev Blvd",
                "088888123", "penka@abv.bg", University.NewBulgarianUniversity, Faculty.LiteratureFaculty, Specialty.IT, 2);
            Console.WriteLine(third);
            Student fourth = new Student("Anna", "Georgieva", "Manova", 4646, "Sofia, 44, Hristo Botev Blvd",
               "088888123", "penka@abv.bg", University.NewBulgarianUniversity, Faculty.MathematicsFaculty, Specialty.Litrature, 2);
            Console.WriteLine(fourth);

            List<Student> sortedStudents = new List<Student>();
            sortedStudents.Add(first);
            sortedStudents.Add(second);
            sortedStudents.Add(cloned);
            sortedStudents.Add(third);
            sortedStudents.Add(fourth);

            sortedStudents.Sort();

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("The sorted students are:");

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
