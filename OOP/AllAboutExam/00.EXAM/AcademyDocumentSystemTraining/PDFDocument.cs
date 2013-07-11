using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public class PDFDocument:EncryptableBinaryDocument
    {
        public int? PagesCount { get; set; }
        public override void LoadProperty(string key, string value)
        {
            if (key == "pages")
            {
                this.PagesCount = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string,object>("pages",this.PagesCount));
            base.SaveAllProperties(output);
        }
    }
}
 