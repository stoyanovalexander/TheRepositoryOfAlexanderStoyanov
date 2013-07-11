using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_HomeworkOOP_Fundamentals_Part_I
{
    public class ClassOfStudents
    {
        //Fields.
        public List<Teacher> TeachersList { get; set; }
        public List<Student> StudentsList { get; set; }

        //Constructors.
        public ClassOfStudents()
        { 
            
        }

        //Methods.
        public void AddStudent(Student student)
        {
            StudentsList.Add(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            TeachersList.Add(teacher);
        }
    }
}
