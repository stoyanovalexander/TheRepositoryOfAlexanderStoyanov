using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    class Display
    {
        // TASK1:  The fields
        private int size;
        private int colorsNum;

        // Task2: DefineConstructors
        public Display(int size, int colorsNum)
        {
            this.size = size;
            this.colorsNum = colorsNum;
        }
        public Display(int size):this(size,0)
        {
        }

        // Task4: MethodForDisplaying
        public override string ToString()
        {
            return string.Format("{0},{1}",size,colorsNum);

        }

        // Task5: PropertiesToEncapsulate
        
     
            public int Size
            {
                get
                {
                    return this.size;
                }
                set
                {
                    if (value<=0)
                    {
                        throw new ArgumentException("Enter size>0! ");
                    }
                    this.size = value;
                }
            }

            public int ColorsNum
            {
                get
                {
                    return this.colorsNum;
                }
                set
                {
                    if (value<=0)
                    {
                        throw new ArgumentException("Enter ColorNum>0!");
                    }
                    this.colorsNum = value;
                }
            }
    }
}
