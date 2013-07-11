using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public abstract class Document : IDocument
    {
        string IDocument.Name
        {
            get { throw new NotImplementedException(); }
        }

        string IDocument.Content
        {
            get { throw new NotImplementedException(); }
        }

        void IDocument.LoadProperty(string key, string value)
        {
            throw new NotImplementedException();
        }

        void IDocument.SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            List<KeyValuePair<string, object>> properties = new List<KeyValuePair<string, object>>();
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name);
            result.Append("[");
            bool first = true;
            foreach (var prop in properties)
            {
                if (prop.Value != null)
                {
                    if (first == false)
                    {
                        result.Append(";");
                    }
                    result.AppendFormat("{0}={1}", prop.Key, prop.Value);
                    first = false;
                }
            }
            result.Append("]");
            return result.ToString();
        }
    }
}
