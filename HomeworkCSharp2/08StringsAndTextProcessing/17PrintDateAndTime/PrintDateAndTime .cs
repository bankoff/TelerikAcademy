//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints 
//the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;

class PrintDateAndTime
{
    static void Main()
    {
        string dateStr = "14.09.2013 10:11:12";

        //Console.WriteLine("Please enter date in format d.M.yyyy");
        //string date = Console.ReadLine();
        //Console.WriteLine("Please enter time in format H:m:S");
        //string time = Console.ReadLine();
        //string dateStr = date + " " + time;

        DateTime dateTime = DateTime.ParseExact(dateStr, "d.M.yyyy H:m:s", CultureInfo.InvariantCulture);
        DateTime later = dateTime.AddHours(6.5);
        Console.Write("{0:dd.MM.yyyy HH:mm:ss} {1}", later, later.ToString("dddd", new CultureInfo("bg-BG")));
        Console.WriteLine();
    }
}