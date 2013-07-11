using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class StringBuilderExtensions
{
    public static StringBuilder SubBuild (this StringBuilder strBuild, int start, int length)
    {
       StringBuilder tempBuild = new StringBuilder();
        for (int i = start; i <= start+length-1; i++)
			{
			    tempBuild.Append(strBuild[i]);
			}
        return tempBuild;
    }
    public static StringBuilder SubBuild(this StringBuilder strBuild, int start)
    {
        StringBuilder tempBuild = new StringBuilder();
        for (int i = start; i < strBuild.Length; i++)
        {
            tempBuild.Append(strBuild[i]);
        }
        return tempBuild;
    }
}
class Program
{
    static void Main(string[] args)
    {
        string str = "abvg";
        Console.WriteLine(str);
        StringBuilder strBuild = new StringBuilder();
        strBuild.Append(str);
        string subStr = str.Substring(1, 2);
        StringBuilder subStrBuild = strBuild.SubBuild(1,2);
        Console.WriteLine(subStr);
        Console.WriteLine(subStrBuild);
    }
}

