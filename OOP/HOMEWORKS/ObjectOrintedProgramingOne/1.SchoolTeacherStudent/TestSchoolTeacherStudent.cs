using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolTeacherStudent
{
    class TestSchoolTeacherStudent
    {
        static void Main(string[] args)
        {
            People me = new People();
            me.HumanName = "Alexander";
            Console.WriteLine(me.HumanName);
            Console.WriteLine();
            School mySchool = new School("Matevski");
            Console.WriteLine(mySchool.Name);
            Console.WriteLine();
            Discipline firstIvanovDiscipline=new Discipline("MAT",40,30);
            Discipline secondIvanovDiscipline=new Discipline("ALGEBRA",30,20);
            List<Discipline> ivanovDisciplines=new List<Discipline>{firstIvanovDiscipline,secondIvanovDiscipline};
            Teacher ivanov=new Teacher("Ivan Ivanov",ivanovDisciplines);
  
            Discipline petrovaDiscipline=new Discipline("LITERATURE",30,30);
            List<Discipline>petrovaDisciplines=new List<Discipline>{petrovaDiscipline};
            string firstComentAboutPetrova="I don't like her.";
            string secondComentAboutPetrova="I like her.";
            List<string> comentsAboutPetrova= new List<string>();
            comentsAboutPetrova.Add(firstComentAboutPetrova);
            comentsAboutPetrova.Add(secondComentAboutPetrova);
            Coment aboutPetrova=new Coment(comentsAboutPetrova);
            Teacher petrova=new Teacher("Neda Petrova",petrovaDisciplines,aboutPetrova);

            Student angel = new Student("Angel", 1);
            Student ivan = new Student("Ivan", 2);
            Student huren = new Student("Huren", 3);
            List<Student> myPeople = new List<Student> { angel,ivan,huren };
            List<Teacher> myTeachers=new List<Teacher> {ivanov,petrova};
            Class myClass = new Class(myTeachers, myPeople, "7a");

            Console.WriteLine(myClass.TextIdentifier);
            Console.WriteLine();
            Console.WriteLine("{0}: {1}, {2}",myTeachers[0].Name,ivanovDisciplines[0].Name,ivanovDisciplines[1].Name);
            Console.WriteLine();
            Console.WriteLine("{0}: {1}",myTeachers[1].Name,petrovaDisciplines[0].Name);
            Console.WriteLine(comentsAboutPetrova[0]);
            Console.WriteLine(comentsAboutPetrova[1]);
            Console.WriteLine();
            Console.WriteLine("{0}  lectures:{1}  exercises:{2}",ivanovDisciplines[0].Name,ivanovDisciplines[0].NumOfLectures,
                ivanovDisciplines[0].NumOfExercises);
            Console.WriteLine("{0}  lectures:{1}  exercises:{2}", ivanovDisciplines[1].Name, ivanovDisciplines[1].NumOfLectures,
                ivanovDisciplines[1].NumOfExercises);
            Console.WriteLine("{0}  lectures:{1}  exercises:{2}", petrovaDisciplines[0].Name, petrovaDisciplines[0].NumOfLectures,
                petrovaDisciplines[0].NumOfExercises);
            Console.WriteLine();
            Console.WriteLine("MY CLASS");
            Console.WriteLine("{0}: {1}",myPeople[0].ClassNumber,myPeople[0].Name);
            Console.WriteLine("{0}: {1}", myPeople[1].ClassNumber, myPeople[1].Name);
            Console.WriteLine("{0}: {1}", myPeople[2].ClassNumber, myPeople[2].Name);
        }
    }
}
