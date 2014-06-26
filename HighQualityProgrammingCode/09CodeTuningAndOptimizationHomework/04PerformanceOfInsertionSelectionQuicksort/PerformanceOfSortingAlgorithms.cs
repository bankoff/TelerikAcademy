// Write a program to compare the performance of insertion sort, selection sort, quicksort for int, double and string values. 
// Check also the following cases: random values, sorted values, values sorted in reversed order.
namespace _04PerformanceOfInsertionSelectionQuicksort
{
    using System;
    using System.Diagnostics;

    public class PerformanceOfSortingAlgorithms
    {
        private static int arraysLength = 1000;

        private static int[] intArrForInsertionSort = new int[arraysLength];
        private static int[] intArrForSelectionSort = new int[arraysLength];
        private static int[] intArrForQuickSort = new int[arraysLength];

        private static double[] doubleArrForInsertionSort = new double[arraysLength];
        private static double[] doubleArrForSelectionSort = new double[arraysLength];
        private static double[] doubleArrForQuickSort = new double[arraysLength];

        private static string[] stringArrForInsertionSort = new string[arraysLength];
        private static string[] stringArrForSelectionSort = new string[arraysLength];
        private static string[] stringArrForQuickSort = new string[arraysLength];

        public static void Main()
        {
            FillArrays();
            CheckSortRandomArrays();
            CheckSortSortedArrays();
            ReverseSortArrays();
            CheckSortReversedArrays();
        }

        public static void FillArrays()
        {
            int randomNumber;
            Random random = new Random();

            for (int i = 0; i < arraysLength; i++)
            {
                randomNumber = random.Next(1000);

                intArrForInsertionSort[i] = randomNumber;
                intArrForSelectionSort[i] = randomNumber;
                intArrForQuickSort[i] = randomNumber;

                doubleArrForInsertionSort[i] = randomNumber;
                doubleArrForSelectionSort[i] = randomNumber;
                doubleArrForQuickSort[i] = randomNumber;

                stringArrForInsertionSort[i] = randomNumber.ToString();
                stringArrForSelectionSort[i] = randomNumber.ToString();
                stringArrForQuickSort[i] = randomNumber.ToString();
            }
        }

        public static void CheckSort()
        {
            var timer = new Stopwatch();

            timer.Start();
            InsertionSort.SortArray(intArrForInsertionSort);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Insertion Sort for Int");

            timer.Reset();
            timer.Start();
            SelectionSort.SortArray(intArrForSelectionSort);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Selection Sort for Int");

            timer.Reset();
            timer.Start();
            QuickSort.Quicksort(intArrForQuickSort, 0, intArrForQuickSort.Length - 1);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Quick Sort for Int");

            timer.Reset();
            timer.Start();
            InsertionSort.SortArray(doubleArrForInsertionSort);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Insertion Sort for Double");

            timer.Reset();
            timer.Start();
            SelectionSort.SortArray(doubleArrForSelectionSort);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Selection Sort for Double");

            timer.Reset();
            timer.Start();
            QuickSort.Quicksort(doubleArrForQuickSort, 0, doubleArrForQuickSort.Length - 1);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Quick Sort for Double");

            timer.Reset();
            timer.Start();
            InsertionSort.SortArray(stringArrForInsertionSort);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Insertion Sort for String");

            timer.Reset();
            timer.Start();
            SelectionSort.SortArray(stringArrForSelectionSort);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Selection Sort for String");

            timer.Reset();
            timer.Start();
            QuickSort.Quicksort(stringArrForQuickSort, 0, stringArrForQuickSort.Length - 1);
            timer.Stop();
            Console.WriteLine(timer.Elapsed + " - Quick Sort for String");
            timer.Reset();
        }

        public static void CheckSortRandomArrays()
        {
            Console.WriteLine("Check sorting for random arrays");
            CheckSort();
            Console.WriteLine();
        }

        private static void CheckSortSortedArrays()
        {
            Console.WriteLine("Check sorting for sorted arrays");
            CheckSort();
            Console.WriteLine();
        }

        private static void ReverseSortArrays()
        {
            Array.Reverse(intArrForInsertionSort);
            Array.Reverse(intArrForSelectionSort);
            Array.Reverse(intArrForQuickSort);

            Array.Reverse(doubleArrForInsertionSort);
            Array.Reverse(doubleArrForSelectionSort);
            Array.Reverse(doubleArrForQuickSort);

            Array.Reverse(stringArrForInsertionSort);
            Array.Reverse(stringArrForSelectionSort);
            Array.Reverse(stringArrForQuickSort);
        }

        private static void CheckSortReversedArrays()
        {
            Console.WriteLine("Check sorting for reversed arrays");
            CheckSort();
            Console.WriteLine();
        }
    }
}
