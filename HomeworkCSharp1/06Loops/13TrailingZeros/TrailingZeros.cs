/*  Write a program that calculates for given N how many trailing zeros present at the end of the number N!. 
 *  Examples:
 *  N = 10 -> N! = 3628800 -> 2
 *  N = 20 -> N! = 2432902008176640000 -> 4
 *  Does your program work for N = 50 000?
 *  Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!
 */



using System;
using System.Numerics;

    class TrailingZeros
    {
        static void Main()
        {
            Console.WriteLine("Input N:");
            int number = int.Parse(Console.ReadLine());
            int zeroCounter = 0;
            BigInteger nFactorial = 1;
            int divider = 5;

            // calculating N!
            for (int i = 1; i <= number; i++)
            {
                nFactorial = nFactorial * i;
            }

            //calculating zeros
            while (divider <= number)
            {
                zeroCounter = zeroCounter + (number / divider);
                divider = divider * 5;
            }
            
            Console.WriteLine("N = {0} -> N! = {1} -> {2}",number,nFactorial,zeroCounter);
        }
    }

