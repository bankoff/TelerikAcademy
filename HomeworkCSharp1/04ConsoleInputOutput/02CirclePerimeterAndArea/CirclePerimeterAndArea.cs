// Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Input radius \"r\" of circle and then press Enter");
        Console.Write("r = ");
        string rStr = Console.ReadLine();
        double r = double.Parse(rStr);

        double perimeter = 2 * r * Math.PI;
        double area = Math.Pow(r, 2) * Math.PI;
        Console.WriteLine("Perimeter = {0:0.00}", perimeter);
        Console.WriteLine("Area = {0:0.00}", area);
    }
}
