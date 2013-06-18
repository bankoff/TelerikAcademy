using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                if (k == i)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }

        for (int i = n-2; i >= 0; i--)
        {
            for (int k = 0; k < n; k++)
            {
                if (k == i)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }

    }
}