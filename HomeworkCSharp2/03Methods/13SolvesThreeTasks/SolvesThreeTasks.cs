//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;

class SolvesThreeTasks
{
    static void Main()
    {
        Console.WriteLine("Please enter \n 1 to reverse digits in number,\n 2 to calculate average or\n 3 to solve linear equation:");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: ReverseDigitsOfDecimalNumber(); break;
            case 2: CalculateAverage(); break;
            case 3: SolveLinearEquation(); break;
            default: Console.WriteLine("Wrong input!, Press 1 or 2 or 3:"); break;
        }

    }
    static bool ValidateNumber(string decimalStr)
    {
        if (decimalStr[0] == '-')
        {
            return false;
        }
        return true;
    }
    static void ReverseDigitsOfDecimalNumber()
    {
        Console.Write("Please enter positive number:");
        string decimalStr = Console.ReadLine();
        while (ValidateNumber(decimalStr) == false)
        {
            Console.WriteLine("Please enter positive number!");
            decimalStr = Console.ReadLine();
        }

        char[] reverseDigits = decimalStr.ToCharArray();
        Console.Write("The reversed number is:");

        Array.Reverse(reverseDigits);

        for (int i = 0; i < reverseDigits.Length; i++)
        {
            Console.Write(reverseDigits[i]);
        }
        Console.WriteLine();
    }
    static int[] InputSequenceOfIntegers()
    {
        Console.WriteLine("Please enter how many integers will you enter:");
        int len = int.Parse(Console.ReadLine());
        while (len <= 0)
        {
            Console.WriteLine("Please enter positive integer for the length:");
            len = int.Parse(Console.ReadLine());
        }
        int[] sequence = new int[len];

        for (int i = 0; i < len; i++)
        {
            Console.Write("Please enter integer:");
            sequence[i] = int.Parse(Console.ReadLine());
        }

        return sequence;
    }
    static void CalculateAverage()
    {
        int[] sequence = InputSequenceOfIntegers();
        int sum = 0;
        double average = double.MinValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum = sum + sequence[i];
        }
        average = ((double)sum / sequence.Length);
        Console.WriteLine("The average of the numbers is:{0}", average);
    }
    static double ValidateQuoficientA(double coefficientA)
    {
        while (coefficientA == 0)
        {
            Console.WriteLine("Coefficient a should NOT be zero!");
            Console.Write("Please enter quoficient a:");
            coefficientA = double.Parse(Console.ReadLine());
        }
        return coefficientA;
    }
    static void SolveLinearEquation()
    {
        Console.Write("Please enter quoficient a:");
        double coefficientA = double.Parse(Console.ReadLine());
        ValidateQuoficientA(coefficientA);
        Console.Write("Please enter quoficientb:");
        double coefficientB = double.Parse(Console.ReadLine());
        double result = (double)-coefficientB / (double)coefficientA;
        Console.WriteLine("the result is:{0}", result);
    }
}