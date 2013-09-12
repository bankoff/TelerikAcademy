//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        string inputTextFile = @"..\..\TextFile1.txt";
        string outputTextFile = @"..\..\TextFile2.txt";
        StreamReader reader = new StreamReader(inputTextFile);
        StreamWriter writer = new StreamWriter(outputTextFile);

        using (reader)
        {
            using (writer)
            {
            int lineNumber = 0;
            string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;
                    writer.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("Input file is TextFile1.txt!");
        Console.WriteLine("Output file with inserting line numbers is TextFile2.txt!");
        Console.WriteLine("You can find the files in directory of the current project!");
    }
}