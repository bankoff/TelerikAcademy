//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".

using System;

class LastDigit
{
    //check last digit
    static string LastDigitName(int number)
    {
        if (number<0)
        {
            number = -number;
        }
        string digitName = string.Empty;
        switch (number % 10)
        {
            case 1: digitName = "one"; break;
            case 2: digitName = "two"; break;
            case 3: digitName = "three"; break;
            case 4: digitName = "four"; break;
            case 5: digitName = "five"; break;
            case 6: digitName = "six"; break;
            case 7: digitName = "seven"; break;
            case 8: digitName = "eight"; break;
            case 9: digitName = "nine"; break;
            case 0: digitName = "zero"; break;
            default:
                break;
        }
        return digitName;
    }

    static void Main()
    {
        int number;

        do
        {
            Console.Write("Please enter one integer: ");
        }
        while (!int.TryParse(Console.ReadLine(),out number));

        Console.WriteLine("Last digit of {0} is {1}",number,LastDigitName(number));
    }
}