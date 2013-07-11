using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Firm
{
    public class InvalidRangeException<T> : Exception
    {
        public T Start { get; set; }
        public T End { get; set; }
        public InvalidRangeException(string msg, T start, T end)
            : base(msg)
        {
            this.Start = start;
            this.End = end;
        }
    }
}
