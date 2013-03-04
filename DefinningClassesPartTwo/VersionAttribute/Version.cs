using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[AttributeUsage (AttributeTargets.Struct | AttributeTargets.Interface |
    AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Method) ]

public class Version : System.Attribute
{
    public int Major { get; set; }
    public int Minor { get; set; }
    public string Versions;

    public Version(int major, int minor)
    {
        this.Major = major;
        this.Minor = minor;
        this.Versions = string.Format("{0}.{1}", major, minor);
    }
}
