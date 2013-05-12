// Write a boolean expression that checks for given integer if it can be 
// divided (without remainder) by 7 and 5 in the same time.

using System;

class BooleanExpression
{
    static void Main()
    {
        Console.WriteLine("Input a number and then press Enter");
        string numberStr = Console.ReadLine();
        int number = int.Parse(numberStr);
        bool divide7 = (number % 7) == 0;
        bool divide5 = (number % 5) == 0;
        if (divide7 && divide5)
        {
            Console.WriteLine("The number {0} can be divided without remainder by 7 and 5.", number);
        }
        else
        {
            Console.WriteLine("The number {0} can not be divided without remainder by 7 and 5.", number);
        }
    }
}