using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrganization
{
    public class Human
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public char Sex { get; set; }
        public int EGN { get; set; }
        public string Phone { get; set; }

        public Human(string name, string address, char sex, int egn, string phone)
        {
            this.Name = name;
            this.Address = address;
            this.Sex = sex;
            this.EGN = egn;
            this.Phone = phone;
        }

       
    }
}
