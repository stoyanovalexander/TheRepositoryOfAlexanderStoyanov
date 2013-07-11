using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class StringInStringBuilder
{
    public static StringBuilder SubString(this StringBuilder someStringBuilder, int index, int length)
    {
        StringBuilder subString = new StringBuilder();
        if ((index + length) < someStringBuilder.Length)
        {
            int endIndex = index + length;
            for (int i = index; i < endIndex; i++)
            {
                subString.Append(someStringBuilder[i]);
            }
            return subString;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Out of range");
        }
    }
}