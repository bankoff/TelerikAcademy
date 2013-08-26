//Write a program that removes from a text file all words listed in given another text file. 
//Handle all possible exceptions in your methods.

using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

class RemoveWordsFromFile
{
    static void Main()
    {
        try
        {
            string allLines = String.Join(" ", File.ReadAllLines(@"../../wordsToRemove.txt"));
            string[] allWords = allLines.Split(' ');
            StreamReader fileToRead = new StreamReader(@"../../fileToRead.txt", Encoding.GetEncoding("windows-1251"));
            using (fileToRead)
            {
                StreamWriter fileToWrite = new StreamWriter(@"../../fileToWrite.txt", false, Encoding.GetEncoding("windows-1251"));
                string line = fileToRead.ReadLine();
                using (fileToWrite)
                {
                    while (line != null)
                    {
                        for (int i = 0; i < allWords.Length; i++)
                        {
                            string word = "\\b" + allWords[i] + "\\b";
                            line = Regex.Replace(line, word, "");
                        }

                        fileToWrite.WriteLine(line);

                        line = fileToRead.ReadLine();
                    }
                }
            }
            Console.WriteLine("Whole words have been replaced!");
            Console.WriteLine("You can find the files in directory of the current project!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The file path contains a directory that cannot be found!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("No file path is given!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The entered file path is not correct!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The entered file path is too long - 248 characters are the maximum!");
        }
        catch (UnauthorizedAccessException uoae)
        {
            Console.WriteLine(uoae.Message);
        }
        catch (SecurityException)
        {
            Console.WriteLine("You don't have the required permission to access this file!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid file path format!");
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}