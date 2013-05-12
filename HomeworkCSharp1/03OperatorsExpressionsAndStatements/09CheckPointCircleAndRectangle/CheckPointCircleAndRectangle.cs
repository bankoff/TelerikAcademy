// Write an expression that checks for given point (x, y) 
// if it is within the circle K( (1,1), 3) and out of the 
// rectangle R(top=1, left=-1, width=6, height=2).

using System;

class CheckPointCircleAndRectangle
{
    static void Main()
    {
        Console.WriteLine("Input co-ordinate X of point A and then press Enter");
        string coordinateX = Console.ReadLine();
        float coordX = float.Parse(coordinateX);
        Console.WriteLine("Input co-ordinate Y of point A and then press Enter");
        string coordinateY = Console.ReadLine();
        float coordY = float.Parse(coordinateY);
        bool condition = ((3 * 3) > (((coordX - 1) * (coordX - 1)) + ((coordY - 1) * (coordY - 1)))) &
            ((coordX < -1) | (coordX > 5) | (coordY > 1) | (coordY < -1));
        if (condition)
        {
            Console.WriteLine("The point ({0},{1}) is within the circle K((1,1)3)"+
                "\nand ouside the rectangle (top=1, left=-1, width=6, height=2).", coordX, coordY);
        }
        else
        {
            Console.WriteLine("The point ({0},{1}) do not meet the required conditions" +
                "\nfor the given circle and rectangle.", coordX, coordY);
        }
    }
}
