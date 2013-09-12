//Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
//percentage and in scientific notation. Format the output aligned right in 15 symbols.

using System;

class PrintNumberFourWays
{
    static void Main()
    {
        string input;
        int number;

        do
        {
            Console.Write("Please enter valid integer number: ");
            input = Console.ReadLine();
        } while (!int.TryParse(input, out number));

        Console.WriteLine("Decimal {0,15:D}", number);
        Console.WriteLine("Hexadec {0,15:X}", number);
        Console.WriteLine("Percentage{0,15:P}", number);
        Console.WriteLine("Scientific{0,15:E}", number);
    }
}