using System;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        DateTime input = new DateTime(year, month, day);
        DateTime output = input.AddDays(1);
        Console.WriteLine(output.Day + "." + output.Month + "." +output.Year);
    }
}