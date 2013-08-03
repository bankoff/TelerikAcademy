//Write a method that return the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.

using System;

class MaximalElement
{
    static void Main()
    {
        //can be tested with manually entered data
        //uint sizeOfArray;
        //do
        //{
        //    Console.Write("Please enter size of array: ");
        //}
        //while (!uint.TryParse(Console.ReadLine(), out sizeOfArray));

        //int[] array = new int[sizeOfArray];
        //for (int i = 0; i < array.Length; i++)
        //{
        //    do
        //    {
        //        Console.Write("Please enter element {0} of array: ", i);
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out array[i]));
        //}

        //int portionStartIndex;
        //do
        //{
        //    Console.Write("Please enter portion start index: ");
        //}
        //while (!int.TryParse(Console.ReadLine(), out portionStartIndex));

        //int portionLength;
        //do
        //{
        //    Console.Write("Please enter portion length: ");
        //}
        //while (!int.TryParse(Console.ReadLine(), out portionLength));

        int[] array = new int[] { 12, 51, 23, 14, 17, 98, -15,14, 12, 0, -60, 23, 2 };
        int portionStartIndex = 3;
        int portionLength = 6;

        Console.Write("Array: ");
        PrintArray(array);
        Console.WriteLine();

        int maxElementInPortion = FindMaxInPortion(array, portionStartIndex, portionLength);
        Console.WriteLine("The maximal element in portion whit start index {0}", portionStartIndex);
        Console.WriteLine("and lenght {0} is: {1}",portionLength, maxElementInPortion);

        Console.Write("\nAscending array is: ");
        SortAscending(array);
        PrintArray(array);

        Console.Write("\nDescending array is: ");
        SortDescending(array);
        PrintArray(array);
    }

    static int FindMaxInPortion(int[] arr, int start, int lenght)
    {
        int maxElement = int.MinValue;
        int indexOfMaxElement = 0;
        for (int i = start; i < start + lenght; i++)
        {
            if (arr[i] > maxElement)
            {
                maxElement = arr[i];
                indexOfMaxElement = i;
            }
        }
        int reverse = arr[indexOfMaxElement];
        arr[indexOfMaxElement] = arr[start];
        arr[start] = reverse;
        return maxElement;
    }

    static int[] SortDescending(int[] array)
    {
        int maximalElement = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            maximalElement = FindMaxInPortion(array, i, array.Length - i);
            array[i] = maximalElement;
            maximalElement = int.MinValue;
        }
        return array;
    }

    static int[] SortAscending(int[] array)
    {
        SortDescending(array);
        for (int i = 0; i < array.Length/2; i++)
        {
            int reverse = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = reverse;
        }
        return array;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}