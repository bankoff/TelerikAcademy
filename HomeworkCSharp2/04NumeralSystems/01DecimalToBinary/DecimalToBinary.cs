// Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        int decimalNumber;
        do
        {
            Console.Write("Please enter number in decimal system to convert it to binary: ");
        }
        while (!int.TryParse(Console.ReadLine(), out decimalNumber));

        bool isPositive = true;

        if (decimalNumber < 0)
        {
            isPositive = false;
            decimalNumber = decimalNumber * -1;
        }

        int binaryNumber = 0;
        int currentDigit;
        while (decimalNumber > 0)
        {
            for (int position = 0; decimalNumber > 0; position++)
            {
                currentDigit = decimalNumber % 2; //gets digits in reversed order
                decimalNumber = decimalNumber / 2;
                binaryNumber = binaryNumber | (currentDigit << position);
            }
        }
        Console.Write("The binary number is: ");
        if (isPositive == true)
        {
            Console.WriteLine(Convert.ToString(binaryNumber, 2).PadLeft(32, '0'));
        }
        else
        {
            binaryNumber = ~(binaryNumber - 1);
            Console.WriteLine(Convert.ToString(binaryNumber, 2).PadLeft(32, '0'));
        }
    }
}