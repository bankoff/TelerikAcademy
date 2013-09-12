//Describe the strings in C#. What is typical for the string data type? Describe the most important methods of the String class.

using System;
using System.Net;
using System.Diagnostics;

class StringClassMethods
{
    static void Main()
    {
        using (WebClient webClient = new WebClient())
        {
            try
            {
                webClient.DownloadFile("http://msdn.microsoft.com/en-us/library/system.string_methods.aspx", "StringMethods.html");
                Console.WriteLine("The file was downloaded successfully!\nPlease wait!");
                Process.Start("StringMethods.html");
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