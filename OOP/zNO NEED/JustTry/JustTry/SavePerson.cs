using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTry
{
    class SavePerson
    {
        private string name;
        private int age;
        public SavePerson(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be empty!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("Name is too short!");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Name is too long!");
                }
                foreach (char ch in value)
                {
                    if (!IsLetterAllowedInNames(ch))
                    {
                        throw new ArgumentException("Invalid name!");
                    }
                }
                this.name=value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("Invalid age!");
                }
                this.age = value;
            }
        }

        private bool IsLetterAllowedInNames(char ch)
        {
            bool isAllowed = char.IsLetter(ch) || ch == '-' || ch == ' ';
            return isAllowed;
        }
    }
}
