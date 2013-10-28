//03.Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by 
//entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

class TestExeption
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        Console.WriteLine("Please enter 3 integers in the range of [1,100]. If the number is\n out of this range, an exception will be thrown!");
        for (int i = 0; i <= 2; i++)
        {
            TestIntegers(start, end);
        }

        DateTime startDate = new DateTime(1980, 01, 01);
        DateTime endDate = new DateTime(2013, 12, 31);
        Console.WriteLine("Please enter 3 dates in the range of [{0} to {1}]. \nIf the dates are out of this range, an exception will be thrown!",
            startDate.ToString("dd.MM.yyyy"), endDate.ToString("dd.MM.yyyy"));
        for (int i = 0; i <= 2; i++)
        {
            TestDate(startDate, endDate);
        }
    }

    private static void TestDate(DateTime startDate, DateTime endDate)
    {
        string inputDate;
        inputDate = Console.ReadLine();
        DateTime testDate = DateTime.ParseExact(inputDate, "d.M.yyyy", CultureInfo.InvariantCulture);


        if (testDate < startDate || testDate > endDate)
        {
            string message = String.Format("Invalid range!");
            throw new InvalidRangeException<DateTime>(message, startDate, endDate);
        }
        else
        {
            Console.WriteLine("The date {0} is valid date in the range [{1}..{2}]", testDate.ToString("dd.MM.yyyy"),
                startDate.ToString("dd.MM.yyyy"), endDate.ToString("dd.MM.yyyy"));
        }
    }

    private static void TestIntegers(int start, int end)
    {
        string testIntStr = Console.ReadLine();
        int testInt;

        try
        {
            testInt = int.Parse(testIntStr);
        }
        catch (FormatException fe)
        {
            throw new FormatException("The data is not integer!" + fe);
        }
        if (testInt < start || testInt > end)
        {
            string message = String.Format("Invalid range!");
            throw new InvalidRangeException<int>(message, start, end);
        }
        else
        {
            Console.WriteLine("Valid data.");
            Console.WriteLine();
        }
    }
}