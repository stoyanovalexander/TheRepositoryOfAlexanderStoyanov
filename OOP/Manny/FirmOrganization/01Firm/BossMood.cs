using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Firm
{
    public class BossMood
    {


        public uint Mood { get; set; }

        public BossMood(uint mood)
        {
            this.Mood = mood;
        }

        Random theMoodTester = new Random();

        public void ProcessInput()
        {
            if (this.Mood < 10)
            {
                this.Normal(this, new EventArgs());
            }
            else
            {
                if ((this.Mood) % theMoodTester.Next(1, 12) > 8)
                {
                    this.Advance(this, new EventArgs());
                }
                else
                {
                    this.SaturdayWork(this, new EventArgs());
                }
            }
        }
        public event EventHandler Advance;

        public event EventHandler SaturdayWork;

        public event EventHandler Normal;
    
    }
}
