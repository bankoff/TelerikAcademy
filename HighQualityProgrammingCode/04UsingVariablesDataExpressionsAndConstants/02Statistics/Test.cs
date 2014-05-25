namespace Statistics
{
    using System.Globalization;
    using System.Threading;

    public class Test
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double[] arr = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Statistics.PrintStatistics(arr);
        }
    }
}
