// Write an expression that checks for given integer if its third digit (right-to-left) is 7. 
// E. g. 1732 -> true.

using System;

class CheckDigit
{
    static void Main()
    {
        Console.WriteLine("Input integer with three or more digits");
        string numberStr = Console.ReadLine();
        int number = int.Parse(numberStr);
        int digits = numberStr.Length;
        char digit = numberStr[digits - 3];
        bool isSeven = (digit == '7');
        Console.WriteLine("Third digit (right-to-left) of {0} is {1}. \nThe third digit is 7 --> {2}", number, digit,isSeven);
    }

    // Second solution
    //{ 
    //    Console.WriteLine("Input integer with three or more digits");
    //    string numberStr = Console.ReadLine();
    //    int number = int.Parse(numberStr);
    //    int assistNumber = number / 100;
    //    int digit = assistNumber % 10;
    //    Console.WriteLine("Third digit (right-to-left) of {0} is {1}", number, digit);
    //}
}