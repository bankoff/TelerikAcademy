using System;

class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        double result, result1, result2, result3;
        result1 = n * n + 1 / (m * p) + 1337;
        result2 = n - 128.523123123 * p;

        int intM = (int)m;

        result3 = Math.Sin(intM % 180);

        result = result1 / result2 + result3;
        Console.WriteLine("{0:F6}",result);
    }
}
