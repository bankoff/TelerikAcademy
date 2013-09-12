//Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatTwoTextFiles
{
    static void Main()
    {
        string textFile1 = @"..\..\TextFile1.txt";
        string textFile2 = @"..\..\TextFile2.txt";
        string concatFile = @"..\..\ConcatFile.txt";
        StreamReader reader;
        StreamWriter writer = new StreamWriter(concatFile);

        using (writer)
        {
            reader = new StreamReader(textFile1);
            using (reader)
            {
                writer.WriteLine(reader.ReadToEnd(), false);
            }

            reader = new StreamReader(textFile2);
            using (reader)
            {
                writer.WriteLine(reader.ReadToEnd(), true);
            }
        }
        Console.WriteLine("The files were concateneted successfully!\nYou can find the files in directory of the current project!");
    }
}