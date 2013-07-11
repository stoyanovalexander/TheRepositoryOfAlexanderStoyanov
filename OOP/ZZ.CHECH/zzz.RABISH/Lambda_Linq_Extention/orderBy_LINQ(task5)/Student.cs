using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string Name { get; set; }
    public string Family { get; set; }
    public int Age { get; set; }
    public override string ToString()
    {
        string result;
        result = string.Format("Name = {0} Family = {1} Age = {2}", this.Name, this.Family, this.Age);
        return result;
    }
}
