// Write a program that reads two positive integer numbers 
// and prints how many numbers p exist between them such 
// that the reminder of the division by 5 is 0 (inclusive). 
// Example: p(17,25) = 2.

using System;

class NumbersDividedBy5
{
    static void Main()
    {
        Console.WriteLine("Input first positive integer and then press Enter");
        Console.Write("integer1 = ");
        string integer1Str = Console.ReadLine();
        int integer1 = int.Parse(integer1Str);
        Console.WriteLine("Input second positive integer and then press Enter");
        Console.Write("integer2 = ");
        string integer2Str = Console.ReadLine();
        int integer2 = int.Parse(integer2Str);
        int integer,counter, assist1;

        // if first integer is bigger than second, I exchange them
        if (integer1 > integer2)
        {
            integer = integer1;
            integer1 = integer2;
            integer2 = integer;
        }

        // check if first integer can be divided by 5 without remainder, in order to check whether to count it
        assist1 = integer1 % 5;
        if (assist1 == 0)
        {
            counter = ((integer2 - integer1) / 5) + 1;
        }
        else
        {
            int assist2 = ((integer1 / 5) + 1) * 5;
            counter = ((integer2 - assist2) / 5) + 1;
        }
        Console.WriteLine("p({0} , {1}) = {2}", integer1, integer2, counter);
    }
}