//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days


using System;
using System.Globalization;

class CalculateDays
{
    static void Main()
    {
        string start = "27.02.2006";
        string end = "03.03.2006";

        //Console.WriteLine("Please enter first date in format d.M.yyyy");
        //string start = Console.ReadLine();
        //Console.WriteLine("Please enter second date in format d.M.yyyy");
        //string end = Console.ReadLine();

        DateTime startDate = DateTime.ParseExact(start, "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(end, "d.M.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Distance:{0} days", (endDate - startDate).TotalDays);
    }
}