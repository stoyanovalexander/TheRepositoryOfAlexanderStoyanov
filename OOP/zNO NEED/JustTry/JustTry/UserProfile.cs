using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTry
{
    public class UserProfile
    {
        public int UserId { get;private set ;}
        public string Firstname { get; private set; }
        public string LastName { get; private set; }

        public UserProfile(int userId, string firstName, string lastName)
        {
            this.UserId = userId;
            this.Firstname = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return string.Format("id:{0},First name: {1}, last name:{2}",this.UserId,this.Firstname,this.LastName);
        }
    }
}
