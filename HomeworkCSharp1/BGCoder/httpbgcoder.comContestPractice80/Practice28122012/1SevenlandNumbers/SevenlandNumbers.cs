using System;

class SevenlandNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        string output = "";

        bool flagZero = false;
        bool flagOne = false;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if ((input[i] == '6')&&!flagZero)
            {
                output = "0" + output;    
            }
            else if (!flagZero)
            {
                output = (input[i]-47).ToString() + output;
                flagZero = true;
                flagOne = true;
            }
            else
            {
                output = input[i] + output;
                flagOne = true;
            }
        }
        if (flagOne)
        {
            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine("1" + output);
        }
    }
}