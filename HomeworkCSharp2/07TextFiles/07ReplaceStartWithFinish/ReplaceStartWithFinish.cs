//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.Text;
using System.IO;


class ReplaceStartWithFinish
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
                    finish.WriteLine(current.Replace("start", "finish"));
                }
            }
        }
        Console.WriteLine("Substrings were replaced successfully!");
        Console.WriteLine("You can find the files in directory of the current project!");
    }
}