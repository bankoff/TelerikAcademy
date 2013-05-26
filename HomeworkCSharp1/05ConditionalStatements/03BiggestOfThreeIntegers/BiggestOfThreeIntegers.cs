// Write a program that finds the biggest of three 
// integers using nested if statements.

using System;

class BiggestOfThreeIntegers
{
    static void Main()
    {
        Console.WriteLine("Input first integer:");
        int firstInteger = int.Parse(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int secondInteger = int.Parse(Console.ReadLine());
        Console.WriteLine("Input third integer:");
        int thirdInteger = int.Parse(Console.ReadLine());

        if (firstInteger >= secondInteger)
        {
            if (firstInteger >= thirdInteger)
            {
                Console.WriteLine("First integer {0} is the biggest.", firstInteger);
            }
            else
            {
                Console.WriteLine("Third integer {0} is the biggest.", thirdInteger);
            }
        }
        else
        {
            if (secondInteger >= thirdInteger)
            {
                Console.WriteLine("Second integer {0} is the biggest.", secondInteger);
            }
            else
            {
                Console.WriteLine("Third integer {0} is the biggest.", thirdInteger);
            }

        }
    }
}

