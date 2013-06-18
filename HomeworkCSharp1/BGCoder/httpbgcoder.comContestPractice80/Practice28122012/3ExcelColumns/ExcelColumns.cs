using System;
using System.Numerics;

class ExcelColumns
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        char[] columnIdentifier = new char[lines];
        int columnNumber;
        BigInteger output = 0;
        BigInteger mnojitel = 1;

        for (int i = 0; i < columnIdentifier.Length; i++)
        {
            columnIdentifier[i] = char.Parse(Console.ReadLine());
        }

        for (int i = columnIdentifier.Length - 1; i >= 0; i--)
        {

            columnNumber = columnIdentifier[i] - 64;
            output = output + columnNumber * mnojitel;
            mnojitel = mnojitel * 26;

        }
        Console.WriteLine(output);
    }
}