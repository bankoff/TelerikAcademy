﻿using System;
using System.Diagnostics;

public class AssertionsHomework
{
    public static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };

        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }

    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array is null!");

        int arrayLength = arr.Length;

        for (int index = 0; index < arrayLength - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arrayLength - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        // assertion whether the array is sorted
        for (int i = 0; i < arrayLength - 1; i++)
        {
            Debug.Assert(arr[i].CompareTo(arr[i + 1]) <= 0, "The array is not sorted!");
        }
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array is null");
        Debug.Assert(value != null, "Searched value cannot be null!");

        for (int i = 0; i < arr.Length - 1; i++)
        {
            Debug.Assert(arr[i].CompareTo(arr[i + 1]) <= 0, "The array is not sorted!");
        }

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array is null");
        Debug.Assert(value != null, "Searched value cannot be null!");
        Debug.Assert(startIndex >= 0, "Start index should be positive!");
        Debug.Assert(endIndex >= 0, "End index should be positive!");
        Debug.Assert(startIndex <= endIndex, "Start index should be smaller than or equal to end index!");
        Debug.Assert(endIndex <= arr.Length - 1, "End index should be smaller than the length of the array!");

        for (int i = 0; i < arr.Length - 1; i++)
        {
            Debug.Assert(arr[i].CompareTo(arr[i + 1]) <= 0, "The array is not sorted!");
        }

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;

            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array is null!");

        int arrayLength = arr.Length;

        Debug.Assert(startIndex >= 0, "Start index should be positive!");
        Debug.Assert(endIndex >= 0, "End index should be positive!");
        Debug.Assert(startIndex <= endIndex, "Start index should be smaller than or equal to end index!");
        Debug.Assert(endIndex <= arrayLength - 1, "End index should be smaller than the length of the array!");

        int minElementIndex = startIndex;

        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        // assertion whether the found element is indeed the smallest one
        for (int i = startIndex + 1; i < endIndex; i++)
        {
            Debug.Assert(arr[minElementIndex].CompareTo(arr[i]) <= 0, "The element" + arr[minElementIndex] + " is not the smallest!");
        }

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        T oldY = y;

        x = y;
        y = oldX;

        Debug.Assert(oldX.Equals(y) && oldY.Equals(x), "The elements are not swapped");
    }
}
