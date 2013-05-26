/* Write an if statement that examines two integer variables 
 * and exchanges their values if the first one is greater 
 * than the second one.
 */

using System;

class ExchangeValues
{
    static void Main()
    {
        Console.WriteLine("Input first integer:");
        int firstInteger = int.Parse(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int secondInteger = int.Parse(Console.ReadLine());

        if (firstInteger>secondInteger)
        {
            int exchange = firstInteger;
            firstInteger = secondInteger;
            secondInteger = exchange;
        }

        Console.WriteLine("First integer = {0} and second integer = {1},\nbecause {0} <= {1}", 
            firstInteger, secondInteger );
    }
}
