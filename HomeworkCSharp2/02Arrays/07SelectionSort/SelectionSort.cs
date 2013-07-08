//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the 
//smallest from the rest, move it at the second position, etc.

using System;

class SelectionSort
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

        //sort array with "selection sort" algorithm
        int min, temp;
        for (int i = 0; i < sizeOfArray - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < sizeOfArray; j++)
            {
                if (arrayOfIntegers[j] < arrayOfIntegers[min])
                {
                    min = j;
                }
            }
            temp = arrayOfIntegers[i];
            arrayOfIntegers[i] = arrayOfIntegers[min];
            arrayOfIntegers[min] = temp;
        }

        //print sorted array
        Console.Write("The sorted array is:   ");
        for (int i = 0; i < sizeOfArray; i++)
        {
            Console.Write("{0} ",arrayOfIntegers[i]);
        }
        Console.WriteLine();
    }
}