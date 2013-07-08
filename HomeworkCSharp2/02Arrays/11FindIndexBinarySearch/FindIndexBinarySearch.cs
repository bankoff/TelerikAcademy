// Write a program that finds the index of given element in a sorted array 
// of integers by using the binary search algorithm (find it in Wikipedia).

using System;

class FindIndexBinarySearch
{
    static void Main()
    {
        //reading the input data from the console
        uint sizeOfArray;
        do
        {
            Console.Write("Please enter the size of array: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out sizeOfArray));

        Console.Write("Enter the index of which number you are searching: ");
        int searchedNumber = int.Parse(Console.ReadLine());
        bool numberExists = false;

        int[] arrayOfIntegers = new int[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            do
            {
                Console.Write("Please enter element {0} of array: ", i);
            }
            while (!int.TryParse(Console.ReadLine(), out arrayOfIntegers[i]));
        }

        // sort array
        Array.Sort(arrayOfIntegers);

        //print sorted array
        Console.Write("The sorted array is:");
        for (int i = 0; i < sizeOfArray; i++)
        {
            Console.Write("{0} ",arrayOfIntegers[i]);
        }
        Console.WriteLine();

        //binary search algorithm
        int low = 0;
        int high = (int)sizeOfArray - 1; 
        int midpoint = 0;

        while (low <= high)
        {
            midpoint = low + (high - low) / 2;

            if (searchedNumber == arrayOfIntegers[midpoint])
            {
                numberExists = true;
                Console.WriteLine("The index of the number {0} in the sorted array,\nstarting from zero is {1}.",searchedNumber ,midpoint);
                break;
            }
            else if (searchedNumber < arrayOfIntegers[midpoint])
                high = midpoint - 1;
            else
                low = midpoint + 1;
        }

        if (numberExists == false)
        {
            Console.WriteLine("The number you are searching for does not exist in the array.");
        }
    }
}