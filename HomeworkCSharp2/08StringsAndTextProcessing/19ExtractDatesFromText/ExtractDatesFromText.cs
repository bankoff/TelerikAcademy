//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.

using System;
using System.Text.RegularExpressions;
using System.Globalization;

class ExtractDatesFromText
{
    static void Main()
    {
        string dates = @"03.3.1878 Russia and the Ottomans (Turkish Empire) signed the treaty of San Stefano 
and lost its possession of Bulgaria and Romania Russians gained influence over the Ottoman Empire and an autonomous 
Bulgarian state was created. 17.11.1885 The Serbian Army, with Russian support, invade Bulgaria but re repulsed by 
the Bugarians led by Stefan Stambolov. 26.11.1885 Bulgaria moves into Serbia. 3.03.1886 The Treaty of Bucharest 
concludes the Serb - Bulgarian war. 1886 The Cathedral of the Assumption was built in Varna. 30.01.1894 - Boris III 
czar of Bulgaria (1918-43) was born (1894 - 1943)";
        //03.3.1878 3.03.1886 are not valid dates
        //17.11.1885 26.11.1885 30.01.1894 are valid dates

        string[] splitted = dates.Split(' ');
        DateTime date;
        for (int i = 0; i < splitted.Length; i++)
        {
            if (Regex.IsMatch(splitted[i], @"\b[0-9]{2}.[0-9]{2}.[0-9]{4}\b"))
            {
                if (DateTime.TryParseExact(splitted[i], "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Console.Write("Valid date:");
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                }
            }
        }
    }
}

