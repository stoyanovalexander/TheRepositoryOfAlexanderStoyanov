using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1To3.StudentInfo
{
    class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string PermanentAdress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public University UniversityName { get; set; }
        public Faculty FacultyName { get; set; }
        public Specialty SpecialtyName { get; set; }

        public Student(string firstName, string SecondName, string lastName, int sSN, string permanentAddress, string mobilePhone,
            string email, University university, Faculty faculty, Specialty specialty, int course)
        {
            this.FirstName = firstName;
            this.SecondName = SecondName;
            this.LastName = lastName;
            this.SSN = sSN;
            this.PermanentAdress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.UniversityName = university;
            this.FacultyName = faculty;
            this.SpecialtyName = specialty;
            this.Course = course;
        }
        //public Student(string firstName, string middleName, string lastName, int sSN) :
        //    this(firstName, middleName, lastName, sSN, null, null, null, University.Unspecified, Faculty.Unspecified,
        //    Specialty.Unspecified, null)
        //{
        //}
        // =======EQUALS============
        public override bool Equals(object param)
        {
            Student student = param as Student;
            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }
            if (!Object.Equals(this.SecondName, student.SecondName))
            {
                return false;
            }
            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }
            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }
            return true;
        }


        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }
        public static bool operator !=(Student first, Student second)
        {
            return !(Student.Equals(first, second));
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ SecondName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
        }


        public override string ToString()
        {
            return String.Format("Student(Name: {0} {1} {2}, SSN: {3})", this.FirstName, this.SecondName, this.LastName, this.SSN);
        }

        public Student Clone()
        {
            Student original = this;
            Student result = new Student(this.FirstName, this.SecondName, this.LastName, this.SSN, this.PermanentAdress,
                this.MobilePhone, this.Email, this.UniversityName, this.FacultyName, this.SpecialtyName, this.Course);

            return result;
        }
        Object ICloneable.Clone()
        {
            return this.Clone();
        }
        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return (this.FirstName.CompareTo(student.FirstName));
            }
            if (this.SecondName != student.SecondName)
            {
                return (this.SecondName.CompareTo(student.SecondName));
            }
            if (this.LastName != student.LastName)
            {
                return (this.LastName.CompareTo(student.LastName));
            }
            if (this.SSN != student.SSN)
            {
                return (this.SSN - student.SSN);
            }
            return 0;
        }
    }
}
