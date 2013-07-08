// We are given an array of integers and a number S. Write a program to find 
// if there exists a subset of the elements of the array that has a sum S. 
// Example:  arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

using System;

class SubsetSumS
{
    static void Main()
    {
        //reading the input data from the console
        int sumS;
        do
        {
            Console.Write("Please enter the given sum: ");
        }
        while (!int.TryParse(Console.ReadLine(), out sumS));

        uint sizeOfArray;
        do
        {
            Console.Write("Please enter the size of array: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out sizeOfArray));

        int[] array = new int[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            do
            {
                Console.Write("Please enter element {0} of array: ", i + 1);
            }
            while (!int.TryParse(Console.ReadLine(), out array[i]));
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
            for (int j = 0; j < array.Length; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    checkingSum = checkingSum + array[j];
                    if (array[j] < 0 || subset == "")
                    {
                        subset = subset + array[j];
                    }
                    else
                    {
                        subset = subset + "+" + array[j];
                    }
                }
            }
            if (checkingSum == sumS)
            {
                Console.WriteLine("yes {{{0}}} = {1} ", subset, sumS);
                haveGivenSum = true;
            }
        }
        if (!haveGivenSum)
        {
            Console.WriteLine("No sequence with the given sum");
        }
    }
}