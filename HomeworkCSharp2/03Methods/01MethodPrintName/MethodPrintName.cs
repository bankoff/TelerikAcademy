//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method.

using System;

class MethodPrintName
{
    // read name from console
    static string ReadName()
    {
        Console.Write("Enter your name: ");
        string readName = Console.ReadLine();
        return readName;
    }

    // check if the string contains only letters and if the first letter is capital
    static bool CheckName(string name)
    {
        bool result = true;
        for (int i = 0; i < name.Length; i++)
        {
            result = Char.IsLetter(name, i);
            if (!result || char.IsLower(name, 0))
            {
                result = false;
                break;
            }
        }
        return result;
    }

    // print on console
    static void PrintName(string name, bool checkName)
    {
        if (checkName)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        else
        {
            Console.WriteLine("This is not a name!");
        }
    }

    static void Main()
    {
        string name = ReadName();
        PrintName(name, CheckName(name));
    }
}