// Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Text;

class BinaryToHexadecimal
{
    static void Main()
    {
        string binaryNumber = "1111101001";
        //string binaryNumber = "0100";
        StringBuilder binary = new StringBuilder();
        binary.Append(binaryNumber);
        int difference = 4 - (binaryNumber.Length % 4);
        while (difference > 0)
        {
            binary.Insert(0, 0);
            difference--;
        }

        Console.Write("The hex representation of {0} is:", binaryNumber);
        int lenOfSubstring = 4;

        for (int position = 0; position < binary.Length - 1; position = position + 4)
        {
            SubstringBinary(binary.ToString(), position, lenOfSubstring);
        }
        Console.WriteLine();
    }

    static void SubstringBinary(string binary, int position, int lenOfSubstring)
    {
        switch (binary.Substring(position, lenOfSubstring))
        {
            case "0000": Console.Write("0"); break;
            case "0001": Console.Write("1"); break;
            case "0010": Console.Write("2"); break;
            case "0011": Console.Write("3"); break;
            case "0100": Console.Write("4"); break;
            case "0101": Console.Write("5"); break;
            case "0110": Console.Write("6"); break;
            case "0111": Console.Write("7"); break;
            case "1000": Console.Write("8"); break;
            case "1001": Console.Write("9"); break;
            case "1010": Console.Write("A"); break;
            case "1011": Console.Write("B"); break;
            case "1100": Console.Write("C"); break;
            case "1101": Console.Write("D"); break;
            case "1110": Console.Write("E"); break;
            case "1111": Console.Write("F"); break;
        }
    }
}