//Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceOnlyWholeWords
{
    static void Main()
    {
        StreamReader start = new StreamReader(@"../../start.txt", Encoding.GetEncoding("windows-1251"));
        using (start)
        {
            StreamWriter finish = new StreamWriter(@"../../finish.txt", false, Encoding.GetEncoding("windows-1251"));
            using (finish)
            {
                string current;
                while ((current = start.ReadLine()) != null)
                {
                    finish.WriteLine(Regex.Replace(current, "\\bstart\\b", "finish"));
                }
            }
        }
        Console.WriteLine("Whole words only were replaced!");
        Console.WriteLine("You can find the files in directory of the current project!");
    }
}