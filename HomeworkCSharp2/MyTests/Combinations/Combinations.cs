using System;

class Combinations
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int K = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // make array from 1 to N
        int[] myArr = new int[N];
        for (int i = 0; i < N; i++)
        {
            myArr[i] = i + 1;
        }

        // print array
        Console.Write("The array is: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write(myArr[i] + " ");
        }
        Console.WriteLine();

        // all possible combinations
        int combinations = (int)(Math.Pow(2, N) - 1);

        // make combinations of K elements
        Console.WriteLine();
        Console.WriteLine("Generate all combinations of {0} distinct elements", K);
        for (int i = 1; i <= combinations; i++)
        {
            int counterOnes = 0;
            for (int j = 0; j < N; j++)
            {
                byte bit = (byte)(i >> j & 1);
                if (bit == 1)
                {
                    counterOnes++;
                }
            }

            if (counterOnes == K)
            {
                for (int j = 0; j < N; j++)
                {
                    byte bit = (byte)(i >> j & 1);
                    if (bit == 1)
                    {
                        Console.Write(myArr[j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}