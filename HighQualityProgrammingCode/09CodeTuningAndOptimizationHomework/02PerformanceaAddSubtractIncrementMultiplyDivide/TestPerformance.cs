// Write a program to compare the performance of add, subtract, increment, multiply, divide for int, long, float, double and decimal values.
namespace _02PerformanceaAddSubtractIncrementMultiplyDivide
{
    using System;
    using System.Diagnostics;

    public class TestPerformance
    {
        public static void Main()
        {
            var timer = new Stopwatch();

            // Add Methods
            timer.Start();
            AddMethods.AddInt(1, 500000);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Add Int");

            timer.Reset();
            timer.Start();
            AddMethods.AddLong(1L, 500000L);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Add Long");

            timer.Reset();
            timer.Start();
            AddMethods.AddFloat(1f, 500000f);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Add Float");

            timer.Reset();
            timer.Start();
            AddMethods.AddDouble(1d, 500000d);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Add Double");
            timer.Reset();

            timer.Start();
            AddMethods.AddDecimal(1m, 500000m);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Add Decimal");

            // Substract Methods
            Console.WriteLine();
            timer.Reset();
            timer.Start();
            SubstractMethods.SubstractInt(500000, 1);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Substract Int");

            timer.Reset();
            timer.Start();
            SubstractMethods.SubstractLong(500000L, 1L);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Substract Long");

            timer.Reset();
            timer.Start();
            SubstractMethods.SubstractFloat(500000f, 1f);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Substract Float");

            timer.Reset();
            timer.Start();
            SubstractMethods.SubstractDouble(500000d, 1d);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Substract Double");
            timer.Reset();

            timer.Start();
            SubstractMethods.SubstractDecimal(500000m, 1m);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Substract Decimal");

            // Multiply Methods
            Console.WriteLine();
            timer.Reset();
            timer.Start();
            MultiplyMethods.MultiplyInt(1, 500000, 2);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Multiply Int");

            timer.Reset();
            timer.Start();
            MultiplyMethods.MultiplyLong(1L, 500000L, 2L);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Multiply Long");

            timer.Reset();
            timer.Start();
            MultiplyMethods.MultiplyFloat(1f, 500000f, 2f);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Multiply Float");

            timer.Reset();
            timer.Start();
            MultiplyMethods.MultiplyDouble(1d, 500000d, 2d);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Multiply Double");
            timer.Reset();

            timer.Start();
            MultiplyMethods.MultiplyDecimal(1m, 500000m, 2m);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Multiply Decimal");

            // Divide Methods
            Console.WriteLine();
            timer.Reset();
            timer.Start();
            DivideMethods.DivideInt(500000, 1, 2);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Divide Int");

            timer.Reset();
            timer.Start();
            DivideMethods.DivideLong(500000L, 1L, 2L);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Divide Long");

            timer.Reset();
            timer.Start();
            DivideMethods.DivideFloat(500000f, 1f, 2f);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Divide Float");

            timer.Reset();
            timer.Start();
            DivideMethods.DivideDouble(500000d, 1d, 2d);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Divide Double");
            timer.Reset();

            timer.Start();
            DivideMethods.DivideDecimal(500000m, 1m, 2m);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Divide Decimal");
        }
    }
}
