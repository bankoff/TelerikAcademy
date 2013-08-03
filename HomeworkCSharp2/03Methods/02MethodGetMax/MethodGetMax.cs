//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class MethodGetMax
{
    static void Main()
    {
        int n = 3;
        int[] array = new int[n];

        //read elements from console
        for (int i = 0; i < array.Length; i++)
        {
            do
            {
                Console.Write("Please enter element {0} of array: ", i);
            }
            while (!int.TryParse(Console.ReadLine(), out array[i]));
        }

        int maxElement = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            maxElement = GetMax(maxElement, array[i]);
        }

        Console.WriteLine("Biggest integer in array is {0}", maxElement);
    }

    //check the bigger of two integers
    static int GetMax(int first,int second)
    {
        int max = Math.Max(first,second);
        return max;
    }
}