//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.

using System;

class FrequencyNumber
{
    static void Main()
    {
        //read input data from console
        uint sizeOfArray;
        do
        {
            Console.Write("Please enter size of array: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out sizeOfArray));

        double[] testArray = new double[sizeOfArray];
        for (int i = 0; i < testArray.Length; i++)
        {
            do
            {
                Console.Write("Please enter element {0} of array: ", i);
            }
            while (!double.TryParse(Console.ReadLine(), out testArray[i]));
        }

        double givenNumber;
        do
        {
            Console.Write("Please enter given number: ");
        }
        while (!double.TryParse(Console.ReadLine(), out givenNumber));

        Console.WriteLine("The number {0} occurs {1} time/s in the array.",givenNumber,FrequencyCount(testArray,givenNumber));
    }

    static int FrequencyCount(double[] array,double givenNumber)
    {
        int frequencyCount =0;
        for (int i = 0; i < array.Length ; i++)
			{
                if (array[i]==givenNumber)
                {
                    frequencyCount++;
                }
			}
        return frequencyCount;
    }
}