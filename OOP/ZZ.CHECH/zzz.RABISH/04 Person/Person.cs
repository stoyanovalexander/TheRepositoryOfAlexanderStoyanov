using System;

class Person
{
    public string Name { get; set; }
    public byte? Age { get; set; }

    public Person(string name)
        : this(name, null)
    {

    }

    public Person(string name, byte? age)
    {
        if (name == string.Empty || name == null || name.Length < 2)
        {
            throw new ArgumentOutOfRangeException("The name should be at least three characters long.");
        }
        else
        {
            this.Name = name;
        }
        if (age < 0 || age > 110)
        {
            throw new ArgumentOutOfRangeException("Please enter an age in the range [0...110]!");
        }
        else
        {
            this.Age = age;
        }

    }
    public override string ToString()
    {
        return string.Format("Name: {0}; Age: {1}", this.Name, ((this.Age.ToString() != "") ? this.Age.ToString() : "<unspecified>"));
    }
}

