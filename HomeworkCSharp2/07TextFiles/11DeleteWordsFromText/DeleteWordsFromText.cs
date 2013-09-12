//Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWordsFromText
{
    static void Main()
    {
        StreamReader input = new StreamReader(@"../../input.txt", Encoding.GetEncoding("windows-1251"));
        using (input)
        {
            StreamWriter output = new StreamWriter(@"../../output.txt", false, Encoding.GetEncoding("windows-1251"));
            using (output)
            {
                string current;
                while ((current = input.ReadLine()) != null)
                {
                    output.WriteLine(Regex.Replace(current, @"(\b)test((\w|_)*)(\b)", String.Empty));
                }
            }
        }
        Console.WriteLine("Words with prefix test have been deleted!");
        Console.WriteLine("You can find the files in directory of the current project!");
    }
}