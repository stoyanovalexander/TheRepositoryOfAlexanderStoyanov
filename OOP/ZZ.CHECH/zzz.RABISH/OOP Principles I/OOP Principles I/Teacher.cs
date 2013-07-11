using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Teacher : Person
    {
        List<Discipline> _disciplines;
        public string Comments { get; set; }

        public Teacher(string name, string comment = null)
            : base(name)
        {
            this._disciplines = new List<Discipline>();
            this.Name = name;
            this.Comments = comment;
        }

        public List<Discipline> Disciplines
        {
            get { return this._disciplines; }
        }
    }
}
