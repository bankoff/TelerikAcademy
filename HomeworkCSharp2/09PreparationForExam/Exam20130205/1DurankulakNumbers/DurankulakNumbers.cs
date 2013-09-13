using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DurankulakNumbers
{
    static string[] FillArray(int count)
    {
        string[] digits = new string[count];
        int k = 0;

        for (char i = 'A'; i <= 'Z'; i++)
        {
            digits[k] = i.ToString();
            k++;
        }

        for (char j = 'a'; j <= 'z'; j++)
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                digits[k] = j.ToString() + i.ToString();
                k++;
                if (k >= count)
                {
                    return digits;
                }
            }
        }
        return digits;
    }

    static void Main()
    {
        int count = 168;
        string[] digits = new string[count];

        digits = FillArray(count);

        string durankulakNumber = Console.ReadLine();
        durankulakNumber.Trim();

        string sign = string.Empty;
        int startDigit = 0;

        if (durankulakNumber[0] == '-')
        {
            sign = "-";
            startDigit = 1;
        }

        List<ulong> durankulakToInt = new List<ulong>();
        string durankulakDigit = string.Empty;

        for (int i = startDigit; i < durankulakNumber.Length; i++)
        {
            if (!(durankulakNumber[i] == ' '))
            {
                durankulakDigit = durankulakDigit + durankulakNumber[i].ToString();
                if (digits.Contains(durankulakDigit))
                {
                    int digit = Array.IndexOf(digits, durankulakDigit);
                    durankulakToInt.Add((ulong)digit);
                    durankulakDigit = string.Empty;
                }
            }
        }

        ulong result = 0;
        ulong power = 1;
        for (int i = durankulakToInt.Count - 1; i >= 0; i--)
        {
            result = result + durankulakToInt[i] * power;
            power = power * (ulong)count;
        }

        Console.WriteLine(sign + result);
    }
}