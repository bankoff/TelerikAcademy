//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class PrintWordsAlphabetically
{
    static void Main()
    {
        string input = "when the last key character is reached";
        string[] words = input.Split(' ');
        Array.Sort(words);
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}