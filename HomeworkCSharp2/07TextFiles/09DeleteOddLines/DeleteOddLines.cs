//Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        PrintResult(ReadEvenLines());
        Console.WriteLine("Odd lines only were removed!");
        Console.WriteLine("You can find the file in directory of the current project!");
    }

    static void PrintResult(List<string> evenRows)
    {
        StreamWriter write = new StreamWriter(@"../../TextFile.txt", false, Encoding.GetEncoding("windows-1251"));
        using (write)
        {
            foreach (var row in evenRows)
            {
                write.WriteLine(row);
            }
        }
    }

    static List<String> ReadEvenLines()
    {
        StreamReader read = new StreamReader(@"../../TextFile.txt", Encoding.GetEncoding("windows-1251"));
        using (read)
        {
            int lineNumber = 1;
            string current;
            List<string> evenRows = new List<string>();
            while ((current = read.ReadLine()) != null)
            {
                if (lineNumber % 2 == 0)
                {
                    evenRows.Add(current);
                }
                lineNumber++;
            }
            return evenRows;
        }
    }
}