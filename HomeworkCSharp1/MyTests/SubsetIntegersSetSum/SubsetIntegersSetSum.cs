// We are given 5 integer numbers. Write a program that checks if the 
// sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0

using System;

class SubsetIntegersSetSum
{
    static void Main()
    {
        Console.WriteLine("Enter the wanted sum of the subsets:");
        int wantedSum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of elements:");
        int numberOfElements = int.Parse(Console.ReadLine());
        int[] elements = new int[numberOfElements];
        int counter = 0;
        string subset = "";

        for (int i = 0; i < elements.Length; i++)
        {
            Console.WriteLine("Enter element № {0}", i + 1);
            elements[i] = int.Parse(Console.ReadLine());
        }                                                       // decision with bitwise operations
        int maxSubsets = (int)Math.Pow(2, numberOfElements);    // combinations are equal the number of elements per square
        // We present each number as a bit position in the binary number
        for (int i = 1; i < maxSubsets; i++)                    // This cycle checks all possible combinations
        {
            subset = "";
            int checkingSum = 0;
            for (int j = 0; j < elements.Length; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    checkingSum = checkingSum + elements[j];
                    subset = subset + " " + elements[j];
                }
            }
            if (checkingSum == wantedSum)
            {
                Console.WriteLine("Number of subest that have the sum of {0}", wantedSum);
                counter++;
                Console.WriteLine("This subset has a sum of {0} : {1} ", wantedSum, subset);
            }
        }
        Console.WriteLine(counter);
    }
}
