using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Document : IDocument
{
    public string Name { get; protected set; }
    public string Content { get; protected set; }
    
    public virtual void LoadProperty(string key, string value)
    {
        if (key == "name")
        {
            this.Name = value;
        }
        else if (key == "content")
        {
            this.Content = value;
        }
    }

    public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("name", this.Name));
        output.Add(new KeyValuePair<string, object>("content", this.Content));
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append(this.GetType().Name);
        result.Append("[");

        IEncryptable encryptable = this as IEncryptable;
        if (encryptable != null && encryptable.IsEncrypted == true)
        {
            result.Append("encrypted");
        }
        else
        {
            IList<KeyValuePair<string, object>> attributes = new List<KeyValuePair<string, object>>();
            SaveAllProperties(attributes);
            var sortedAttributes = attributes.OrderBy(x => x.Key);

            foreach (var prop in sortedAttributes)
            {
                if (prop.Value != null)
                {
                    result.Append(string.Format("{0}={1};", prop.Key, prop.Value));
                }
            }
            result.Length--;
        }

        result.Append("]");

        return result.ToString();
    }
}