using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class EncryptableDocument : BinaryDocument, IEncryptable
{
    public bool IsEncrypted { get; protected set; }

    public void Encrypt()
    {
        this.IsEncrypted = true;
    }

    public void Decrypt()
    {
        this.IsEncrypted = false;
    }
    public override void LoadProperty(string key, string value)
    {
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
    }
}
