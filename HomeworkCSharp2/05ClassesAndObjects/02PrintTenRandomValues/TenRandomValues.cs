//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class TenRandomValues
{
    static void Main()
    {
        Random randomNumber = new Random();
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Number {0,2} is: {1}",i, randomNumber.Next(100, 201));
        }
    }
}