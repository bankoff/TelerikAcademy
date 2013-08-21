//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified 
//preliminary as array.

using System;

class CalculateWorkdays
{
    static int currentYear = DateTime.Now.Year;
    static DateTime[] holidays = 
        {
           new DateTime(currentYear, 1, 1),
           new DateTime(currentYear, 3, 3),
           new DateTime(currentYear, 5, 1),
           new DateTime(currentYear, 5, 3),
           new DateTime(currentYear, 5, 6),
           new DateTime(currentYear, 5, 24),
           new DateTime(currentYear, 9, 6),
           new DateTime(currentYear, 9, 22),
           new DateTime(currentYear, 12, 24),
           new DateTime(currentYear, 12, 25),
           new DateTime(currentYear, 12, 26),
           new DateTime(currentYear, 12, 31),
        };
    static void Main()
    {
        DateTime startDate = DateTime.Today;
        DateTime endDate = new DateTime(currentYear, 12, 12);
        //DateTime endDate = new DateTime(currentYear, 9, 16);
        CalculateWorkDays(startDate, endDate);
    }

    static void CalculateWorkDays(DateTime startDate, DateTime endDate)
    {

        int numberOfAllDays = (endDate - startDate).Days;
        bool isHoliday = false;
        int numberOfWorkingDays = 0;

        for (int i = 0; i < numberOfAllDays; i++)
        {
            startDate = startDate.AddDays(1);
            if (startDate.DayOfWeek != DayOfWeek.Sunday && startDate.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (startDate == holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }
                if (!isHoliday)
                {
                    numberOfWorkingDays++;
                }
                isHoliday = false;
            }
        }
        Console.WriteLine("Number of working days:{0}", numberOfWorkingDays);
    }
}