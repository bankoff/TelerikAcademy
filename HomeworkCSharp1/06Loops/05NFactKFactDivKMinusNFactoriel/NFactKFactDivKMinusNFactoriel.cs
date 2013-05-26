// Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class NFactKFactDivKMinusNFactoriel
{
    static void Main()
    {
        Console.WriteLine("This program calculates N!*K! / (K-N)!, where (1<N<K).");
        Console.WriteLine("Input N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Input K: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger result = 1;
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger kMinusNFactorial = 1;
        for (int i = 1; i <= k; i++)
        {
            kFactorial = kFactorial * i;
            if (i <= n)
            {
                nFactorial = nFactorial * i;
            }
            if (i <= (k - n))
            {
                kMinusNFactorial = kMinusNFactorial * i;
            }
        }
        result = nFactorial * kFactorial / kMinusNFactorial;
        Console.WriteLine("{0}!*{1}!/ ({1}-{0})! = {2}", n, k, result);
    }

    //{
    //    Console.WriteLine("This program calculates N!*K! / (K-N)!, where (1<N<K).");
    //    Console.WriteLine("Input N: ");
    //    int n = int.Parse(Console.ReadLine());
    //    Console.WriteLine("Input K: ");
    //    int k = int.Parse(Console.ReadLine());
    //    BigInteger result = 1;
    //    for (int i = 0; i < n; i++)
    //    {
    //        result = result * (i + 1) * (k - i);
    //    }
    //    Console.WriteLine("{0}!*{1}!/ ({1}-{0})! = {2}", n, k, result);
    //}
}
