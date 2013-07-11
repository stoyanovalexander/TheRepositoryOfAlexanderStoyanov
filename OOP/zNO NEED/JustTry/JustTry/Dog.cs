using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTry
{
    class Dog
    {
        private string name;
        private string breed;
        public Dog()
        { }
        public Dog(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }
        public void saybau()
        {
            Console.WriteLine("{0} said:Bauuuuu!",this.name??"[unnamed dog]");
        }
    }
}
