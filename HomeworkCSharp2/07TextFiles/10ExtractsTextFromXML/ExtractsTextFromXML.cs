// Write a program that extracts from given XML file all the text without the tags. Example:
// <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest> Games</instrest><interest>C#</instrest><interest> Java</instrest></interests></student>

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

class ExtractsTextFromXML
{
    static void Main()
    {
        using (StreamReader input = new StreamReader(@"../../xml.txt"))
            for (int i; (i = input.Read()) != -1; )
            {
                if (i == '>' && input.Peek() != '<' && input.Peek() != '\r' && input.Peek() != '\n')
                {
                    while ((i = input.Read()) != '<') // Inside text node
                    {
                        Console.Write((char)i);
                        if (input.Peek() == '<')
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
        Console.WriteLine();

        //string text = @"<?xml version=""1.0""><student><name>Pesho</name> <age>21</age><interests count=""3""><interest> Games</instrest><interest>C#</instrest><interest> Java</instrest></interests></student>";
        //for (int i = 0; i < text.Length - 1; )
        //{
        //    if (text[i] == '>' && text[i + 1] != '<')
        //    {
        //        for (int j = i + 1; j < text.Length - 1 && text[j] != '<'; j++)
        //        {
        //            Console.Write(text[j]);
        //        }
        //        i++;
        //        Console.Write(" ");
        //    }
        //    else
        //    {
        //        i++;
        //    }
        //}
        //Console.WriteLine();
    }
}