// Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class ExchangeValues
{
    static void Main()
    {
        int firstVariable, secondVariable, assistentVariable;
        firstVariable = 5;
        secondVariable = 10;
        Console.WriteLine("First number is {0} and second is {1}", firstVariable, secondVariable);
        assistentVariable = firstVariable;
        firstVariable = secondVariable;
        secondVariable = assistentVariable;
        Console.WriteLine("After exchange first number is {0} and second is {1}", firstVariable, secondVariable);
    }
}
