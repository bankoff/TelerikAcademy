// * Write a program that sorts an array of integers using 
// the merge sort algorithm (find it in Wikipedia).

using System;

class MergeSortAlgorithm
{
    static void Main()
    {
        //reading the input data from the console
        uint arraySize;
        do
        {
            Console.Write("Please enter the size of array: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out arraySize));

        int[] array = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            do
            {
                Console.Write("Please enter element {0} of array: ", i+1);
            }
            while (!int.TryParse(Console.ReadLine(), out array[i]));
        }

        // secondaryArray - help array            
        // currentLength - length of the subarray that will be sorted. 
        // currentPosition - current position - it starts from zero element
        int[] secondaryArray = new int[arraySize];
        int currentLength = 1;           
        int currentPosition = 0;

        //two counters which determine how many elements have been sorted from the first subarray or the second subarray            
        int firstSubArrayPosition = 0;
        int secondSubArrayPosition = 0;

        // merge sort algorithm 
        while (currentLength <= arraySize)
        {             
            for (int i = 0; i < arraySize; i = i + currentLength * 2)
            {
                while (currentPosition < arraySize)
                {                      
                    if (firstSubArrayPosition < currentLength && secondSubArrayPosition < currentLength && i + secondSubArrayPosition + currentLength < arraySize)
                    {                           
                        if (array[i + firstSubArrayPosition] <= array[i + secondSubArrayPosition + currentLength])
                        {
                            secondaryArray[currentPosition] = array[i + firstSubArrayPosition];
                            firstSubArrayPosition++;
                        }
                        else
                        {
                            secondaryArray[currentPosition] = array[i + secondSubArrayPosition + currentLength];
                            secondSubArrayPosition++;
                        }
                    }                      
                    else if (firstSubArrayPosition < currentLength)
                    {
                        secondaryArray[currentPosition] = array[i + firstSubArrayPosition];
                        firstSubArrayPosition++;
                    }                       
                    else if (secondSubArrayPosition < currentLength)
                    {
                        secondaryArray[currentPosition] = array[i + secondSubArrayPosition + currentLength];
                        secondSubArrayPosition++;
                    }        
                    else
                    {
                        break;
                    }
                    currentPosition++;
                }                 
                secondSubArrayPosition = 0;
                firstSubArrayPosition = 0;
            }
              
            currentLength = currentLength * 2;                
            currentPosition = 0;
                
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = secondaryArray[i];
            }
        }

         // print sorted array 
        Console.WriteLine("The sorted array is:   ");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("{0}  ", array[i]);
        }
        Console.WriteLine();
    }
}