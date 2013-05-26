// We are given 5 integer numbers. Write a program that checks if the 
// sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0

using System;

class SubsetIntegersZeroSum
{
    static void Main()
    {
        int zeroSum = 0;

        int numberOfElements = 5;
        int[] elements = new int[numberOfElements];

        string subset = string.Empty;

        for (int i = 0; i < elements.Length; i++)
        {
            Console.WriteLine("Enter element № {0}", i + 1);
            elements[i] = int.Parse(Console.ReadLine());
        }                                                       // solution with bitwise operations
        int maxSubsets = (int)Math.Pow(2, numberOfElements);    // combinations are equal the number of elements per square
                                                                // We present each number as a bit position in the binary number
        for (int i = 1; i < maxSubsets; i++)                    // This cycle checks all possible combinations
        {
            subset = string.Empty;
            int checkingSum = 0;
            for (int j = 0; j < elements.Length; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    checkingSum = checkingSum + elements[j];
                    if (elements[j] < 0)
                    {
                        subset = subset + elements[j];
                    }
                    else
                    {
                        subset = subset + "+" + elements[j];
                    }
                }
            }
            if (checkingSum == zeroSum)
            {
                Console.WriteLine("{0} = {1} ", subset, zeroSum);
            }
        }
    }
}
