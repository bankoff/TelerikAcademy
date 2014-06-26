namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(File.GetExtension("example"));
            Console.WriteLine(File.GetExtension("example.pdf"));
            Console.WriteLine(File.GetExtension("example.new.pdf"));

            Console.WriteLine(File.GetNameWithoutExtension("example"));
            Console.WriteLine(File.GetNameWithoutExtension("example.pdf"));
            Console.WriteLine(File.GetNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", Calculate.Distance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", Calculate.Distance3D(5, 2, -1, 3, -6, 4));

            RectangularParallelepiped parallelepiped = new RectangularParallelepiped(width: 3, height: 4, depth: 5);

            Console.WriteLine("Volume = {0:f2}", parallelepiped.CalcVolume());
            Console.WriteLine("Body diagonal XYZ = {0:f2}", parallelepiped.CalcBodyDiagonal());
            Console.WriteLine("Diagonal XY = {0:f2}", parallelepiped.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", parallelepiped.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", parallelepiped.CalcDiagonalYZ());
        }
    }
}
