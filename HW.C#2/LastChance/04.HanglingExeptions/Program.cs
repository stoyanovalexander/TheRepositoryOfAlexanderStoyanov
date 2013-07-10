using System;
using System.Net;
using System.Diagnostics;
using System.Threading;
    class Program
    {
        static string fullpath = null;
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter URL Path to download image : ");
                    string path = Console.ReadLine();
                    Console.Write("Enter Filename : ");
                    string filename = Console.ReadLine();
                    WebClient wc = new WebClient();
                    string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    fullpath = desktop + filename;
                    wc.DownloadFileAsync(new Uri(path), filename);
                    wc.DownloadFileCompleted += wc_DownloadFileCompleted;
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        Process.Start(fullpath);
                    }
                    Console.WriteLine("Bye");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was something not allwright with {0}", ex);
                }
            }
        }
        static void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //every time new bytes are received this method is triggered
            double percentage = e.ProgressPercentage;
            Console.Write("{0} bytes / {1} bytes : ", e.BytesReceived, e.TotalBytesToReceive);
            Console.WriteLine("{0} %", percentage);
            Thread.Sleep(50);
        }
        static void wc_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            //triggered when the download is complete
            Console.WriteLine("Your file has been downloaded to your desktop, do you want to open it now? (y/n) : ");
        }
    }
}

