using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class SchoolClass
    {
        List<Teacher> _teachers;
        private string _identifier;

        public SchoolClass(string identifier)
        {
            this._teachers = new List<Teacher>();
            this._identifier = identifier;
            this.Comments = new List<string>();
        }
        
        public string Identifier
        {
            get { return _identifier; }
            set { _identifier = value; }
        }

        public List<Teacher> Teachers
        {
            get { return this._teachers; }
        }

        public List<string> Comments { get; set; }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }
}
