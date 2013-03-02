using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    // Task8: ClassCallFields
    class Call
    {
        private DateTime dateAndTime;
        private string telNum;
        private int duration;
    
        public DateTime DateAndTime
        {
            get { return this.dateAndTime; }
            set { this.dateAndTime = value; }
        }
        public string TelNum
        {
            get { return this.telNum; }
            set { this.telNum = value; }
        }
        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }


        public Call(string telNum, int duration) // CONSTRUCTOR
        {
         
            this.telNum = telNum;
            this.duration = duration;
        }

           public override string ToString()
        {
            return string.Format("{0},{1},{2}",dateAndTime,telNum,duration );

        }

    }
}
