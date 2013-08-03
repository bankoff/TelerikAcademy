//Write a method that reverses the digits of given decimal number. Example: 256 -> 652

using System;

class ReverseDigits
{
    static decimal ReverseNumber(decimal number)
    {
        decimal sign = 1;
        if (number<0)
        {
            sign = -1;
            number = -number;
        }
        string stringNumber = number.ToString();
        string stringReverseNumber = string.Empty;
        for (int i = stringNumber.Length-1; i >=0; i--)
        {
            stringReverseNumber = stringReverseNumber + stringNumber[i];
        }
        decimal reverseNumber = decimal.Parse(stringReverseNumber) * sign;
        return reverseNumber;
    }
    static void Main()
    {
        decimal number;
        do
        {
            Console.Write("Please enter given decimal number: ");
        }
        while (!decimal.TryParse(Console.ReadLine(), out number));

        Console.WriteLine("The reversed number is: {0}", ReverseNumber(number));
    }
}