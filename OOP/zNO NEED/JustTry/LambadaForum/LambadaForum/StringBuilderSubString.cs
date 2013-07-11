﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaForum
{
    public static class StringBuilderSubString
    {
        public static StringBuilder SubString(this StringBuilder input, int index, int length)
        {
            StringBuilder subString = new StringBuilder();

            if (index + length >= input.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Out of range");
            }

            int endIndex = index + length;

            for (int i = index; i < endIndex; i++)
            {
                subString.Append(input[i]);
            }

            return subString;
        }
    }
}
