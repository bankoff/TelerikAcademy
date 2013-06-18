using System;

class OddNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] number = new long[n];
        long nXor;
        for (int i = 0; i < n; i++)
        {
            number[i] = long.Parse(Console.ReadLine());   
        }
        nXor = number[0];
        for (int i = 1; i < n; i++)
        {
                nXor = nXor ^ number[i];
        }
        Console.WriteLine(nXor);
    }
}
