using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentSystem
{
    public interface IDocument
    {
        string Name { get; }
        string Content { get; }
        void LoadProperty(string key, string value);
        void SaveAllProperties(IList<KeyValuePair<string, object>> output);
        string ToString();
    }
    public interface IEncryptable
    {
        bool IsEncrypted { get; }
        void Encrypt();
        void Decrypt();
    }
    public interface IEditable
    {
        void ChangeContent(string newContent);
    }


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
            else
            {
                throw new ArgumentException("Key '" + key + "' not found");
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));
            output.Add(new KeyValuePair<string, object>("content", this.Content));
        }

        public override string ToString()
        {
            List<KeyValuePair<string, object>> properties = new List<KeyValuePair<string, object>>();
            properties.Sort((a, b) => a.Key.CompareTo(b.Key));
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name);
            result.Append("[");
            bool first = true;
            foreach (var prop in properties)
            {
                if (prop.Value != null)
                {
                    if (!first)
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
    public class TextDocument : Document, IEditable
    {
        public string Charset { get; set; }
        public override void LoadProperty(string key, string value)
        {
            if (key == "charset")
            {
                this.Charset = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("charset", this.Charset));
            base.SaveAllProperties(output);
        }

        void IEditable.ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }
    public abstract class BinaryDocument : Document
    {
        public long? Size { get; set; }
        public override void LoadProperty(string key, string value)
        {
            if (key == "size")
            {
                this.Size = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("size", this.Size));
            base.SaveAllProperties(output);
        }
    }
    public abstract class MultimediaDocument : BinaryDocument
    {
        public int? Length { get; set; }
        public override void LoadProperty(string key, string value)
        {
            if (key == "length")
            {
                this.Length = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("length", this.Length));
            base.SaveAllProperties(output);
        }
    }
    public class AudioDocument : MultimediaDocument
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
            output.Add(new KeyValuePair<string, object>("samplerate", this.SampleRateHz));
            base.SaveAllProperties(output);
        }
    }
    public class VideoDocument : MultimediaDocument
    {
        public int? FrameRate { get; set; }
        public override void LoadProperty(string key, string value)
        {
            if (key == "framerate")
            {
                this.FrameRate = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));
            base.SaveAllProperties(output);
        }
    }
    public abstract class EncryptableBinaryDocument : BinaryDocument, IEncryptable
    {
        private bool isEncrypted = false;
        public bool IsEncrypted
        {
            get { return this.isEncrypted; }
        }

        public void Encrypt()
        {
            this.isEncrypted = true;
        }

        public void Decrypt()
        {
            this.isEncrypted = false;
        }
        public override string ToString()
        {
            if (this.isEncrypted)
            {
                return string.Format("{0}[encrypted]", this.GetType().Name);
            }
            return base.ToString();
        }
    }
    public class ExcelDocument : OfficeDocument
    {
        public int? Rows { get; set; }
        public int? Cols { get; set; }
        public override void LoadProperty(string key, string value)
        {
            if (key == "rows")
            {
                this.Rows = int.Parse(value);
            }
            else if (key == "cols")
            {
                this.Cols = int.Parse(value);
            }
            base.LoadProperty(key, value);
        }
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("rows", this.Rows));
            output.Add(new KeyValuePair<string, object>("cols", this.Cols));
            base.SaveAllProperties(output);
        }
    }
    public abstract class OfficeDocument : EncryptableBinaryDocument
    {
        public string Version { get; set; }
        public override void LoadProperty(string key, string value)
        {
            if (key == "version")
            {
                this.Version = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("version", this.Version));
            base.SaveAllProperties(output);
        }
    }
    public class WordDocument : OfficeDocument, IEditable
    {
        public int? CharsCount { get; set; }
        public override void LoadProperty(string key, string value)
        {
            if (key == "chars")
            {
                this.CharsCount = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("chars", this.CharsCount));
            base.SaveAllProperties(output);
        }

        void IEditable.ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }
    public class PDFDocument : EncryptableBinaryDocument
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
            output.Add(new KeyValuePair<string, object>("pages", this.PagesCount));
            base.SaveAllProperties(output);
        }
    }
   
    public class DocumentSystem
    {
        private static IList<IDocument> documents = new List<IDocument>();
        static void Main()
        {
            IList<string> allCommands = ReadAllCommands();
            ExecuteCommands(allCommands);
        }

        private static IList<string> ReadAllCommands()
        {
            List<string> commands = new List<string>();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "")
                {
                    // End of commands
                    break;
                }
                commands.Add(commandLine);
            }
            return commands;
        }

        private static void ExecuteCommands(IList<string> commands)
        {
            foreach (var commandLine in commands)
            {
                int paramsStartIndex = commandLine.IndexOf("[");
                string cmd = commandLine.Substring(0, paramsStartIndex);
                int paramsEndIndex = commandLine.IndexOf("]");
                string parameters = commandLine.Substring(
                    paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
                ExecuteCommand(cmd, parameters);
            }
        }

        private static void ExecuteCommand(string cmd, string parameters)
        {
            string[] cmdAttributes = parameters.Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (cmd == "AddTextDocument")
            {
                AddTextDocument(cmdAttributes);
            }
            else if (cmd == "AddPDFDocument")
            {
                AddPdfDocument(cmdAttributes);
            }
            else if (cmd == "AddWordDocument")
            {
                AddWordDocument(cmdAttributes);
            }
            else if (cmd == "AddExcelDocument")
            {
                AddExcelDocument(cmdAttributes);
            }
            else if (cmd == "AddAudioDocument")
            {
                AddAudioDocument(cmdAttributes);
            }
            else if (cmd == "AddVideoDocument")
            {
                AddVideoDocument(cmdAttributes);
            }
            else if (cmd == "ListDocuments")
            {
                ListDocuments();
            }
            else if (cmd == "EncryptDocument")
            {
                EncryptDocument(parameters);
            }
            else if (cmd == "DecryptDocument")
            {
                DecryptDocument(parameters);
            }
            else if (cmd == "EncryptAllDocuments")
            {
                EncryptAllDocuments();
            }
            else if (cmd == "ChangeContent")
            {
                ChangeContent(cmdAttributes[0], cmdAttributes[1]);
            }
            else
            {
                throw new InvalidOperationException("Invalid command: " + cmd);
            }
        }

        private static void AddTextDocument(string[] attributes)
        {
            AddDocument(new TextDocument(), attributes);
        }

        private static void AddPdfDocument(string[] attributes)
        {
            AddDocument(new PDFDocument(), attributes);
        }

        private static void AddWordDocument(string[] attributes)
        {
            AddDocument(new WordDocument(), attributes);
        }

        private static void AddExcelDocument(string[] attributes)
        {
            AddDocument(new ExcelDocument(), attributes);
        }

        private static void AddAudioDocument(string[] attributes)
        {
            AddDocument(new AudioDocument(),attributes);
        }

        private static void AddVideoDocument(string[] attributes)
        {
            AddDocument(new VideoDocument(),attributes);
        }

        //private static void ListDocuments()
        //{
        //    // TODO
        //}

        //private static void EncryptDocument(string name)
        //{
        //    // TODO
        //}

        //private static void DecryptDocument(string name)
        //{
        //    // TODO
        //}

        //private static void EncryptAllDocuments()
        //{
        //    // TODO
        //}

        //private static void ChangeContent(string name, string content)
        //{
        //    // TODO
        //}

        private static void ListDocuments()
        {
            if (documents.Count > 0)
            {
                foreach (var doc in documents)
                {
                    Console.WriteLine(doc);
                }
            }
            else
            {
                Console.WriteLine("No documents found");
            }
        }
        private static void AddDocument(IDocument doc, string[] attributes)
        {
            foreach (var attrib in attributes)
            {
                string[] keyAndValue = attrib.Split('=');
                string key = keyAndValue[0];
                string value = keyAndValue[1];
                doc.LoadProperty(key, value);
                if (doc.Name != null)
                {
                    documents.Add(doc);
                    Console.WriteLine("DocumentAdded:" + doc.Name);

                }
                else
                {
                    Console.WriteLine("Document has no name");
                }
            }
        }
        private static void ChangeContent(string name, string content)
        {
            bool documentFound = false;
            foreach (var doc in documents)
            {
                if (doc.Name == name)
                {
                    if (doc is IEditable)
                    {
                        ((IEditable)doc).ChangeContent(content);
                        Console.WriteLine("Document content changed:" + doc.Name);
                    }
                    else
                    {
                        Console.WriteLine("Document is not editable:" + doc.Name);
                    }
                    documentFound = true;
                }
            }
            if (!documentFound)
            {
                Console.WriteLine("Document not found" + name);
            }
        }
        private static void EncryptDocument(string name)
        {
            bool documentFound = false;
            foreach (var doc in documents)
            {
                if (doc.Name == name)
                {
                    if (doc is IEncryptable)
                    {
                        ((IEncryptable)doc).Encrypt();
                        Console.WriteLine("Document encrypted:" + doc.Name);
                    }
                    else
                    {
                        Console.WriteLine("Document does not support encryption");
                    }
                    documentFound = true;
                }
            }
            if (documentFound == false)
            {
                Console.WriteLine("Document not found");
            }
        }
        private static void DecryptDocument(string name)
        {
            bool documentFound = false;
            foreach (var doc in documents)
            {
                if (doc.Name == name)
                {
                    if (doc is IEncryptable)
                    {
                        ((IEncryptable)doc).Decrypt();
                        Console.WriteLine("Document decrypted:" + doc.Name);
                    }
                    else
                    {
                        Console.WriteLine("document does not support encription:" + doc.Name);
                    }
                    documentFound = true;
                }
            }
            if (documentFound == false)
            {
                Console.WriteLine("Document not found" + name);
            }
        }
        private static void EncryptAllDocuments()
        {
            bool documentsFound = false;
            foreach (var doc in documents)
            {
                if (doc is IEncryptable)
                {
                    ((IEncryptable)doc).Encrypt();
                    documentsFound = true;
                }
            }
            if (documentsFound == false)
            {
                Console.WriteLine("No encryptable documents found");
            }
            else
            {
                Console.WriteLine("All documents encrypted");
            }
        }
    }
}
