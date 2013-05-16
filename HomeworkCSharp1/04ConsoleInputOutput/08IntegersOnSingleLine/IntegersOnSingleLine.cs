// Write a program that reads an integer number n from 
// the console and prints all the numbers in the 
// interval [1..n], each on a single line.

using System;

class IntegersOnSingleLine
{
    static void Main()
    {
        Console.WriteLine("Input total number N for printing");
        Console.Write("n = ");
        string nStr = Console.ReadLine();
        int n = int.Parse(nStr);
        for (int counter = 1; counter <= n; counter++)
        {
            Console.WriteLine(counter);
        }
    }
}
