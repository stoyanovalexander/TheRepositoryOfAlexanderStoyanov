using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SecondSchoolStudentTeach
{
    class Class:
    {
        //Fields
        private List<Student> students;
        private List<Teacher> teachers;
        private string id;
        private List<string> comments;

        //Properties
        /// <summary>
        /// Gets an array of all the students in the class
        /// </summary>
        public Student[] Students
        {
            get
            {
                return this.students.ToArray();
            }
            private set
            {
            }
        }

        /// <summary>
        /// Gets an array of all the teachers for the class
        /// </summary>
        public Teacher[] Teachers
        {
            get
            {
                return this.teachers.ToArray();
            }
            private set
            {
            }
        }

        /// <summary>
        /// Gets or sets the id of the class
        /// </summary>
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// Get the comments for a student
        /// </summary>
        public string[] Comments
        {
            get
            {
                return this.comments.ToArray();
            }
        }

        //Constructors
        /// <summary>
        /// Create new class
        /// </summary>
        /// <param name="students">Array of students</param>
        /// <param name="teachers">Array of teachers</param>
        /// <param name="id">Class id</param>
        public Class(Student[] students, Teacher[] teachers, string id)
        {
            this.students = new List<Student>(students);
            this.teachers = new List<Teacher>(teachers);
            this.id = id;
            this.comments = new List<string>();
        }

        //Methods 
        /// <summary>
        /// Add new student to the class
        /// </summary>
        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        /// <summary>
        /// Remove a student from the class
        /// </summary>
        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        /// <summary>
        /// Add new Teacher to the class
        /// </summary>
        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        /// <summary>
        /// Remove a teacher from the class
        /// </summary>
        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

        /// <summary>
        /// Add comment
        /// </summary>
        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }
    }
}
