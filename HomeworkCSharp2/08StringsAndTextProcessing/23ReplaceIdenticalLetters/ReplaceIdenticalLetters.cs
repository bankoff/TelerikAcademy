//Write a program that reads a string from the console and replaces all series of consecutive 
//identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".

using System;
using System.Text;

class ReplaceIdenticalLetters
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";

        //Console.WriteLine("Please enter text!");
        //string text = Console.ReadLine();

        StringBuilder output = new StringBuilder();

        output.Append(text[0]);

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i - 1])
            {
                output.Append(text[i]);
            }
        }
        Console.WriteLine(output);
    }
}