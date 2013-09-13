using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TwoIsBetterThanOne
{
    static void Main()
    {
        FirstTask();
        SecondTask();
    }

    private static void SecondTask()
    {
        int[] numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
        int percent = int.Parse(Console.ReadLine());
        Array.Sort(numbers);

        int small = numbers.Length * percent / 100;
        if (percent == 0)
        {
            Console.WriteLine(numbers[0]);
        }
        else if ((numbers.Length * percent) % 100 == 0)
        {
            Console.WriteLine(numbers[small - 1]);
        }
        else
        {
            Console.WriteLine(numbers[small]);
        }
    }

    private static void FirstTask()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        ulong A = ulong.Parse(input[0]);
        ulong B = ulong.Parse(input[1]);
        ulong[] luckyNumbers = GenerateLuckyNumbers(B);
        int palindroms = GetPalindrom(A, B, luckyNumbers);
        Console.WriteLine(palindroms);
    }

    private static int GetPalindrom(ulong A, ulong B, ulong[] luckyNumbers)
    {
        int palindroms = 0;
        bool isPalindrom = true;

        for (int i = 0; i < luckyNumbers.Length; i++)
        {
            if (luckyNumbers[i] >= A && luckyNumbers[i] <= B)
            {
                string number = luckyNumbers[i].ToString();
                int len = number.Length;

                for (int j = 0; j < len / 2; j++)
                {
                    if (number[j] != number[len - 1 - j])
                    {
                        isPalindrom = false;
                    }
                }

                if (isPalindrom)
                {
                    palindroms++;
                }
                isPalindrom = true;
            }
        }
        return palindroms;
    }

    private static ulong[] GenerateLuckyNumbers(ulong B)
    {
        List<ulong> luckyNumbers = new List<ulong>();
        luckyNumbers.Add(3);
        luckyNumbers.Add(5);
        int i = 0;

        while (luckyNumbers[luckyNumbers.Count - 1] <= B)
        {
            luckyNumbers.Add(luckyNumbers[i] * 10 + 3);
            luckyNumbers.Add(luckyNumbers[i] * 10 + 5);
            i++;
        }

        return luckyNumbers.ToArray();
    }
}