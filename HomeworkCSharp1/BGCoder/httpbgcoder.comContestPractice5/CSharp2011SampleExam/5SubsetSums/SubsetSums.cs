using System;

class SubsetSums
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        int n = byte.Parse(Console.ReadLine());
        long[] number = new long[n];
        long checkingSum;
        int result = 0;
        for (int i = 0; i < n; i++)
        {
            number[i] = long.Parse(Console.ReadLine());
        }

        for (int i = 1; i < Math.Pow(2, n); i++)
        {
            checkingSum = 0;

            for (int j = 0; j < n; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    checkingSum = checkingSum + number[j];
                }
            }
            if (s == checkingSum)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}
