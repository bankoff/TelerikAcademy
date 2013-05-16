// Write a program to print the first 100 members of the sequence of 
// Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;

class SequenceOfFibonacci
{
    static void Main()
    {
        BigInteger member1 = 0;
        BigInteger member2 = 1;
        for (int counter = 0; counter < 100; counter++)
        {
            Console.WriteLine(member1);
            BigInteger sum = member1 + member2;
            member1 = member2;
            member2 = sum;
        }
    }
}
