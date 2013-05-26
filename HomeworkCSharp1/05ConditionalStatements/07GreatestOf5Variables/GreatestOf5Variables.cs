// Write a program that finds the greatest of given 5 variables.

using System;

    class GreatestOf5Variables
    {
        static void Main()
        {
            Console.WriteLine("Input first number:");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Input second number:");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Input third number:");
            float thirdNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Input second number:");
            float fourthNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Input third number:");
            float fifthNumber = float.Parse(Console.ReadLine());
            float greatestNumber = firstNumber;
            if (greatestNumber<secondNumber)
            {
                greatestNumber = secondNumber;
            }
            if (greatestNumber < thirdNumber)
            {
                greatestNumber = thirdNumber;
            }
            if (greatestNumber < fourthNumber)
            {
                greatestNumber = fourthNumber;
            }
            if (greatestNumber < fifthNumber)
            {
                greatestNumber = fifthNumber;
            }
            Console.WriteLine("The greatest of this 5 variables is: {0}",greatestNumber);
        }
    }

