// Write a program that allocates array of 20 integers and initializes each 
// element by its index multiplied by 5. Print the obtained array on the console.

using System;

class ArrayOf20Integers
{
    static void Main()
    {
        //declaration of the array
        int sizeOfArray = 20;
        int[] arrayOfIntegers = new int[sizeOfArray];

        //generate values ​​of the array
        for (int i = 0; i < sizeOfArray; i++)
        {
            arrayOfIntegers[i] = i * 5;
        }

        //printing the array on the console
        for (int i = 0; i < sizeOfArray; i++)
        {
            Console.Write(arrayOfIntegers[i]+" ");
        }
        Console.WriteLine();
    }
}