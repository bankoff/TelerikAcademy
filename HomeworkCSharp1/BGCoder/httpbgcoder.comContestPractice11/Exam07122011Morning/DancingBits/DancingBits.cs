using System;

class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] number = new int[n];

        for (int i = 0; i < number.Length; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }

        string concatenation = "";
        for (int i = 0; i < number.Length; i++)
        {
            int zeroOrOne;
            bool nextDigit = false;
            for (int j = 31; j >= 0; j--)
            {
                zeroOrOne = (number[i] >> j) & 1;
                if (zeroOrOne == 1 || nextDigit)
                {
                    concatenation = concatenation + zeroOrOne.ToString();
                    nextDigit = true;
                }
            }
        }

        concatenation = concatenation + "*";

        int dancingBits = 0;
        char symbol = '1';
        int counter = 0;
        for (int i = 0; i < concatenation.Length; i++)
        {

            if (symbol == concatenation[i])
            {
                counter++;
            }
            else
            {
                if (counter == k)
                {
                    dancingBits++;
                }
                symbol = concatenation[i];
                counter = 1;
            }
        }
        Console.WriteLine(dancingBits);
    }
}