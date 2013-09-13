using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ConsoleJustification
{
    static string Row(List<string> words, int start, int final, int count, int symbolsPerLine)
    {
        StringBuilder result = new StringBuilder();
        if (start == final)
        {
            result.Append(words[start]);
        }
        else
        {
            int spaces = (symbolsPerLine - count) / (final - start);
            int spacesPlus = (symbolsPerLine - count) % (final - start);

            for (int i = start; i <= final; i++)
            {
                result.Append(words[i]);

                if (i<final)
                {
                    for (int j = 0; j < spaces + 1; j++)
                    {
                        result.Append(' ');
                    }
                    if (spacesPlus > 0)
                    {
                        result.Append(' ');
                    }
                    spacesPlus--; 
                }       
            }
        }
        return result.ToString();
    }

    static List<string> SplitText(string input)
    {
        char[] separator = { ' ' };
        List<string> words = input.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
        return words;
    }

    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        int symbolsPerLine = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < lines; i++)
        {
            string input = Console.ReadLine();

            foreach (var item in SplitText(input))
            {
                words.Add(item);
            }
        }

        int next = 0;
        int startRow = 0;
        int allWords = words.Count;
        int rowLength = words[next].Length;
        next++;

        StringBuilder print = new StringBuilder();

        do
        {
            if (rowLength + words[next].Length + 1 > symbolsPerLine)
            {
                print.AppendLine(Row(words, startRow, next - 1, rowLength, symbolsPerLine));
                startRow = next;
                rowLength = words[next].Length;
            }
            else
            {
                rowLength = rowLength + words[next].Length + 1;
            }
                     
            if (next == allWords - 1)
            {
                print.AppendLine(Row(words, startRow, next, rowLength, symbolsPerLine));
            }
            next++;
        } while (next < allWords);
        Console.WriteLine(print);
    }
}