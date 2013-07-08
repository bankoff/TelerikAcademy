// Write a program that finds in given array of integers a sequence 
// of given sum S (if present). 
// Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}

using System;

class FindSequenceGivenSum
{
    static void Main()
    {
        //reading the input data from the console
        int givenSum;
        do
        {
            Console.Write("Please enter the given sum: ");
        }
        while (!int.TryParse(Console.ReadLine(), out givenSum));

        uint sizeOfArray;
        do
        {
            Console.Write("Please enter the size of array: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out sizeOfArray));

        int[] arrayOfIntegers = new int[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            do
            {
                Console.Write("Please enter element {0} of array: ", i + 1);
            }
            while (!int.TryParse(Console.ReadLine(), out arrayOfIntegers[i]));
        }

        string subset = string.Empty;
        bool haveGivenSum = false;

        // solution with bitwise operations
        // combinations are equal the number of elements per square
        // We present each number as a bit position in the binary number
        // This cycle checks all possible combinations                                                     
        int maxSubsets = (int)Math.Pow(2, sizeOfArray);
        for (int i = 1; i < maxSubsets; i++)
        {
            subset = string.Empty;
            int checkingSum = 0;
            for (int j = 0; j < arrayOfIntegers.Length; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    checkingSum = checkingSum + arrayOfIntegers[j];
                    if (subset=="")
                    {
                        subset = subset + arrayOfIntegers[j];
                    }
                    else
                    {
                        subset = subset + ", " + arrayOfIntegers[j];
                    }
                }
            }
            if (checkingSum == givenSum)
            {
                Console.WriteLine("{1} -> {{{0}}} ", subset, givenSum);
                haveGivenSum = true;
            }
        }
        if (!haveGivenSum)
        {
            Console.WriteLine("No sequence with the given sum");
        }
    }
}