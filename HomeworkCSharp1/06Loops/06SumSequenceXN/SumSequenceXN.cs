// Write a program that, for a given two integer numbers N and X, 
// calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

    class SumSequenceXN
    {
        static void Main()
        {
            Console.WriteLine("This program calculates sum S = 1 + 1!/X + 2!/X2 + … + N!/XN");
            Console.WriteLine("Input N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input X: ");
            int x = int.Parse(Console.ReadLine());
            decimal sum = 1m;
            int nFactorial=1;
            int xExponent =1;
            for (int i = 1; i <= n; i++)
            {
                nFactorial = nFactorial * i;
                xExponent = xExponent * x;
                sum = sum + nFactorial / xExponent;
            }
            Console.WriteLine("Sum S = {0}",sum);
        }
    }
