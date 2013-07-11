using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Discipline
    {
        private string _name;
        private int _numOfLectures;
        private int _numOfExcersices;
        private List<string> _comments;

        public List<string> Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }

        public Discipline(string name, int numOfLectures, int numOfExercices)
        {
            _name = name;
            _numOfLectures = numOfLectures;
            _numOfExcersices = numOfExercices;
            this.Comments = new List<string>();
        }

        public int NumOfExcersices
        {
            get { return _numOfExcersices; }
            set { _numOfExcersices = value; }
        }

        public int NumOfLectures
        {
            get { return _numOfLectures; }
            set { _numOfLectures = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this._name, this._numOfLectures, this._numOfExcersices);
        }
    }
}
