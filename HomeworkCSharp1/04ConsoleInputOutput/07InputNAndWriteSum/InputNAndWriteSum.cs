// Write a program that gets a number n and after that gets 
// more n numbers and calculates and prints their sum. 

using System;

class InputNAndWriteSum
{
    static void Main()
    {
        Console.WriteLine("Input total number N for summing");
        Console.Write("n = ");
        string nStr = Console.ReadLine();
        int n = int.Parse(nStr);
        double sum = 0;
        for (int counter = 0; counter < n; counter++)
        {
            Console.WriteLine("Input number for summing");
            Console.Write("x = ");
            string xStr = Console.ReadLine();
            double x = double.Parse(xStr);
            sum = sum + x;
        }
        Console.WriteLine("Sum is: " + sum);
    }
}

