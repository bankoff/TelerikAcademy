//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
//.NET – platform for applications from Microsoft
//CLR – managed execution environment for .NET
//namespace – hierarchical organization of classes

using System;

class Dictionary
{
    static void Main()
    {
        string[] dictionary = { ".NET - platform for applications from Microsoft", 
                                "CLR - managed execution environment for .NET", 
                                "namespace - hierarchical organization of classes",
                                "C++ - is a programming language that is general purpose, statically typed, free-form, multi-paradigm and compiled",
                                "Java - object-oriented programming language, similar to C#",
                                "PHP - is a server-side scripting language designed for web development",
                                "Javascript - web programming language"};
        string word = "C++"; //Console.ReadLine();

        foreach (string line in dictionary)
        {
            if (line.IndexOf(word + " -") == 0)
            {
                Console.WriteLine(line);
            }
        }
    }
}