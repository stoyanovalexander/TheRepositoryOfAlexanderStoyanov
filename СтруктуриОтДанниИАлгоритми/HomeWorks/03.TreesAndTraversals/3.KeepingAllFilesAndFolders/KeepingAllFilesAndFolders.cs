using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class KeepingAllFilesAndFolders
    {
        static void Main()
        {
            Console.WriteLine("Wait a minute:");
            DirectoryTree dirTree = new DirectoryTree("C:\\Windows");

            Console.WriteLine("Done.");

            Console.WriteLine("\nTree size: ");
            double sizeInMB = dirTree.CalculateSizeOfTree();
            Console.WriteLine("{0} megabytes", sizeInMB);
            Console.WriteLine("{0} or gigabytes", sizeInMB / 1024);

            
            Console.WriteLine();
            Console.WriteLine("Calculate size of tree folder and subfolders: ");
            sizeInMB = dirTree.CalculateSizeOfFolder("AppCompat");
            Console.WriteLine("{0} megabytes", sizeInMB);
            Console.WriteLine("{0} or gigabytes", sizeInMB / 1024);

        }
    }
