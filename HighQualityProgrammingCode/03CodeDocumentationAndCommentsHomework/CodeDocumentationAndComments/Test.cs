//-----------------------------------------------------------------------
// <copyright file="Test.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.ILS.Common;

/// <summary>
/// Test of string extension methods
/// </summary>
internal class Test
{
    /// <summary>
    /// Test of string extension methods
    /// </summary>
    public static void Main()
    {
        string hello = "Hello!";
        Console.WriteLine("{0}-->{1}", hello, hello.ToMd5Hash());

        string input = "1";
        Console.WriteLine("{0}-->{1}", input, input.ToBoolean());

        string shortStr = "11111";
        Console.WriteLine("{0}-->{1}", shortStr, shortStr.ToShort());

        string dateTimeStr = "2013/04/04";
        Console.WriteLine("{0}-->{1}", dateTimeStr, dateTimeStr.ToDateTime());

        string niceDay = "have a nice day!";
        Console.WriteLine("{0}-->{1}", niceDay, niceDay.CapitalizeFirstLetter());

        string yellowSub = "We are all living in a yellow submarine.";
        Console.WriteLine("{0}-->{1}", yellowSub, yellowSub.GetStringBetween("are", "submarine"));

        string cyrillicLettersStr = "Здравей, как си приятелю, как, добре ли я караш?";
        Console.WriteLine("{0}-->\n{1}", cyrillicLettersStr, cyrillicLettersStr.ConvertCyrillicToLatinLetters());
    }
}