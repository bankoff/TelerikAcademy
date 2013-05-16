// Write a program to calculate the sum (with accuracy 
// of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class SumAccuracyDot001
{
    static void Main()
    {
        decimal counter = 2m;
        decimal sum = 1m;
        int sign = 1;
        while (1m / counter > 0.001m)
        {
            sum = sum + (1m / counter) * sign;
            sign = sign * (-1);
            counter++;
        }
        Console.WriteLine("sum = {0:0.000}", sum);
    }
}