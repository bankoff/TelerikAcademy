//Write a method that checks if the element at given position in given array of integers is bigger 
//than its two neighbors (when such exist).

using System;

class BiggerThanNeighbours
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

        uint position;
        do
        {
            Console.Write("Please enter position: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out position));

        //int[] testArray = { 44, 33, 35, 65, 34, 91, 86, 17, 24, 33 };
        //uint position = 5;

        if (CheckIfBigger(testArray, position))
        {
            Console.WriteLine("The element {0} at position {1} IS bigger than its neighbours.", testArray[position], position); 
        }
        else
        {
            Console.WriteLine("The element {0} at position {1} is NOT bigger than its neighbours.", testArray[position], position);
        }
    }
}