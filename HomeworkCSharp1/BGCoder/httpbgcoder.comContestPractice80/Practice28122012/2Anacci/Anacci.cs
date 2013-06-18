using System;

class Anacci
{
    static void Main()
    {
        char first = char.Parse(Console.ReadLine());
        int firstNumber;
        char second = char.Parse(Console.ReadLine());
        int secondNumber;
        int lines = int.Parse(Console.ReadLine());
        char third;
        int thirdNumber;
        string space = "";

        Console.WriteLine(first);
        for (int i = 2; i <= lines; i++)
        {
            firstNumber = first - 64;
            secondNumber = second - 64;
            thirdNumber = (firstNumber + secondNumber) % 26;
            if (thirdNumber == 0)
            {
                third = 'Z';
            }
            else
            {
                third = (char)(thirdNumber + 64);
            }
            Console.WriteLine(second + space + third);
            space = space + " ";
            first = second;
            second = third;
            firstNumber = first - 64;
            secondNumber = second - 64;
            thirdNumber = (firstNumber + secondNumber) % 26;
            if (thirdNumber == 0)
            {
                third = 'Z';
            }
            else
            {
                third = (char)(thirdNumber + 64);
            }
            first = second;
            second = third;
        }

    }
}