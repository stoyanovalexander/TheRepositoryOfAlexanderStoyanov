using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmCalls
{
    class GSM
    {
        // Task9: AddCallHistory
        private List<Call> callHistory;
        public List<Call> CallHistory
        {
            get { return this.callHistory; }

        }

        // Task10: Methods in GSM for add and del calls in callhistory
        private int index;
        public int Index
        {
            get { return this.index; }
            set { this.index = value; }
        }

        public void AddCall(List<Call> masiv)
        {
            callHistory.Add(new Call("22-33-44", 444));
        }

        public void DelCall(List<Call> masiv, int index)
        {
            callHistory.RemoveAt(4);
        }

        public void Clear(List<Call> masiv)
        {
            callHistory.Clear();
        }



        // Task11: calculate the sum of all calls
        private int theSum;
        private int thePrice;
        public int ThePrice
        {
            get { return this.thePrice; }
            set { this.thePrice = value; }
        }
        public int TheSum
        {
            get { return this.theSum; }
            set { this.theSum = value; }
        }
        public int MakeSum()
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                theSum = theSum + (callHistory[i].Duration / 60) * this.thePrice;
            }
            return theSum;
        }
    }
}
