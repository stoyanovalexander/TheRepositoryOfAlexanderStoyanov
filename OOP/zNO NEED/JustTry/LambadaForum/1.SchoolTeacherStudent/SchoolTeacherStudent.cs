using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1.SchoolTeacherStudent
{
    class SchoolTeacherStudent
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student("Huren",22222);
            Student stud2 = new Student("Ivan", 4);
            Student stud3 = new Student("Senior Lilio", 3);
            Student[] students = new Student[] { stud1, stud2, stud3 };

            Discipline disp1 = new Discipline("OOP", 40, 40);

            Teacher teach1 = new Teacher("Peter Chuchev" /*new Discipline[] { disp1 }*/);
            Teacher[] teachers = new Teacher[] { teach1 };

            SchoolClass class1 = new SchoolClass(/*students, teachers,*/ "12A");

            Console.Write("The name of the first discipline of the first teacher of the first class: ");
            Console.WriteLine(class1.Teachers[0].Disciplines[0].Name);


            stud1.AddComment("ninja");
            Console.Write("The first comment for the first studdent: ");
            Console.WriteLine(stud1.Comments[0]);
        }
    }
}
