// Write a program that reads two arrays from 
// the console and compares them element by element.

using System;

class CompareTwoArrays
{
    static void Main()
    {
        //declaring the array size 
        uint sizeOfArrays;
        do
        {
            Console.Write("Please enter the size of arrays: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out sizeOfArrays));

        //read arrays elements from the console
        string[] arrayOne = new string[sizeOfArrays];
        string[] arrayTwo = new string[sizeOfArrays];
        for (int i = 0; i < sizeOfArrays; i++)
        {
            Console.Write("Please enter {0} element for the first array: ", i + 1);
            arrayOne[i] = Console.ReadLine();
        }
        for (int i = 0; i < sizeOfArrays; i++)
        {
            Console.Write("Please enter {0} element for the second array: ", i + 1);
            arrayTwo[i] = Console.ReadLine();
        }

        //verifying the identity of the components of the arrays element by element
        int counter = 0;
        for (int i = 0; i < sizeOfArrays; i++)
        {
            if (arrayOne[i]==arrayTwo[i])
            {
                Console.WriteLine("{0} element of arrays {1} and {2} is the same", i+1,arrayOne[i],arrayTwo[i]);
                counter++;
            }
            else
            {
                Console.WriteLine("{0} element of arrays {1} and {2} is different", i + 1,arrayOne[i],arrayTwo[i]);
            }
        }
        Console.WriteLine("Both arrays have {0} identical elements", counter);
    }
}