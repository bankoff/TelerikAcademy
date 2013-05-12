// Write an expression that checks if given positive integer 
// number n (n ≤ 100) is prime. E.g. 37 is prime.

// "A prime number (or a prime) is a natural number greater 
// than 1 that has no positive divisors other than 1 and itself."

using System;

class PrimeIntegers
{
    static void Main()
    {
        Console.WriteLine("Input integer fom 2 to 100 and then press Enter");
        int integer = int.Parse(Console.ReadLine());
        int divider = 2;
        int maxDivider = (int)Math.Sqrt(integer);
        bool prime = true;
        while (prime && (divider <= maxDivider))
        {
            if (integer % divider == 0)
            {
                prime = false;
                break;
            }

            divider++;
        }
        Console.WriteLine(prime == true ? "The number is prime." : "The number is not prime.");
    }
}

