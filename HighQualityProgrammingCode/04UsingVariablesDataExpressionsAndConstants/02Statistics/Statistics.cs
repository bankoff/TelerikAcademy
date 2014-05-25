// 2. Refactor the following code to apply variable usage and naming best practices:

namespace Statistics
{
    using System;

    public class Statistics
    {
        public static void PrintStatistics(double[] arr)
        {
            double min = GetMinValueOfArray(arr);
            Console.WriteLine("Min value = " + min);

            double max = GetMaxElementOfArray(arr);
            Console.WriteLine("Max value = " + max);

            double average = GetAverageValueOfArray(arr);
            Console.WriteLine("Average = " + average);
        }

        public static double GetMinValueOfArray(double[] arr)
        {
            int count = arr.Length;
            double min = double.MaxValue;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        public static double GetMaxElementOfArray(double[] arr)
        {
            int count = arr.Length;
            double max = double.MinValue;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        public static double GetAverageValueOfArray(double[] arr)
        {
            int count = arr.Length;
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }

            double average = sum / count;

            return average;
        }
    }
}