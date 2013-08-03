//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
using System.Collections.Generic;

class NFactorial
{
    static void Main()
    {
        uint n;
        do
        {
            Console.Write("Please enter n = ");
        }
        while (!uint.TryParse(Console.ReadLine(), out n));

        int[] arr = CalculateFactorial(n);

        PrintFactorial(n, arr);
    }

    private static int[] CalculateFactorial(uint n)
    {
        int[] arr = { 1 };

        for (int multiplier = 1; multiplier <= n; multiplier++)
        {
            //create list= (array arr)*multiplier
            List<int> multi = new List<int>();
            int adder = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                multi.Add((arr[i] * multiplier + adder) % 10);
                adder = (arr[i] * multiplier + adder) / 10;
            }

            while (adder > 0)
            {
                multi.Add(adder % 10);
                adder = adder / 10;
            }
            arr = multi.ToArray();
            multi.Clear();
        }
        return arr;
    }

    private static void PrintFactorial(uint n,int[] arr)
    {
        Console.Write("{0}! = ",n);
        for (int k = arr.Length - 1; k >= 0; k--)
        {
                Console.Write(arr[k]);
        }
        Console.WriteLine();
    }
}