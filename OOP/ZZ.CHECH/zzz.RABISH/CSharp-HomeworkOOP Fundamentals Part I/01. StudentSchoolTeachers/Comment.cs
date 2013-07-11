using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_HomeworkOOP_Fundamentals_Part_I
{
    public class Comment
    {
        //Fields.
        public string UserCommented { get; set; }
        public string CommentBody { get; set; }

        //Constructors.
        public Comment()
        { 
        }
        public Comment(string user, string commentBody)
        {
            this.UserCommented = user;
            this.CommentBody = commentBody;
        }

        //Methods.
        public override string ToString()
        {
            string result;
            StringBuilder comment = new StringBuilder();
            comment.Append("Published By: " + this.UserCommented);
            comment.Append("\n");
            comment.Append(this.CommentBody);
            result = comment.ToString();

            return result;
        }
    }
}
