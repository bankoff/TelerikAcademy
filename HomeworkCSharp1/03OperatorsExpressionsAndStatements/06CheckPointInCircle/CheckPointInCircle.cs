// Write an expression that checks if given point (x,  y) is within a circle K((0,0), 5).

using System;

class CheckPointInCircle
{
    static void Main()
    {
        Console.WriteLine("Input co-ordinate X on point A and then press Enter");
        string coordinateX = Console.ReadLine();
        float coordX = float.Parse(coordinateX);
        Console.WriteLine("Input co-ordinate Y on point A and then press Enter");
        string coordinateY = Console.ReadLine();
        float coordY = float.Parse(coordinateY);
        if ((5 * 5) < ((coordX * coordX) + (coordY * coordY)))
        {
            Console.WriteLine("The point ({0},{1}) is out of a circle K((0,0), 5)", coordX, coordY);
        }
        else
        {
            Console.WriteLine("The point ({0},{1}) in a circle K((0,0), 5)", coordX, coordY);
        }
    }
}