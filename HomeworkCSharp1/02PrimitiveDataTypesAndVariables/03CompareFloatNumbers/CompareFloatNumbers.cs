// Write a program that safely compares floating-point numbers with precision of 0.000001. 
// Examples: (5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

using System;
using System.Threading;
using System.Globalization;

class CompareFloatNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Input first number and then press Enter");
        string firstValueStr = Console.ReadLine();
        decimal firstValue = decimal.Parse(firstValueStr);
        Console.WriteLine("Input second number and then press Enter");
        string secondValueStr = Console.ReadLine();
        decimal secondValue = decimal.Parse(secondValueStr);
        decimal value = Math.Abs(firstValue - secondValue);
        bool compare = (value <= 0.000001m);
        Console.WriteLine("({0} = {1}) with precision 0.000001 is {2}",
         firstValue, secondValue, compare);
    }
}