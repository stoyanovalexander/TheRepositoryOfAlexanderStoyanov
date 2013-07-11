using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    class GSM
    {
        // Task1 the fields
        private string model;
        private string manufactorer;
        private int price;
        private string owner;
        private Battery batteryCharacteristics;
        private Display displayCharacteristics;
       
        // Task.2: defne several constructors
        public GSM(string model, string manufactorer, int price, string owner
            ,Battery batteryCharacteristics,Display displayCharacteristics,List<Call> callHistory)
        {
            this.model = model;
            this.manufactorer = manufactorer;
            this.price = price;
            this.owner = owner;
            this.batteryCharacteristics = batteryCharacteristics;
            this.displayCharacteristics = displayCharacteristics;
            this.callHistory = callHistory;
        }
        public GSM(string model, string manufactorer, string owner
            , Battery batteryCharacteristics, Display displayCharacteristic)
            : this(model, manufactorer, 0, owner, batteryCharacteristics, displayCharacteristic,null)
        {}

        public GSM():this(null,null,0,"Pesho",null,null,null)
        {}

        // Task4: MethodForDisplaying
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6}",model,manufactorer,price,owner
                ,batteryCharacteristics,displayCharacteristics,   callHistory   );
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
                    throw new ArgumentException("Enter some Model");
                }

                this.model = value;
            }
        }

        public string Manufactorer
        {
            get
            {
                return this.manufactorer;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Enter some Manufactorer! ");
                }
                this.manufactorer = value;
            }
        }
        public int Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Enter price>0! ");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Enter some Owner! ");
                }
                this.owner = value;
            }
        }


        // Task6: StaticFieldIPhne4S
        private static GSM iphone4S = new GSM("IPhone4S","SomeOne",333,"Hasan",null,null,null);
        public static GSM Iphone4S
        {
            get { return iphone4S; }
           
        }
        

        private List<Call> callHistory;
        // Task9: CallHistoryProperty
        private List<Call> CallHistory
        {
            get { return this.callHistory; }

        }

        public GSM(List<Call> callHistory):this(null,null,0,null,null,null,callHistory)
        { }
       
            // Task10: MethodsAddDelClear
        public List<Call> AddCall(Call call)
        {
            callHistory.Add(call);
            return CallHistory;
        }

        public List<Call> DelCall(int index)
        {
            callHistory.RemoveAt(index);
            return CallHistory;
        }
   
        public List<Call> Clear()
        {
            callHistory.Clear();
            return CallHistory;
        }

        // Task11: CalculateCallsPrise
        public double MakeSum(double thePrice)
        {
            double theSum = 0;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                theSum = theSum + ((int)(callHistory[i].Duration / 60) * thePrice);
            }
            return theSum;
        }
        
    }
}
