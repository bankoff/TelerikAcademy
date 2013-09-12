//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

using System;

class CheckBrackets
{
    static void Main()
    {
        //string correct = "((a+b)/5-d)";
        //string incorrect = ")(a+b))";
        Console.WriteLine("Please enter expression with brackets:");
        string expression = Console.ReadLine();
        int bracketsCount = 0;

        foreach (char item in expression)
        {
            if (item == '(')
            {
                bracketsCount++;
            }
            if (item == ')')
            {
                bracketsCount--;
            }
            if (bracketsCount < 0)
            {              
                break;
            }
        }

        if (bracketsCount==0)
        {
            Console.WriteLine("The brackets are put correctly.");
        }
        else
        {
            Console.WriteLine("The brackets are put incorrectly.");
        }
        
    }
}