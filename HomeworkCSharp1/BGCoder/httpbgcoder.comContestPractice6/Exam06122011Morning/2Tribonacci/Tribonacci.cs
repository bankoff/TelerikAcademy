using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger[] number = new BigInteger[n];
        switch (n)
        {
            case 1:
                {
                    Console.WriteLine(first);
                    break;
                }
            case 2:
                {
                    Console.WriteLine(second);
                    break;
                }
            case 3:
                {
                    Console.WriteLine(third);
                    break;
                }
            default:
                {
                    number[0] = first;
                    number[1] = second;
                    number[2] = third;
                    for (int i = 3; i < number.Length; i++)
                    {
                        number[i] = number[i - 3] + number[i - 2] + number[i - 1];
                    }
                    Console.WriteLine(number[n - 1]);
                    break;
                }
        }

    }
}