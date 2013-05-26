// Write a program that prints all the numbers from 1 to N, 
// that are not divisible by 3 and 7 at the same time.


using System;

class NumbersToNWithoutDiv21
{
    static void Main()
    {
        Console.WriteLine("Input number N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers from 1 to N not divisible by 3 and 7 at the same time are: ");
        for (int i = 1; i <= n; i++)
        {
            if ((i % 3 != 0) || (i % 7 != 0))
            {
                Console.Write("{0} ", i);
            }
        }
    }
}

