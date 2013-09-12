//Write a program that reads a string from the console and prints all different letters in the string 
//along with information how many times each letter is found. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class PrintCountLetters
{
    static void Main()
    {
        string text = "It’s your 10 digit Fido number 4%^&!@fido.ca ( for example 5145551234@fido.ca ).";
        string[] words = Regex.Split(text, @"[\W+0-9_~!@#$%^&*()_+,=-`/?.,<>\|'"";:]");
        Dictionary<char, int> countchars = new Dictionary<char, int>();
        for (int i = 0; i < words.Length; i++)
        {
            foreach (var character in words[i])
            {
                if (countchars.ContainsKey(character))
                {
                    countchars[character]++;
                }
                else
                {
                    countchars.Add(character, 1);
                }
            }
        }
        var sortedLetters = countchars.OrderBy(x => x.Key);
        foreach (var letter in sortedLetters)
        {
            Console.WriteLine("Letter --> {0} - Number --> {1}", letter.Key, letter.Value);
        }
    }
}