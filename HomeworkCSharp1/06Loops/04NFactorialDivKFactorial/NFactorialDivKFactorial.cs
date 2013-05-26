// Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class NFactorialDivKFactorial
{
    static void Main()
    {
        Console.WriteLine("This program calculates N!/K!, where (1<K<N).");
        Console.WriteLine("Input N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Input K: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger result = 1;
        for (int i = k + 1; i <= n; i++)         // because N!/K! = (1*2*3*...*K*(K+1)*(k+2)*...*N)/(1*2*3*...*k)=
        {                                        //                             =(k+1)*(K+2)*...*N 
            result = result * i;                 // members of 1 to K are duplicated
        }
        Console.WriteLine("{0}!/ {1}! = {2}", n, k, result);
    }
}
