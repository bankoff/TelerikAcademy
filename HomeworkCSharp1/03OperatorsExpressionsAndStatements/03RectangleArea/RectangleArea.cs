// Write an expression that calculates rectangle’s area by given width and height

using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Input a width of rectangle");
        string widthStr = Console.ReadLine();
        float width = float.Parse(widthStr);
        Console.WriteLine("Input a height of rectangle");
        string heightStr = Console.ReadLine();
        float height = float.Parse(heightStr);
        float area = width * height;
        Console.WriteLine("Area of rectangle is: {0}", area);
    }
}