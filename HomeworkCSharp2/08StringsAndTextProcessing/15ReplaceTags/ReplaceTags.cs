//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> 
//with corresponding tags [URL=…]…/URL]. Sample HTML fragment:
//
//<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. 
//Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
//
//<p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. 
//Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

using System;

class ReplaceTags
{
    static void Main()
    {
        string text = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. 
Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        Console.WriteLine(text +"\n");

        string replaced = text.Replace(@"<a href=""", "[URL=");
        replaced = replaced.Replace(@"</a>", "[/URL]");
        replaced = replaced.Replace(@""">", "]");
        Console.WriteLine(replaced);
    }
}