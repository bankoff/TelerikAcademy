// Write a program that reads three integer numbers N, K and S and an array 
// of N elements from the console. Find in the array a subset of K elements 
// that have sum S or indicate about its absence.

using System;

class SubsetSumSOfKElements
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

        uint kElements;
        do
        {
            Console.Write("Please enter the count of elements: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out kElements));

        uint numbersN;
        do
        {
            Console.Write("Please enter the size of array: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out numbersN));

        int[] array = new int[numbersN];
        for (int i = 0; i < numbersN; i++)
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
        int maxSubsets = (int)Math.Pow(2, numbersN);
        for (int i = 1; i < maxSubsets; i++)
        {
            subset = string.Empty;
            int checkingSum = 0;
            int counter = 0;
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
                        counter++;
                    }
                    else
                    {
                        subset = subset + "+" + array[j];
                        counter++;
                    }
                }
            }
            if (checkingSum == sumS && counter == kElements)
            {
                Console.WriteLine("Subset sum {0} of {1} elements is {2}", sumS, kElements, subset);
                haveGivenSum = true;
            }
        }
        if (!haveGivenSum)
        {
            Console.WriteLine("No sequence of {0} elements with the given sum", kElements);
        }
    }
}