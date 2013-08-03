// Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    static void Main()
    {
        int decimalNumber;
        do
        {
            Console.Write("Please enter number in decimal system to convert it to hexadecimal: ");
        }
        while (!int.TryParse(Console.ReadLine(), out decimalNumber));

        List<int> hexadecimalList = new List<int>();
        int digit = 0;
        while (decimalNumber > 0)
        {
            digit = (char)(decimalNumber % 16);
            decimalNumber = decimalNumber / 16;
            hexadecimalList.Add(digit);
        }
        Console.Write("Your hexadecimal number is: ");
        for (int i = hexadecimalList.Count - 1; i >= 0; i--)
        {
            if (hexadecimalList[i] > 9)
            {
                switch (hexadecimalList[i])
                {
                    case 10: Console.Write('A'); break;
                    case 11: Console.Write('B'); break;
                    case 12: Console.Write('C'); break;
                    case 13: Console.Write('D'); break;
                    case 14: Console.Write('E'); break;
                    case 15: Console.Write('F'); break;
                }
            }
            else
            {
                Console.Write(hexadecimalList[i]);
            }
        }
        Console.WriteLine();
    }
}