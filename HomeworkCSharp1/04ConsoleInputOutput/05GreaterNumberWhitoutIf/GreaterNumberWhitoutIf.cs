// Write a program that gets two numbers from the console and 
// prints the greater of them. Don’t use if statements.

using System;

class GreaterNumberWhitoutIf
{
    static void Main()
    {
        Console.WriteLine("Input first integer and then press Enter");
        Console.Write("integer1 = ");
        string integer1Str = Console.ReadLine();
        int integer1 = int.Parse(integer1Str);
        Console.WriteLine("Input second integer and then press Enter");
        Console.Write("integer2 = ");
        string integer2Str = Console.ReadLine();
        int integer2 = int.Parse(integer2Str);

        // bitwise calculation of the bigger of two integers
        int max = integer1 - ((integer1-integer2)&((integer1-integer2)>>31)); 
        Console.WriteLine("Bigger number is:" + max);
    }
}

