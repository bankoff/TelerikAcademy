//Write a program that compares two text files line by line and prints the number of lines that are 
//the same and the number of lines that are different. Assume the files have equal number of lines.

using System;
using System.Text;
using System.IO;

class CompareTwoTextFiles
{
    static void Main()
    {
        StreamReader textFile1 = new StreamReader(@"..\..\TextFile1.txt", Encoding.GetEncoding("windows-1251"));
        StreamReader textFile2 = new StreamReader(@"..\..\TextFile2.txt", Encoding.GetEncoding("windows-1251"));
        int countOfSameLines = 0;
        int countOfDifferentLines = 0;
        using (textFile1)
        {
            using (textFile2)
            {
                string currentLineFile1;
                string currentLineFile2;
                while ((currentLineFile1 = textFile1.ReadLine()) != null && (currentLineFile2 = textFile2.ReadLine()) != null)
                {
                    if (currentLineFile1 == currentLineFile2)
                    {
                        countOfSameLines++;
                    }
                    else
                    {
                        countOfDifferentLines++;
                    }
                }
            }
        }
        Console.WriteLine("Same lines number:{0}", countOfSameLines);
        Console.WriteLine("Different lines number:{0}", countOfDifferentLines);
        Console.WriteLine("You can find the files in directory of the current project!");
    }
}

