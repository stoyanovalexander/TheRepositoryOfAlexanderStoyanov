using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public class AudioDocument:MultimediaDocument
    {
        public int? SampleRateHz { get; set; }
        public override void LoadProperty(string key, string value)
        {
            if (key == "samplerate")
            {
                this.SampleRateHz = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string,object>("samplerate",this.SampleRateHz));
            base.SaveAllProperties(output);
        }
    }
}
