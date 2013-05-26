// Write a program that calculates the greatest common divisor (GCD) 
// of given two numbers. Use the Euclidean algorithm 

using System;

class GCDEuclideanAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Input first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Input second number:");
        int secondNumber = int.Parse(Console.ReadLine());

        //http://en.wikipedia.org/wiki/Euclidean_algorithm

        while (firstNumber != 0 && secondNumber != 0)
        {
            if (firstNumber > secondNumber)
            {
                firstNumber -= secondNumber;
            }
            else
            {
                secondNumber -= firstNumber;
            }
        }
        Console.WriteLine("The greatest common divisor is: "+Math.Max(firstNumber, secondNumber));
    }
}
