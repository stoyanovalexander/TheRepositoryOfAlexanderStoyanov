using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDefClasses2
{
    struct BitArray32
    {
        public const int bitsCount=32;
        private uint bitvalues;

        public int this[int index]
        {
            get
            {
                if ((index >= 0) && (index < bitsCount))
                {
                    if ((bitvalues & (1 << index)) == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException(string.Format("Index {0} is invalid!",index));
                }
            }
            set
            {
                if ((index < 0) || (index > bitsCount - 1))
                {
                    throw new IndexOutOfRangeException(string.Format("Index {0} is invalid!",index));
                }
                if ((value < 0) || (value > 1))
                {
                    throw new ArgumentOutOfRangeException(string.Format("value {0} is invalid!",value));
                }

                bitvalues &= ~((uint)(1 << index));

                bitvalues|=( (uint)(value<<index) );
            }
        }
    }
}
