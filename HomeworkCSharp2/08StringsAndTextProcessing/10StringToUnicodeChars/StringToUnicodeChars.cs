//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:
//Hi!

//Expected output:
//\u0048\u0069\u0021

using System;

class StringToUnicodeChars
{
    static void Main()
    {
        string text = "Hi!";
        Console.WriteLine(text);

        //Console.WriteLine("Please enter some text!");
        //string text = Console.ReadLine();

        foreach (char symbol in text)
        {
            Console.Write("\\u{0:x4}", (int)symbol);
        }
        Console.WriteLine();
    }
}