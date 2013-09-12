//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class PrintOddLines
{
    static void Main()
    {
        string textFile = @"..\..\TextFile.txt";
        Console.WriteLine("Odd lines of the file {0} is: \n", textFile);
        StreamReader reader = new StreamReader(textFile);

        using (reader)
        {
            int lineNumber = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                line = reader.ReadLine();
                line = reader.ReadLine();
                lineNumber+=2;
            }
        }
    }
}