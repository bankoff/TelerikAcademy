//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//and stores it the current directory. Find in Google how to download files in C#. Be sure to catch 
//all exceptions and to free any used resources in the finally block.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Diagnostics;


class DownloadFileFromInternet
{
    static void Main()
    {
        using (WebClient webClient = new WebClient())
        {
            try
            { //the file is downloaded in the directory of the exe file of this program
                webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "logo.jpg");
                Console.WriteLine("The file was downloaded successfully \nin the directory with the exe file of this program!");
                Process.Start("logo.jpg");
            }

            catch (WebException)
            {
                Console.Error.WriteLine("The address is invalid or error occured during download.");
            }

            catch (NotSupportedException)
            {
                Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
            }
        }
    }
}