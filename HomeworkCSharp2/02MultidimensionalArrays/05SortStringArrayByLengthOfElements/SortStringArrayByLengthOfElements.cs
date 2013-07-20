//You are given an array of strings. Write a method that sorts the array by the length 
//of its elements (the number of characters composing them).

using System;

class SortStringArrayByLengthOfElements
{
    static void Main()
    {
        uint elementsOfArray;
        do
        {
            Console.Write("Please enter the size of array: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out elementsOfArray));

        string[] unsorted = new string[elementsOfArray];

            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write("Please enter element[{0}] of array: ", i);
                unsorted[i] = Console.ReadLine();
            }
        
        int[] sizes = new int[unsorted.Length];

        SortByLength(unsorted, sizes);
        Console.Write("The sorted array is: ");
        foreach (string item in unsorted)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void SortByLength(string[] unsorted, int[] sizes)
    {
        for (int i = 0; i < unsorted.Length; i++)
        {
            sizes[i] = unsorted[i].Length;
        }
        // http://msdn.microsoft.com/en-us/library/aw9s5t8f.aspx
        // http://msdn.microsoft.com/en-us/library/85y6y2d3.aspx
        Array.Sort(sizes, unsorted);
        // Summary:
        //     Sorts a pair of one-dimensional System.Array objects (one contains the keys
        //     and the other contains the corresponding items) based on the keys in the
        //     first System.Array using the System.IComparable implementation of each key.
        //
        // Parameters:
        //   keys:
        //     The one-dimensional System.Array that contains the keys to sort.
        //
        //   items:
        //     The one-dimensional System.Array that contains the items that correspond
        //     to each of the keys in the keysSystem.Array.-or-null to sort only the keysSystem.Array.
    }
}