using System;

namespace PersonProject
{
    class Person
    {
        private string name;
        private int? age;

        public Person(string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid name value.");
                }

                name = value;
            }
        }

        public int? Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return string.Format("Person:[Name:[{0}], Age[{1}]]",
                Name,
                Age == null ? "Not Specified" : Age.ToString());
        }
    }
}