// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
// Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

class combinationsKElementsN
{
    static void Main()
    {
        //reading the input data from the console
        uint numberN;
        do
        {
            Console.Write("Please enter the number N: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out numberN));
        uint numberK;
        do
        {
            Console.Write("Please enter the elements K: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out numberK));

        if (numberK < 1)
        {
            Console.WriteLine("This combination is imposible");
        }
        else
        {
            // calculating the number of all combinations http://www.kombinatoruka.hit.bg/__7.html
            for (uint i = 0; i < Math.Pow(numberN, numberK); i++)
            {
                uint conv = i;
                uint[] array = new uint[numberK];
                bool print = true;

                //convert from decimal to n-number system
                for (uint j = 0; j < numberK; j++)
                {
                    array[numberK - j - 1] = conv % numberN;     
                    conv = conv / numberN;
                }

                //checking for the printing of the combination
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j]<=array[j-1])
                    {
                        print = false;  
                    }
                }

                // print result
                if (print)
                {
                    Console.Write("{0}{1}", '{', array[0] + 1);
                    for (uint j = 1; j < numberK; j++)
                    {
                        Console.Write(", {0}", array[j] + 1);
                    }
                    Console.WriteLine("}");
                }
            }
        }
    }
}