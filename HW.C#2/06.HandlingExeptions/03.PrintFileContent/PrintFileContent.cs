using System;
using System.IO;
using System.Security;
class PrintFileContent
{
    static void ReadingFile(string filePath)
    {
        try
        {
            string theContentOfTheFile = File.ReadAllText(filePath);
            Console.WriteLine("The content of the file is: ");
            Console.WriteLine(theContentOfTheFile);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Same directory can not be found");
        }
        catch (FileLoadException)
        {
            Console.WriteLine("The file can not be found");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("There are no file path"); 
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The entered file path is too long - 248 characters are the maximum!");
        }
        catch (UnauthorizedAccessException uoae)
        {
            Console.WriteLine(uoae.Message);
        }
        catch (SecurityException)
        {
            Console.WriteLine("You don't have the required permission to access this file!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid file path format!");
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Enter the full path to the file that must be printed: "); // C:\Telerik\HW.C#2\FileWithText.txt 
        string filePath = Console.ReadLine();
        ReadingFile(filePath);
    }
}

