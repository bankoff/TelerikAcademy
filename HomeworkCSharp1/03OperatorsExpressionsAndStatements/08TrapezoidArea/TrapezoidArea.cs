// Write an expression that calculates trapezoid's area 
// by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Input a side \"a\" of trapezoid");
        string sideAStr = Console.ReadLine();
        float sideA = float.Parse(sideAStr);
        Console.WriteLine("Input a side \"b\" of trapezoid");
        string sideBStr = Console.ReadLine();
        float sideB = float.Parse(sideBStr);
        Console.WriteLine("Input a height of trapezoid");
        string heightStr = Console.ReadLine();
        float height = float.Parse(heightStr);
        float area = (sideA+sideB)*height/2;
        Console.WriteLine("Area of trapezoid is: {0}", area);
    }
}