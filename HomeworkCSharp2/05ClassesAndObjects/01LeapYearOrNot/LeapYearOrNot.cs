//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class LeapYearOrNot
{
    static void Main()
    {
        int yearForCheck;
        do
        {
            Console.Write("Please enter year:");
        } while (!(int.TryParse(Console.ReadLine(), out yearForCheck) && 1 <= yearForCheck && yearForCheck <= 9999));

        if (DateTime.IsLeapYear(yearForCheck))
        {
            Console.WriteLine("The year {0} is leap", yearForCheck);
        }
        else
        {
            Console.WriteLine("The year {0} is not leap.", yearForCheck);
        }
    }
}