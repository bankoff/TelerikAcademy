/*  Write a program to calculate the Nth Catalan number by given N.
 */ 

using System;
using System.Numerics;

class NthCatalanNumber
{
    static void Main()
    {
        Console.WriteLine("This program calculates and prints Nth Catalan");
        Console.WriteLine("Input N: ");
        int number = int.Parse(Console.ReadLine());
        BigInteger cN;
        int n = 0;
        if (number == 1)
        {
            cN = 1;
        }
        else
        {
            n = number-1;                            // Nth Catalan number is C(N-1),because
            BigInteger twoNFactorial = 1;            // First Catalan nuber is C0=1
            BigInteger nPlusOneFactorial = 1;        // Second Catalan nuber is C1=1
            BigInteger nFactorial = 1;               // Third Catalan nuber is C2=2
            for (int j = 1; j <= (2 * n); j++)       // Fourth Catalan nuber is C3=5 etc.
            {
                twoNFactorial = twoNFactorial * j;
                if (j <= n)
                {
                    nFactorial = nFactorial * j;
                }
                if (j <= n + 1)
                {
                    nPlusOneFactorial = nPlusOneFactorial * j;
                }
            }
            cN = twoNFactorial / (nPlusOneFactorial * nFactorial);
        }
            Console.WriteLine("{0} Catalan Number is C{1} = {2}",number, n, cN);
        
    }
}




