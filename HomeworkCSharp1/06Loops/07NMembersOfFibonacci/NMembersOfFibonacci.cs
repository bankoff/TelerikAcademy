/* Write a program that reads a number N and calculates the sum 
 * of the first N members of the sequence of Fibonacci: 
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 */ 

using System;
using System.Numerics;

    class NMembersOfFibonacci
    {
        static void Main()
        {
            Console.WriteLine("Input N:");
            int n = int.Parse(Console.ReadLine());

            BigInteger member1 = 0;
            BigInteger member2 = 1;
            BigInteger sum = 0;
            for (int counter = 0; counter < n; counter++)
            {
                sum = sum + member1;
                BigInteger nextMember = member1 + member2;
                member1 = member2;
                member2 = nextMember;
            }
            Console.WriteLine("Sum of first N member of sequence of Fibonacci is \nSum: {0}",sum );
        }
    }