/*  In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:           
 *                        Cn = (2*n)! / ((n+1)! * n!)   for n>=0
 */

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("This program calculates and prints Catalan numbers in range [0,n]");
        Console.WriteLine("Input n: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger cN = 1;
        Console.WriteLine();
        Console.WriteLine("C{0} = {1}", 0, cN);
        for (int firstCounter = 1; firstCounter <= n; firstCounter++)
        {

            BigInteger twoNFactorial = 1;
            BigInteger nPlusOneFactorial = 1;
            BigInteger nFactorial = 1;
            for (int secondCounter = 1; secondCounter <= (2 * firstCounter); secondCounter++)
            {
                twoNFactorial = twoNFactorial * secondCounter;
                if (secondCounter <= firstCounter)
                {
                    nFactorial = nFactorial * secondCounter;
                }
                if (secondCounter <= firstCounter + 1)
                {
                    nPlusOneFactorial = nPlusOneFactorial * secondCounter;
                }
            }
            cN = twoNFactorial / (nPlusOneFactorial * nFactorial);
            Console.WriteLine("C{0} = {1}", firstCounter, cN);
        }
    }
}

