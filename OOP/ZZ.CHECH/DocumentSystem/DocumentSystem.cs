using System;
using System.Collections.Generic;

public class DocumentSystem
{
    private static IList<IDocument> allDocuments = new List<IDocument>();

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
        TextDocument doc = new TextDocument();
        foreach (string properties in attributes)
        {
            string[] prop = properties.Split('=');
            doc.LoadProperty(prop[0], prop[1]);
        }
        if (doc.Name != null)
        {
            allDocuments.Add(doc);
            Console.WriteLine("Document added: {0}", doc.Name);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }
    }

    private static void AddPdfDocument(string[] attributes)
    {
        PDFDocument doc = new PDFDocument();
        foreach (string properties in attributes)
        {
            string[] prop = properties.Split('=');
            doc.LoadProperty(prop[0], prop[1]);
        }
        if (doc.Name != null)
        {
            allDocuments.Add(doc);
            Console.WriteLine("Document added: {0}", doc.Name);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }
    }

    private static void AddWordDocument(string[] attributes)
    {
        WordDocument doc = new WordDocument();
        foreach (string properties in attributes)
        {
            string[] prop = properties.Split('=');
            doc.LoadProperty(prop[0], prop[1]);
        }
        if (doc.Name != null)
        {
            allDocuments.Add(doc);
            Console.WriteLine("Document added: {0}", doc.Name);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }
    }

    private static void AddExcelDocument(string[] attributes)
    {
        ExcelDocument doc = new ExcelDocument();
        foreach (string properties in attributes)
        {
            string[] prop = properties.Split('=');
            doc.LoadProperty(prop[0], prop[1]);
        }
        if (doc.Name != null)
        {
            allDocuments.Add(doc);
            Console.WriteLine("Document added: {0}", doc.Name);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }
    }

    private static void AddAudioDocument(string[] attributes)
    {
        AudioDocument doc = new AudioDocument();
        foreach (string properties in attributes)
        {
            string[] prop = properties.Split('=');
            doc.LoadProperty(prop[0], prop[1]);
        }
        if (doc.Name != null)
        {
            allDocuments.Add(doc);
            Console.WriteLine("Document added: {0}", doc.Name);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }
    }

    private static void AddVideoDocument(string[] attributes)
    {
        VideoDocument doc = new VideoDocument();
        foreach (string properties in attributes)
        {
            string[] prop = properties.Split('=');
            doc.LoadProperty(prop[0], prop[1]);
        }
        if (doc.Name != null)
        {
            allDocuments.Add(doc);
            Console.WriteLine("Document added: {0}", doc.Name);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }
    }

    private static void ListDocuments()
    {
        if (allDocuments.Count == 0)
        {
            Console.WriteLine("No documents found");
        }
        else
        {
            foreach (IDocument doc in allDocuments)
            {
                Console.WriteLine(doc.ToString());
            }
        }
    }

    private static void EncryptDocument(string name)
    {
        bool isFound = false;
        foreach (var doc in allDocuments)
        {
            if (doc.Name == name)
            {
                isFound = true;
                IEncryptable encryptable = doc as IEncryptable;
                if (encryptable == null)
                {
                    Console.WriteLine("Document does not support encryption: {0}", doc.Name);
                }
                else
                {
                    encryptable.Encrypt();
                    Console.WriteLine("Document encrypted: {0}", doc.Name);
                }
            }
        }
        if (!isFound)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }

    private static void DecryptDocument(string name)
    {
        bool isFound = false;
        foreach (var doc in allDocuments)
        {
            if (doc.Name == name)
            {
                isFound = true;
                IEncryptable decryptable = doc as IEncryptable;
                if (decryptable == null)
                {
                    Console.WriteLine("Document does not support decryption: {0}", doc.Name);
                }
                else
                {
                    decryptable.Decrypt();
                    Console.WriteLine("Document decrypted: {0}", doc.Name);
                }
            }
        }
        if (!isFound)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }

    private static void EncryptAllDocuments()
    {
        bool isFound = false;
        foreach (var doc in allDocuments)
        {
            IEncryptable encryptable = doc as IEncryptable;
            if (encryptable != null)
            {
                encryptable.Encrypt();
                isFound = true;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No encryptable documents found");
        }
        else
        {
            Console.WriteLine("All documents encrypted");
        }
    }

    private static void ChangeContent(string name, string newContent)
    {
        bool isFound = false;
        foreach (var doc in allDocuments)
        {
            if (doc.Name == name)
            {
                isFound = true;
                IEditable editable = doc as IEditable;
                if (editable == null)
                {
                    Console.WriteLine("Document is not editable: {0}", doc.Name);
                }
                else
                {
                    editable.ChangeContent(newContent);
                    Console.WriteLine("Document content changed: {0}", doc.Name);
                }
            }
        }
        if (!isFound)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }
}
