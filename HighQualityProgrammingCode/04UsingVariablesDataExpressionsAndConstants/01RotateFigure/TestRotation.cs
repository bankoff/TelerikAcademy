namespace RotateFigure
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class TestRotation
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Figure initial = new Figure(4, 9);
            Console.WriteLine("Initial figure is:");
            Console.WriteLine(initial.ToString());

            Console.WriteLine();

            double angleOfRotation = 60;
            Figure rotated = Figure.GetRotatedFigure(initial, angleOfRotation);
            Console.WriteLine("Figure after rotation at {0} degrees is", angleOfRotation);
            Console.WriteLine(rotated.ToString());
        }
    }
}
