using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SecondSchoolStudentTeach
{
    class Test
    {
        static void Main(string[] args)
        {
            ////YOUR NAME
            //Console.WriteLine("Enter your name:");
            //string myName = Console.ReadLine();
            //People thisIsMe=new People();
            //thisIsMe.HumanName=myName;
            //Console.WriteLine();

            ////SCHOOL
            //Console.WriteLine("Enter your school:");
            //string mySchool=Console.ReadLine();
            //School MySchool = new School(mySchool);
            //Console.WriteLine();

            ////STUDENTS
            //Console.WriteLine("Enter the num of the students in my class:");
            //int myClassStudNum = int.Parse(Console.ReadLine());
            //List<Student> myPeple = new List<Student>();
            //for (int i = 0; i < myClassStudNum; i++)
            //{
            //    Console.WriteLine("Student name:");
            //    string myClassStudName = Console.ReadLine();
            //    Console.WriteLine("Student Identifier:");
            //    int myClassStudIdent=int.Parse(Console.ReadLine());
            //    Student studentInMyClass=new Student(myClassStudName,myClassStudIdent);
            //    myPeple.Add(studentInMyClass);
            //}
            //Console.WriteLine();



            ////TEACHERS
            //Console.WriteLine("Teachers of my class number:");
            //int myTeachersNum = int.Parse(Console.ReadLine());
            //List<Teacher> myTeachers = new List<Teacher>();
            //for (int i = 0; i < myTeachersNum; i++)
            //{
            //    //DISCIPLINES
            //    Console.WriteLine("Enter the num of Disciplines:");
            //    int disciplinesNum = int.Parse(Console.ReadLine());
            //    List<Discipline> discipline = new List<Discipline>();
            //    for (int j = 0; j < disciplinesNum; j++)
            //    {
            //        Console.WriteLine("Discipline name:");
            //        string disciplineName = Console.ReadLine();
            //        Console.WriteLine("num of Lectures:");
            //        int lecturesNum = int.Parse(Console.ReadLine());
            //        Console.WriteLine("num of Exercises:");
            //        int exercisesNum = int.Parse(Console.ReadLine());
            //        Discipline someDiscipline = new Discipline(disciplineName, lecturesNum, exercisesNum);
            //        discipline.Add(someDiscipline);
            //    }

            //    // TEACHER COMENTS
            //    Console.WriteLine("number of coment for this Teacher:");
            //    int teacherComentNum = int.Parse(Console.ReadLine());
            //    List<string> someComents=new List<string>();
            //    for (int k = 0; k< teacherComentNum;k++ )
            //    {
            //        Console.WriteLine("Add coment about teacher:");
            //        string coment = Console.ReadLine();
            //        someComents.Add(coment);
            //    }
            //    Coment aboutTeacher = new Coment(someComents);
            //    Console.WriteLine("Teacher name:");
            //    string myTeacherName = Console.ReadLine();
            //    List<Discipline> myTeacherDisciplines = discipline;
            //    Coment forTecherComent = aboutTeacher;
            //    Teacher myTeacher=new Teacher(myTeacherName,myTeacherDisciplines,forTecherComent);
            //    myTeachers.Add(myTeacher);
            //}
            //Console.WriteLine();


            ////CLASS
            //Console.WriteLine("My class textIdentifier:");
            //string textIdentifier = Console.ReadLine();
            //Class myClass = new Class(myTeachers, myPeple, textIdentifier);
            //Console.WriteLine(mySchool);


            ////PRINT ALL ENTERED INFORMATION
            //Console.WriteLine("       I am:{0}",thisIsMe.HumanName.ToString());
            //Console.WriteLine("    Im from:{0}",MySchool.Name.ToString());
            //Console.WriteLine("My class is:{0}",myClass.TextIdentifier.ToString());
            //for (int i = 0; i < myTeachersNum; i++)
            //{
            //    Console.Write("{0} is my teacher at:",myTeachers[i].Name.ToString());
            //    for (int j = 0; j < myTeachers[i].TeacherDisciplines.Count; j++)
            //    {
            //        Console.Write(" "+myTeachers[i].TeacherDisciplines[j].ToString());
            //    }
            //    Console.WriteLine();
            //    for (int k = 0; k < myTeachers[i].Coments.SomeComents.Count; k++)
            //    {
            //        Console.WriteLine(myTeachers[i].Coments.SomeComents[k]);
            //    }    
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("STUDENTS IN MY CLASS");

            //for (int i = 0; i < myPeple.Count; i++)
            //{
            //    Console.WriteLine("{0}:{1}",myPeple[i].ClassNumber,myPeple[i].Name);
            //}
            Student stud1 = new Student("Mario", 1);
            Student stud2 = new Student("Batman", 4);
            Student stud3 = new Student("Optimus  Prime", 3);
            Student[] students = new Student[] { stud1, stud2, stud3 };

            Discipline disp1 = new Discipline("OOP", 40, 40);

            Teacher teach1 = new Teacher("Morgan Freeman", new Discipline[] { disp1 });
            Teacher[] teachers = new Teacher[] { teach1 };

            Class class1 = new Class(students, teachers, "12A");

            Console.Write("The name of the first discipline of the first teacher of the first class: ");
            Console.WriteLine(class1.Teachers[0].Disciplines[0].Name);


            stud1.AddComment("ninja");
            Console.Write("The first comment for the first studdent: ");
            Console.WriteLine(stud1.Comments[0]);
        }
    }
}
