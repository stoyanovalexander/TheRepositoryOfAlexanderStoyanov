using System;

namespace Exception
{
    class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public T Start
        {
            get
            {
                return this.start;
            }
            set
            {
                this.start = value;
            }
        }

        public T End
        {
            get 
            {
                return this.end;
            }
            set
            {
                this.end = value;
            }
        }

        public InvalidRangeException(T start, T end, string msg)
            : base(msg)
        {
            this.Start = start;
            this.End = end;
        }
    }
}