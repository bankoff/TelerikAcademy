namespace _03PerformanceOfSquareRootNaturalLogarithmSinus
{
    using System;

    public class SinusMethods
    {
        public static void CalculateSinFloat(float startValue, float endValue)
        {
            for (float i = startValue; i <= endValue; i++)
            {
                Math.Sin(i);
            }
        }

        public static void CalculateSinDouble(double startValue, double endValue)
        {
            for (double i = startValue; i <= endValue; i++)
            {
                Math.Sin(i);
            }
        }

        public static void CalculateSinDecimal(decimal startValue, decimal endValue)
        {
            for (decimal i = startValue; i <= endValue; i++)
            {
                Math.Sin((double)i);
            }
        }
    }
}
