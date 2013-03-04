using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Version(99, 33)]
class VersionAttributeTest
{
    static void Main()
    {
        Type type = typeof(VersionAttributeTest);
        object[] versionAttributes = type.GetCustomAttributes(false);
        foreach (Version versionAttribute in versionAttributes)
        {
            Console.WriteLine("The version of the class is {0}.{1}",
                versionAttribute.Major, versionAttribute.Minor);
        }
        Console.WriteLine();
    }
}
