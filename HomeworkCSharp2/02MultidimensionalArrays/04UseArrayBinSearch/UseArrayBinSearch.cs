// Write a program, that reads from the console an array of N integers 
// and an integer K, sorts the array and using the method Array.BinSearch() 
// finds the largest number in the array which is ≤ K. 

using System;

class UseArrayBinSearch
{
    static void Main()
    {
        //read the array size 
        uint sizeOfArrayN;
        do
        {
            Console.Write("Please enter the size of array: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out sizeOfArrayN) || sizeOfArrayN < 1);

        // read number K
        int k;
        do
        {
            Console.Write("Please enter the K:");
        }
        while (!int.TryParse(Console.ReadLine(), out k));

        //read array elements from the console
        int[] arrayOfIntegers = new int[sizeOfArrayN];
        for (int i = 0; i < sizeOfArrayN; i++)
        {
            do
            {
                Console.Write("Please enter element {0} of array: ", i + 1);
            }
            while (!int.TryParse(Console.ReadLine(), out arrayOfIntegers[i]));
        }

        Array.Sort(arrayOfIntegers);

        int positionK = Array.BinarySearch(arrayOfIntegers, k);
        //If the Array does not contain the specified value, the method returns a negative integer. 
        //You can apply the bitwise complement operator (~) to the negative result to produce an index. 
        //If this index is greater than or equal to the size of the array, there are no elements larger 
        //than value in the array. Otherwise, it is the index of the first element that is larger than value.
        // http://stackoverflow.com/questions/11436152/array-binarysearch-return-value

        if (positionK < 0)     
            //k does not exist in the array
        {
            if (arrayOfIntegers[0] > k) 
                //smallest number is bigger than k
            {
                Console.WriteLine("The element smaller or equal to k was not found in the array.");
            }
            else
            {
                Console.WriteLine("The largest number, <= k, is {0}", arrayOfIntegers[~positionK - 1]);
            }
        }
        else if (positionK >= 0)
        {
            Console.WriteLine("The largest number, <= k, is {0}", arrayOfIntegers[positionK]);
        }
    }
}