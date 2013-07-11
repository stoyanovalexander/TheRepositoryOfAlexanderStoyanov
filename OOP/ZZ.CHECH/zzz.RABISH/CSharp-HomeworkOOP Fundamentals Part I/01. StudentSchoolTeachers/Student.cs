using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_HomeworkOOP_Fundamentals_Part_I
{
    public class Student : Person
    {
        //Fields.
        private uint uniqueClassNumber;
        //private List<String> Comments;
        public List<Comment> Comments;

        //Constructors.
        public Student()
        { }
        public Student(string name, uint uniqueClassNumber)
        {
            this.Name = name;
            this.uniqueClassNumber = uniqueClassNumber;
        }

        //Properties.
        public uint UniqueClassNumber 
        {
            get 
            { 
                return this.uniqueClassNumber;
            }
            set 
            {
                if (value != null)
                {
                    this.uniqueClassNumber = value;
                }
            }
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
