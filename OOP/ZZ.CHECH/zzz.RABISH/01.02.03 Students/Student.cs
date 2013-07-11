using System;

class Student : ICloneable, IComparable<Student>
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public int SSN { get; set; }
    public string PermanentAdress { get; set; }
    public string MobilePhone { get; set; }
    public string Email { get; set; }
    public byte? Course { get; set; }
    public University UniversityName { get; set; }
    public Faculty FacultyName { get; set; }
    public Specialty SpecialtyName { get; set; }

    public Student(string firstName, string middleName, string lastName, int sSN, string permanentAddress, string mobilePhone,
        string email, University university, Faculty faculty, Specialty specialty, byte? course)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
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
        if (!Object.Equals(this.MiddleName, student.MiddleName))
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

    public static bool operator ==(Student student01, Student student02)
    {
        return Student.Equals(student01, student02);
    }
    public static bool operator !=(Student student01, Student student02)
    {
        return !(Student.Equals(student01, student02));
    }
    public override int GetHashCode()
    {
        return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
    }
    public override string ToString()
    {
        return String.Format("Student(Name: {0} {1} {2}, SSN: {3})", this.FirstName, this.MiddleName, this.LastName, this.SSN);
    }
    public Student Clone()
    {
        Student newStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAdress,
            this.MobilePhone, this.Email, this.UniversityName, this.FacultyName, this.SpecialtyName, this.Course);

        return newStudent;
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
        if (this.MiddleName != student.MiddleName)
        {
            return (this.MiddleName.CompareTo(student.MiddleName));
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