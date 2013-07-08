using System;
using System.Collections.Generic;

class RemoveMinNumberElements
{
    static void Main()
    {
        //reading the input data from the console
        uint sizeOfArray;
        do
        {
            Console.Write("Please enter the size of array: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out sizeOfArray));

        int[] array = new int[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            do
            {
                Console.Write("Please enter element {0} of array: ", i + 1);
            }
            while (!int.TryParse(Console.ReadLine(), out array[i]));
        }
        
        //count - this is all combinations of elements in array
        int count = (int)Math.Pow(2, array.Length);

        int maxCounterOfTakenElements = 0;
        List<int> checker = new List<int>();
        List<int> result = new List<int>();

        for (int i = 1; i < count; i++)
        {
            bool isSorted = true;
            checker.Clear();
            for (int j = 0; j < array.Length; j++)
            {
                //checks if we take the number
                if ((i >> j & 1) == 1) 
                {
                    // add to list checker element j of array
                    checker.Add(array[j]); 
                }
            }

            //checks if the list checker is sorted
            for (int k = 0; k < checker.Count; k++) 
            {
                if (k != 0 && k == checker.Count - 1 && checker[k] < checker[k - 1])
                {
                    isSorted = false;
                    break;
                }
                if (k != checker.Count - 1 && checker[k] > checker[k + 1])
                {
                    isSorted = false;
                    break;
                }
            }

            //checks if current sequence is bigger than the best so far.
            if (isSorted == true && maxCounterOfTakenElements < checker.Count) 
            {
                maxCounterOfTakenElements = checker.Count;
                result.Clear();
                result.AddRange(checker);
            }
        }

        if (result.Count == 0)//printing
        {
            Console.WriteLine("There is no such subset.");
            return;
        }
        for (int m = 0; m < result.Count; m++)//prints the list result
        {
            if (m == 0&& result.Count==1)
            {
                Console.WriteLine("{" + result[m] + "}");
            }
            else if (m == 0)
            {
                Console.Write("{" + result[m] + ", "); 
            }
            else if (m == result.Count - 1)
            {
                Console.WriteLine(result[m]+"}");
            }
            else
            {
                Console.Write(result[m] + ", ");
            }
        }
    }
}

