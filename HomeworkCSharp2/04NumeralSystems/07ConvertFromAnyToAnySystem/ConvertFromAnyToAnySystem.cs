// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;

class ConvertAnyToAnySystem
{
    static void Main()
    {
        //convert the number 5357 to the base number 8 in base 16
        Console.WriteLine(BaseSToBaseD("5357", 8, 16));
        // 5357 = 5*8^3 + 3*8^2 + 5*8^1 + 7*8^0 = 5*512 + 3*64 + 5*8 +7*1 = 2799
        // AEF = 10*16^2 + 14*16^1 + 15*16^0 = 10*256 + 14*16 +15*1 = 2799
    }

    static char GetChar(int i)
    {
        if (i >= 10)
        {
            return (char)('A' + i - 10);
        }

        else
        {
            return (char)('0' + i);
        }
    }

    static int GetNumber(string numberToConvert, int position)
    {
        if (numberToConvert[position] >= 'A')
        {
            return numberToConvert[position] - 'A' + 10;
        }
        else
        {
            return numberToConvert[position] - '0';
        }
    }

    static string Base10ToBaseD(int decimalNumber, int baseD)
    {
        string result = String.Empty;

        for (; decimalNumber != 0; decimalNumber /= baseD)
        {
            result = GetChar(decimalNumber % baseD) + result;
        }

        return result;
    }

    static int BaseSToBase10(string numberToConvert, int baseS)
    {
        int decimalNumber = 0;

        for (int position = numberToConvert.Length - 1, power = 1; position >= 0; position--, power *= baseS)
        {
            decimalNumber += GetNumber(numberToConvert, position) * power;
        }

        return decimalNumber;
    }

    static string BaseSToBaseD(string result, int baseS, int baseD)
    {
        return Base10ToBaseD(BaseSToBase10(result, baseS), baseD);
    }
}