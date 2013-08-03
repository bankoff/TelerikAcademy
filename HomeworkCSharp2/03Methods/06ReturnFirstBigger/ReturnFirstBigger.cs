// Write a method that returns the index of the first element in array that is bigger than its neighbors, 
// or -1, if there’s no such element.
// Use the method from the previous exercise.

using System;

class ReturnFirstBigger
{
    static bool CheckIfBigger(int[] testArray, uint position)
    {
        if ((testArray.Length == 1) || (position == 0 && testArray[position] > testArray[position + 1]) ||
            (position == testArray.Length - 1 && testArray[position] > testArray[position - 1]) ||
            ((position > 0 && position < testArray.Length - 1) &&
            (testArray[position] > testArray[position - 1]) && (testArray[position] > testArray[position + 1])))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static int FirstBigger(int[] testArray)
    {
        for (int i = 0; i < testArray.Length; i++)
        {
            if (CheckIfBigger(testArray,(uint)i))
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        uint sizeOfArray;
        do
        {
            Console.Write("Please enter size of array: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out sizeOfArray));

        int[] testArray = new int[sizeOfArray];
        for (int i = 0; i < testArray.Length; i++)
        {
            do
            {
                Console.Write("Please enter element {0} of array: ", i);
            }
            while (!int.TryParse(Console.ReadLine(), out testArray[i]));
        }

        //int[] testArray = { 24, 33, 35, 65, 34, 91, 86, 17, 24, 33 };

        Console.WriteLine("Index of the first element in array that is bigger \nthan its neighbors is: {0}", FirstBigger(testArray));
    }
}