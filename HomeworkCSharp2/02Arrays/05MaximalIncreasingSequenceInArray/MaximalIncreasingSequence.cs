// Write a program that finds the maximal increasing sequence in an array. 
// Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        //declaring the array size 
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

        // calculate the maximal increasing sequence in an array
        int counter = 1;
        int maxSequence = 1;
        int sequencesWithMaxLength = 0;
        for (int i = 1; i < sizeOfArray; i++)
        {
            if (arrayOfIntegers[i] == arrayOfIntegers[i - 1] + 1)
            {
                counter++;
                if (counter > maxSequence)
                {
                    maxSequence = counter;
                    sequencesWithMaxLength = 1;
                }
                else if (counter == maxSequence)
                {
                    sequencesWithMaxLength++;
                }
            }
            else
            {
                counter = 1;
            }
        }

        // print the result
        if (sizeOfArray == 0)
        {
            Console.WriteLine("The maximal increasing sequence of elements in array is 0");
        }
        else if (sizeOfArray == 1)
        {
            Console.WriteLine("The maximal increasing sequence of elements in array is 1");
            Console.WriteLine("The element is {0}", arrayOfIntegers[0]);
        }
        else
        {
            Console.WriteLine("In array have {0} sequences with maximal length", sequencesWithMaxLength);
            Console.WriteLine("The maximal increasing sequence of elements in array is {0}", maxSequence);
            Console.WriteLine("The sequences are:");
            counter = 1;
            for (int i = 1; i < sizeOfArray; i++)
            {
                if (arrayOfIntegers[i] == arrayOfIntegers[i - 1] + 1)
                {
                    counter++;
                    if (counter == maxSequence)
                    {
                        Console.Write("{ ");
                        for (int j = 1; j <= maxSequence; j++)
                        {
                            if (j < maxSequence)
                            {
                                Console.Write("{0}, ", arrayOfIntegers[i - maxSequence + j]);
                            }
                            else
                            {
                                Console.Write("{0} ", arrayOfIntegers[i - maxSequence + j]);
                            }
                        }
                        Console.WriteLine("}");
                    }
                }
                else
                {
                    counter = 1;
                }
            }
        }
    }
}