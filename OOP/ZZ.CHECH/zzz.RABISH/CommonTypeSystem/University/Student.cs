using System;
using System.Text;

namespace University
{
    /// <summary>
    /// Student class. Stores student data. Implements ICloneable and IComparable interfaces.
    /// </summary>
    public class Student : ICloneable, IComparable<Student>
    { /*1. Define a class Student, which contains data about a student – first, middle and last name, SSN, 
        * permanent address, mobile phone e-mail, course, specialty, university, faculty. 
        * Use an enumeration for the specialties, universities and faculties. 
        * Override the standard methods, inherited by  System.Object: Equals(), ToString(), 
        * GetHashCode() and operators == and !=.
        *
        * 2.Add implementations of the ICloneable interface. 
        * The Clone() method should deeply copy all object's fields into a new object of type Student.
        * 
        * 3. Implement the  IComparable<Student> interface to compare students by names 
        * (as first criteria, in lexicographic order) and by social security number 
        * (as second criteria, in increasing order).        */
        
        #region Private Fields
        
        /// <summary>
        /// First name.
        /// </summary>
        private string firstName;

        /// <summary>
        /// Middle name.
        /// </summary>
        private string middleName;

        /// <summary>
        /// Last name.
        /// </summary>
        private string lastName;

        /// <summary>
        /// Social Security Number.
        /// </summary>
        private ulong ssn;

        /// <summary>
        /// Address.
        /// </summary>
        private string address;

        /// <summary>
        /// Mobile phone number.
        /// </summary>
        private string mobilePhone;

        /// <summary>
        /// Email Address.
        /// </summary>
        private string email;

        /// <summary>
        /// Course.
        /// </summary>
        private string course;
        
        #endregion

        #region Constructors
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Student" /> class.
        /// </summary>
        /// <param name="firstName">First Name.</param>
        /// <param name="middleName">Middles Name.</param>
        /// <param name="lastName">Last Name.</param>
        /// <param name="ssn">Social Security Number.</param>
        /// <param name="address">Address.</param>
        /// <param name="mobilePhone">Mobile Phone Number.</param>
        /// <param name="email">Email Address.</param>
        /// <param name="course">Course.</param>
        /// <param name="specialty">Specialty.</param>
        /// <param name="university">University.</param>
        /// <param name="faculty">Faculty.</param>
        public Student(
            string firstName,
            string middleName,
            string lastName,
            ulong ssn,
            string address,
            string mobilePhone,
            string email,
            string course,
            Specialty specialty,
            University university,
            Faculty faculty)
        {
            this.FirstName = firstName;
            this.middleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }
        
        #endregion

        #region Public Properties
        
        /// <summary>
        /// Gets or sets specialty.
        /// </summary>
        public Specialty Specialty { get; set; }
        
        /// <summary>
        /// Gets or sets university.
        /// </summary>
        public University University { get; set; }
        
        /// <summary>
        /// Gets or sets faculty.
        /// </summary>
        public Faculty Faculty { get; set; }
        
        /// <summary>
        /// Gets or sets first name.
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            
            set
            {
                this.firstName = value;
            }
        }
        
        /// <summary>
        /// Gets or sets middle name.
        /// </summary>
        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            
            set
            {
                this.middleName = value;
            }
        }
        
        /// <summary>
        /// Gets or sets last name.
        /// </summary>
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            
            set
            {
                this.lastName = value;
            }
        }
        
        /// <summary>
        /// Gets or sets Social Security Number.
        /// </summary>
        public ulong Ssn
        {
            get
            {
                return this.ssn;
            }
            
            set
            {
                this.ssn = value;
            }
        }
        
        /// <summary>
        /// Gets or sets address.
        /// </summary>
        public string Address
        {
            get
            {
                return this.address;
            }
            
            set
            {
                this.address = value;
            }
        }

        /// <summary>
        /// Gets or sets mobile number.
        /// </summary>
        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            
            set
            {
                this.mobilePhone = value;
            }
        }

        /// <summary>
        /// Gets or sets email address.
        /// </summary>
        public string Email
        {
            get
            {
                return this.email;
            }
            
            set
            {
                this.email = value;
            }
        }

        /// <summary>
        /// Gets or sets course.
        /// </summary>
        public string Course
        {
            get
            {
                return this.course;
            }
            
            set
            {
                this.course = value;
            }
        }
        
        #endregion
        
        #region Override Methods
        /// <summary>
        /// Checks if Student1 and Student2 contains identical data.
        /// </summary>
        /// <param name="student1">Student one.</param>
        /// <param name="student2">Student two.</param>
        /// <returns>True or False.</returns>
        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        /// <summary>
        /// Checks if Student1 and Student2 contains different data.
        /// </summary>
        /// <param name="student1">Student one.</param>
        /// <param name="student2">Student two.</param>
        /// <returns>True or False.</returns>
        public static bool operator !=(Student student1, Student student2)
        {
            return !Student.Equals(student1, student2);
        }

        /// <summary>
        /// Checks if current student have identical data with another.
        /// </summary>
        /// <param name="param">Another Student.</param>
        /// <returns>True or False.</returns>
        public override bool Equals(object param)
        {
            // If the cast is invalid, the result will be null
            Student student = param as Student;
            
            // Check if we have valid not null Student object
            if (student == null)
            {
                return false;
            }
            
            // Compare First Name
            if (!object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }
            
            // Compare Middle Name
            if (!object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }
            
            // Compare Last Name
            if (!object.Equals(this.LastName, student.LastName))
            {
                return false;
            }
            
            // Compare SSN
            if (this.Ssn != student.Ssn)
            {
                return false;
            }
            
            // Compare Address
            if (!object.Equals(this.Address, student.Address))
            {
                return false;
            }
            
            // Compare MobilePhone
            if (!object.Equals(this.MobilePhone, student.MobilePhone))
            {
                return false;
            }
            
            // Compare Email
            if (!object.Equals(this.Email, student.Email))
            {
                return false;
            }
            
            // Compare Course
            if (!object.Equals(this.Course, student.Course))
            {
                return false;
            }
            
            // Compare Specialty
            if (this.Specialty != student.Specialty)
            {
                return false;
            }
            
            // Compare University
            if (this.University != student.University)
            {
                return false;
            }
            
            // Compare Faculty
            if (this.Faculty != student.Faculty)
            {
                return false;
            }
        
            return true;
        }
        
        /// <summary>
        /// Calculates hash code for current object.
        /// </summary>
        /// <returns>Generated Hash code.</returns>
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.Ssn.GetHashCode();
        }
        
        /// <summary>
        /// Beautify Student data.
        /// </summary>
        /// <returns>Human readable text.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Student: {0} {2} {1}", this.FirstName, this.LastName, this.MiddleName));
            result.AppendLine("SSN: " + this.Ssn);
            result.AppendLine("Address: " + this.Address);
            result.AppendLine("MobilePhone: " + this.MobilePhone);
            result.AppendLine("Email: " + this.Email);
            result.AppendLine("Course: " + this.Course);
            result.AppendLine("Speciality: " + this.Specialty);
            result.AppendLine("University: " + this.University);
            result.AppendLine("Faculty: " + this.Faculty);
        
            return result.ToString();
        }
        
        #endregion
        
        #region Methods
        
        /// <summary>
        /// Creates a deep copy of Student.
        /// </summary>
        /// <returns>A deep cloning.</returns>
        public object Clone()
        { 
            return new Student(
                string.Copy(this.FirstName),
                string.Copy(this.MiddleName),
                string.Copy(this.LastName),
                this.Ssn,
                string.Copy(this.Address),
                string.Copy(this.MobilePhone),
                string.Copy(this.Email),
                string.Copy(this.Course),
                this.Specialty,
                this.University,
                this.Faculty);
        }
        
        /// <summary>
        /// Compares students by first name. Then by Social Security Number.
        /// </summary>
        /// <param name="student">An object of type Student.</param>
        /// <returns>-1: Before; 0: Equal; 1: After;</returns>
        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            { // Compare names
                return this.FirstName.CompareTo(student.FirstName);
            }
            else
            { // Compare SSN
                if (this.Ssn != student.Ssn)
                {
                    return this.Ssn.CompareTo(student.Ssn);
                }
            }
        
            return 0;
        }

        #endregion
    }
}