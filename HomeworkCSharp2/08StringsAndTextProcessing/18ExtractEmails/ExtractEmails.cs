//Write a program for extracting all email addresses from given text. 
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string text = @"Did you know that your Fido has a mobile email address? 
                        It’s your 10 digit Fido number @fido.ca ( for example 5145551234@fido.ca ). 
                        my emails are ninja@abv.bg and 6ef.joro@yahoo.co.uk. 
                        This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
        string[] splitted = text.Split(' ');

        for (int i = 0; i < splitted.Length; i++)
        {
            if (Regex.IsMatch(splitted[i], @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}"))
            {
                Console.WriteLine("{0} is a valid email", splitted[i]);
            }
        }
    }
}