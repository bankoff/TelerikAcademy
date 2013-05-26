// Write a program that reads from the console a sequence of N 
// integer numbers and returns the minimal and maximal of them.

using System;

class MinAndMaxInSequence
{
    static void Main()
    {
        Console.WriteLine("Input size of sequence:");
        int count = int.Parse(Console.ReadLine());
        int[] number = new int[count];
        for (int i = 0; i < number.Length; i++)
        {
            Console.WriteLine("Input number {0}:",i+1);
            number[i] = int.Parse(Console.ReadLine());
        }
        int max = number[0];
        int min = number[0];
        for (int i = 0; i < number.Length; i++)
        { 
            if (max<number[i])
            {
                max = number[i];
            }
            if (min>number[i])
            {
                min = number[i];
            }
        }
        Console.WriteLine("Maximal member in sequence is: {0}", max);
        Console.WriteLine("Minimal member in sequence is: {0}", min);
    }
}
