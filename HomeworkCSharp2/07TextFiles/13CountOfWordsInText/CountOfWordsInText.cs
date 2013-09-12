//Write a program that reads a list of words from a file words.txt and finds how many times each of 
//the words is contained in another file test.txt. The result should be written in the file result.txt 
//and the words should be sorted by the number of their occurrences in descending order. Handle all 
//possible exceptions in your methods.

using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

class CountOfWordsInText
{
    static void Main()
    {
        try
        {
            string words = String.Join(" ",File.ReadAllLines(@"../../words.txt"));
            string[] stringSeparators = new string[] { " " };
            string[] allWords = words.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            int[] values = new int[allWords.Length];
            StreamReader test = new StreamReader(@"../../test.txt", Encoding.GetEncoding("windows-1251"));
            using (test)
            {
                string line = test.ReadLine();
                while (line != null)
                {
                    for (int i = 0; i < allWords.Length; i++)
                    {
                        values[i] += Regex.Matches(line, @"\b" + allWords[i] + @"\b").Count;
                    }
                    line = test.ReadLine();
                }
            }
            Array.Sort(values, allWords);

            StreamWriter result = new StreamWriter(@"../../result.txt", false, Encoding.GetEncoding("windows-1251"));
            using (result)
            {
                for (int i = allWords.Length - 1; i >= 0; i--)
                {
                    result.WriteLine("{0} - {1} times", allWords[i], values[i]);
                }
            }

            Console.WriteLine("The count of words have been calculated!");
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