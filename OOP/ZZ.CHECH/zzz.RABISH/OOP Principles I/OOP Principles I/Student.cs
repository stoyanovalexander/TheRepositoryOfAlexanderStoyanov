using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student : Person
    {
        private int _number;
        private List<string> _comments;

        public List<string> Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public Student(string name, int number)
            : base(name)
        {
            _number = number;
            _comments = new List<string>();
        }

        public void AddComment(string comment)
        {
            _comments.Add(comment);
        }
    }
}
