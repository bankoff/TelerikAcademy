using System;

class TripleRotationofDigits
{
    static void Main()
    {
        string number = Console.ReadLine();
        string output;
        char lastSymbol;

        for (int i = 0; i < 3; i++)
        {
            output = "";
            lastSymbol = number[number.Length - 1];
            if (lastSymbol=='0')
            {
                for (int j = 0; j < number.Length-1; j++)
                {
                    output = output + number[j];
                }
            }
            else
            {
                output = lastSymbol + output;
                for (int j = 0; j < number.Length - 1; j++)
                {
                    output = output + number[j];
                }
            }
            number = output;
        }
        Console.WriteLine(number);
    }
}