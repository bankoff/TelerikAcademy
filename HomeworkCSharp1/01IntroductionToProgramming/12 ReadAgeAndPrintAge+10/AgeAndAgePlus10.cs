// Write a program to read your age from the console and print how old you will be after 10 years

using System;

class ReadAgeAndPrintAgePlus10
{
    static void Main()
    {
        Console.WriteLine("Please input your current age with positive integer.Then press Enter.");
        string age = Console.ReadLine();
        int age1 = int.Parse(age);
        Console.WriteLine("After 10 years you will be {0} years old", age1 + 10);
    }
}