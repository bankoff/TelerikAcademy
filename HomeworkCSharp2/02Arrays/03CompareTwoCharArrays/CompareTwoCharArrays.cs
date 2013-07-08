// Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        {
            Console.WriteLine("Please enter the first char elements:");
            string firstChars = Console.ReadLine();

            //convert string to first char array and conversion letter to upper
            char[] firstArray = firstChars.ToUpper().ToCharArray(); 
           
            Console.WriteLine("Please enter the second char elements:");
            string secondChars = Console.ReadLine();

            //convert string to second char array and conversion letter to upper
            char[] secondArray = secondChars.ToUpper().ToCharArray();

            //gets min length of the two arrays
            int minLenght = Math.Min(secondArray.Length, firstArray.Length);

            // a kind of flag, helps to print the correct output
            bool equalCharArrays = true;  

            for (int i = 0; i < minLenght; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    equalCharArrays = false;
                    if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine("The first char array is lexicografically before the second.");
                    }
                    else
                    {
                        Console.WriteLine("The second char array is lexicografically before the first.");
                    }
                    break;
                }
            }
            if (equalCharArrays == true && firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("The first char array is lexicografically before the second.");
            }
            else if (equalCharArrays == true && firstArray.Length > secondArray.Length)
            {
                Console.WriteLine("The second char array is lexicografically before the first.");
            }
            else if (equalCharArrays == true && firstArray.Length == secondArray.Length)
            {
                Console.WriteLine("The arrays are equal.");
            }
        }
    }
}