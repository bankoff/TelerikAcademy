//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should 
//be filled with '*'. Print the result string into the console.

using System;
using System.Text;

class FillWithAsterisk
{
    static void Main()
    {
        string text;
        do
        {
            Console.WriteLine("Please enter string with no more than 20 characters!");
            text = Console.ReadLine();
        } while (text.Length > 20);

            StringBuilder twentyChars = new StringBuilder(20);
            twentyChars.Append(text);
            while (twentyChars.Length < 20)
            {
                twentyChars.Append('*');
            }
            Console.WriteLine("The changed text is: {0}", twentyChars.ToString());
    }
}