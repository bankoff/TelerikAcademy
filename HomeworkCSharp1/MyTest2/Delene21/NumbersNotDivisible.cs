using System;

class NumbersNotDivisible
{
    static void Main()
    {

        Console.WriteLine("Please enter a number N to print: ");

        int n = int.Parse(Console.ReadLine());

        while (n >= 1)
        {
            if (n % 3 != 0 || n % 7 != 0)
            {
                Console.WriteLine("Number : " + n);
            }
            n--;
        }
    }
}