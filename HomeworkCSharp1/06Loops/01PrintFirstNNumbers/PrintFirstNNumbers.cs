// Write a program that prints all the numbers from 1 to N.

using System;

class PrintFirstNNumbers
{
    static void Main()
    {
        Console.WriteLine("Input number N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers from 1 to N are: ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}

