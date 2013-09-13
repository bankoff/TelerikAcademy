using System;

class KaspichanNumbers
{
    static string[] GenerateDigits(int digits)
    {
        int count = 0;
        string[] kaspichanDigit = new string[digits];

        for (char k = 'A'; k <= 'Z'; k++)
        {
            kaspichanDigit[count] = k.ToString();
            count++;
        }

        for (char j = 'a'; j <= 'i'; j++)
        {
            for (char k = 'A'; k <= 'Z'; k++)
            {
                kaspichanDigit[count] = j.ToString() + k.ToString();               
                count++;
                if (count == digits) break;
            }
        }
        return kaspichanDigit;
    }

    static void Main()
    {
        string[] kaspichanDigit = new string[256];
        kaspichanDigit = GenerateDigits(256);
        ulong number = ulong.Parse(Console.ReadLine());
        string result = string.Empty;
        while (number>0)
        {
            result = kaspichanDigit[number % 256] + result;
            number = number / 256;
        }
        if (result == string.Empty)
        {
            Console.WriteLine("A");
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}