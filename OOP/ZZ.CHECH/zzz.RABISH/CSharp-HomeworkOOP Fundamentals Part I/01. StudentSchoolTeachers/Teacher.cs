using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_HomeworkOOP_Fundamentals_Part_I
{
    public class Teacher : Person
    {
        //Fields.
        public List<Discipline> Disciplines;
        public List<Comment> Comments;

        //Constructors.
        public Teacher()
        { 
        }
        public Teacher(string name)
        {
            this.Name = name;
        }
        //Methods.
        public void AddDiscipline(Discipline discipline)
        {
            Disciplines.Add(discipline);
        }
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void GetComments()
        {
            for (int i = 0; i < Comments.Count; i++)
            {
                Console.WriteLine(Comments[i]);
            }
        }
    }
}
