//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;

class TriangleSurface
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("You can calculate the surface of the triangle by:");
            Console.WriteLine("Press 1 for side and an altitude to it");
            Console.WriteLine("Press 2 for three sides");
            Console.WriteLine("Press 3 for two sides and an angle between them");
        } while (!(int.TryParse(Console.ReadLine(), out choice) && (choice == 1 || choice == 2 || choice == 3)));

        if (choice == 1) Console.WriteLine(TriangleSurfaceBySideAndAltitude());
        if (choice == 2) Console.WriteLine(TriangleSurfaceByThreeSides());
        if (choice == 3) Console.WriteLine(TriangleSurfaceByTwoSidesAndAngle());
    }

    static double Value(string name)
    {
        double value;
        do
        {
            Console.Write("Please enter value of {0}: ", name);
        } while (!(double.TryParse(Console.ReadLine(), out value) && value > 0));
        return value;
    }

    static double TriangleSurfaceBySideAndAltitude()
    {
        double triangleSurface = (Value("side A") * Value("altitude to it")) / 2;
        return triangleSurface;
    }

    static double TriangleSurfaceByThreeSides()
    {
        double sideA = Value("side A");
        double sideB = Value("side B");
        double sideC = Value("side C");
        double halfPerimeter = (sideA + sideB + sideC) / 2;
        double triangleSurface = Math.Sqrt((halfPerimeter) * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
        return triangleSurface;
    }

    static double TriangleSurfaceByTwoSidesAndAngle()
    {
                                                                               //angle is converted in radians
        double triangleSurface = (Value("side A") * Value("side B") * Math.Sin(Value("angle in degrees") * Math.PI / 180)) / 2;                                                                      
        return triangleSurface;
    }
}