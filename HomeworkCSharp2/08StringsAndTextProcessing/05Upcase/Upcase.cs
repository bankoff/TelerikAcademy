//You are given a text. Write a program that changes the text in all regions surrounded 
//by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
//We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result:
//We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;

class Upcase
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(text+"\n");
        int topSubstringIndex = 0;
        int bottomSubstringIndex = text.IndexOf("<upcase>");

        while (bottomSubstringIndex >= 0)
        {
            Console.Write(text.Substring(topSubstringIndex, bottomSubstringIndex - topSubstringIndex));
            topSubstringIndex = bottomSubstringIndex + 8;
            bottomSubstringIndex = text.IndexOf("</upcase>", bottomSubstringIndex + 1);
            Console.Write(text.Substring(topSubstringIndex, bottomSubstringIndex - topSubstringIndex).ToUpper());
            topSubstringIndex = bottomSubstringIndex + 9;
            bottomSubstringIndex = text.IndexOf("<upcase>", bottomSubstringIndex + 1);
        }
        Console.Write(text.Substring(text.LastIndexOf("</upcase>") + 9, text.Length - text.LastIndexOf("</upcase>") - 9));
        Console.WriteLine();
    }
}