using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder test = new StringBuilder();
        test.AppendLine("SomeText");
        Console.WriteLine(test.SubString(5, 3).ToString());
    }
}
