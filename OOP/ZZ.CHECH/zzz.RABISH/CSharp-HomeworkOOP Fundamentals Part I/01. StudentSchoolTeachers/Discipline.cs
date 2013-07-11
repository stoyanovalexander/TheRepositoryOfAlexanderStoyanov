using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_HomeworkOOP_Fundamentals_Part_I
{
    public class Discipline
    {
        //Fields.
        private string name;
        private int numberOfLections;
        private int numberOfExercises;
        public List<Comment> Comments;

        //Constructors.
        public Discipline()
        { 
        
        }
        public Discipline(string name, int numberOfLections, int numberOfExercises)
        { 
            this.name = name;
            this.numberOfExercises = numberOfExercises;
            this.numberOfLections = numberOfLections;
        }

        //Properties.
        public string Name
        {
            get { return this.name; }
            set 
            {
                if (value != null)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("The value cannot be null!!!");
                }
            }
        }
        public int NumberOfLections 
        {
            get
            {
                return this.numberOfLections;
            }
            set
            {
                if (value != null)
                {
                    this.numberOfLections = value;
                }
                else
                {
                    throw new ArgumentException("Tha value cannot be null!!!");
                }
            }
        }
        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value != null)
                {
                    this.numberOfExercises = value;
                }
                else
                {
                    throw new ArgumentException("The value cannot be null!!!");
                }
            }
        }

        //Methods.
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
