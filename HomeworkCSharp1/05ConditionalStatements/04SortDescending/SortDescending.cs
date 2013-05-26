// Sort 3 real values in descending order using nested if statements.

using System;

class SortDescending
{
    static void Main()
    {
        Console.WriteLine("Input first number:");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("Input second number:");
        float secondNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("Input third number:");
        float thirdNumber = float.Parse(Console.ReadLine());

        // Decision using nested if statements
        if (firstNumber >= secondNumber)
        {
            if (secondNumber >= thirdNumber)
            {
                Console.WriteLine("The numbers arranged in descending order:\n{0}, {1}, {2}",
                    firstNumber, secondNumber, thirdNumber);
            }
            else if (firstNumber >= thirdNumber)
            {
                Console.WriteLine("The numbers arranged in descending order:\n{0}, {1}, {2}",
                    firstNumber, thirdNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("The numbers arranged in descending order:\n{0}, {1}, {2}",
                    thirdNumber, firstNumber, secondNumber);
            }
        }
        else
        {
            if (firstNumber >= thirdNumber)
            {
                Console.WriteLine("The numbers arranged in descending order:\n{0}, {1}, {2}",
                    secondNumber, firstNumber, thirdNumber);
            }
            else if (secondNumber >= thirdNumber)
            {
                Console.WriteLine("The numbers arranged in descending order:\n{0}, {1}, {2}", 
                    secondNumber, thirdNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("The numbers arranged in descending order:\n{0}, {1}, {2}",
                    thirdNumber, secondNumber, firstNumber);
            }
        }


        // Decision using only if statements - this is easier.
        //float exchangeNumber;
        //if (firstNumber < secondNumber)
        //{
        //    exchangeNumber = firstNumber;
        //    firstNumber = secondNumber;
        //    secondNumber = exchangeNumber;
        //}
        //if (firstNumber < thirdNumber)
        //{
        //    exchangeNumber = firstNumber;
        //    firstNumber = thirdNumber;
        //    thirdNumber = exchangeNumber;
        //}
        //if (secondNumber < thirdNumber)
        //{
        //    exchangeNumber = secondNumber;
        //    secondNumber = thirdNumber;
        //    thirdNumber = exchangeNumber;
        //}

        //Console.WriteLine("The numbers arranged in descending order:\n{0}, {1}, {2}",
        //   firstNumber,secondNumber,thirdNumber);

    }
}
