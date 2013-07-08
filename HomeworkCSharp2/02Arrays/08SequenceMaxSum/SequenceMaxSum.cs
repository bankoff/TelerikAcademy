//Write a program that finds the sequence of maximal sum in given array. 
//Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class SequenceMaxSum
{
    static void Main()
    {
        //read the array size from the console
        uint sizeOfArray;
        do
        {
            Console.Write("Please enter the size of array: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out sizeOfArray));

        //read array elements from the console
        int[] arrayOfIntegers = new int[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            do
            {
                Console.Write("Please enter element {0} of array: ", i + 1);
            }
            while (!int.TryParse(Console.ReadLine(), out arrayOfIntegers[i]));
        }

        //Kadane's algorithm
        int maxSum = arrayOfIntegers[0];
        int sum = arrayOfIntegers[0];
        int finalSequenceLength = 1;
        int currentSequenceLength = 1;
        int startIndex = 0;
        int startIndexTemp = 0;

        for (int i = 1; i < arrayOfIntegers.Length; i++)
        {
            if (arrayOfIntegers[i] + sum > arrayOfIntegers[i])
            {
                sum = arrayOfIntegers[i] + sum;
                currentSequenceLength++;
            }

            else
            {
                sum = arrayOfIntegers[i];
                startIndexTemp = i;
                currentSequenceLength = 1;
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                finalSequenceLength = currentSequenceLength;
                startIndex = startIndexTemp;
            }
        }

        //print result
        for (int i = startIndex; i < startIndex + finalSequenceLength; i++)
        {
            Console.Write("{0} ", arrayOfIntegers[i]);
        }
        Console.WriteLine("\nMaximal sum is: {0}",maxSum);
    }
}