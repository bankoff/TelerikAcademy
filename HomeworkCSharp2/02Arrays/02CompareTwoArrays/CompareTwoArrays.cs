// Write a program that reads two arrays from 
// the console and compares them element by element.

using System;

class CompareTwoArrays
{
    static void Main()
    {
        //declaring the arrays size and read arrays elements from the console
        uint sizeOfArray1;
        do
        {
            Console.Write("Please enter the size of first array: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out sizeOfArray1));

        string[] arrayOne = new string[sizeOfArray1];
        for (int i = 0; i < sizeOfArray1; i++)
        {
            Console.Write("Please enter {0} element for the first array: ", i + 1);
            arrayOne[i] = Console.ReadLine();
        }

        uint sizeOfArray2;
        do
        {
            Console.Write("Please enter the size of second array: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out sizeOfArray2));

        string[] arrayTwo = new string[sizeOfArray2];
        for (int i = 0; i < sizeOfArray2; i++)
        {
            Console.Write("Please enter {0} element for the second array: ", i + 1);
            arrayTwo[i] = Console.ReadLine();
        }

        //verifying the identity of the components of the arrays element by element
        int counter = 0;
        for (int i = 0; i < Math.Min(sizeOfArray1,sizeOfArray2); i++)
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
        if (sizeOfArray1 == sizeOfArray2 && sizeOfArray1 == counter)
        {
            Console.WriteLine("The arrays are the same");
        }
        else if(counter!=0)
        {
            Console.WriteLine("Both arrays have {0} identical elements, but arrays are different", counter);
        }
        else
        {
            Console.WriteLine("Both arrays do not have identical elements at the same position");
        }
    }
}