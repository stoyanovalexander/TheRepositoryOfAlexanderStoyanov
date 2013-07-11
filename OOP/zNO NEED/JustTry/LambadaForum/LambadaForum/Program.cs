using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaForum
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder testing = new StringBuilder();
            testing.AppendLine("SOME words");
            Console.WriteLine(testing.SubString(5, 5).ToString());
        }
    }
}
