using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    class Battery
    {
        private BatteryType type; //Task3: EnumerationBateryType

        // Task1  the fields
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        // Task3: EnumerationBateryType
        public BatteryType  Type   
        {                             
            get { return this.type; }   
            set { this.type = value; } 
        }  
        
        // Task2: DefineConstructors
        public Battery(string model, int hoursIdle, int hoursTalk,BatteryType type)  // CONSTRUCTOR
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        public Battery(string model, int hoursIdle): this(model, hoursIdle, 0,0) // CONSTRUCTOR
        {
        }
        public Battery(string model): this(model,0, 0,0)  //CONSTRUCTOR
        {
        }

        // Task4: MethodForDisplaying
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", model, hoursIdle, hoursTalk, type);
        }

        // Task5: PropertiesToEncapsulate
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Enter some Model! ");
                }
                this.model = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Enter some hoursIdle>0! ");
                }
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Enter some hoursTalk>0! ");
                }
                this.hoursTalk = value;
            }
        }

    }
}
