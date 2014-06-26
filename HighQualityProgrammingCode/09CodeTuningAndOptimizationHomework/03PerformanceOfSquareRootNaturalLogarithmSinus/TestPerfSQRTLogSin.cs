// Write a program to compare the performance of square root, natural logarithm, sinus for float, double and decimal values.
// Test all methods with the same number of iterations - 1,000,000
namespace _03PerformanceOfSquareRootNaturalLogarithmSinus
{
    using System;
    using System.Diagnostics;

    public class TestPerfSQRTLogSin
    {
        public static void Main()
        {
            var timer = new Stopwatch();

            // SQRT Methods
            timer.Start();
            SqrtMethods.CalculateSqrtFloat(1f, 1000000f);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Sqrt for float values");

            timer.Reset();
            timer.Start();
            SqrtMethods.CalculateSqrtDouble(1d, 1000000d);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Sqrt for double values");

            timer.Reset();
            timer.Start();
            SqrtMethods.CalculateSqrtDecimal(1m, 1000000m);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Sqrt for decimal values");

            // Logarithm Methods
            Console.WriteLine();
            timer.Reset();
            timer.Start();
            LogMethods.CalculateLogFloat(1f, 1000000f);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Logarithm for float values");

            timer.Reset();
            timer.Start();
            LogMethods.CalculateLogDouble(1d, 1000000d);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Logarithm for double values");

            timer.Reset();
            timer.Start();
            LogMethods.CalculateLogDecimal(1m, 1000000m);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Logarithm for decimal values");

            // Sinus Methods
            Console.WriteLine();
            timer.Reset();
            timer.Start();
            SinusMethods.CalculateSinFloat(1f, 1000000f);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Sinus for float values");

            timer.Reset();
            timer.Start();
            SinusMethods.CalculateSinDouble(1d, 1000000d);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Sinus for double values");

            timer.Reset();
            timer.Start();
            SinusMethods.CalculateSinDecimal(1m, 1000000m);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Sinus for decimal values");
        }
    }
}
