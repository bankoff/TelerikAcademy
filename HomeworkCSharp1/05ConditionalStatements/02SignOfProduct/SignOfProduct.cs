/* Write a program that shows the sign (+ or -) of the product 
 * of three real numbers without calculating it. Use a sequence 
 * of if statements.
 */

using System;

class SignOfProduct
{
    static void Main()
    {
        Console.WriteLine("Input first number:");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("Input second number:");
        float secondNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("Input third number:");
        float thirdNumber = float.Parse(Console.ReadLine());

        if (firstNumber==0 || secondNumber == 0 || thirdNumber ==0)
        {
            Console.WriteLine("The product is zero.");
        }

        else if ((firstNumber<0 && secondNumber<0 && thirdNumber<0) ||
            (firstNumber<0 && secondNumber>0 && thirdNumber>0) ||
            (firstNumber>0 && secondNumber<0 && thirdNumber>0) ||
            (firstNumber>0 && secondNumber>0 && thirdNumber<0))
        {
            Console.WriteLine("The product is negative.");
        }

        else
        {
            Console.WriteLine("The product is positive.");     
        }
    }
}
