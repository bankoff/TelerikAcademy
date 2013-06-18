using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n+1; i++)
            if (i==1)
            {
                for (int k1 = 0; k1 < n; k1++)
                {
                    Console.Write('.');
                }
                for (int k2 = 0; k2 < n; k2++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            else if (i==n+1)
            {
                for (int k3 = 0; k3 < 2*n; k3++)
                {
                    Console.Write('*');
                }
            }
            else
            {
                for (int k4 = 1; k4 <= n-i+1; k4++)
                {
                    Console.Write('.');
                }
                Console.Write('*');
                for (int k5 = n-i+3; k5 <= 2*n-1; k5++)
                {
                    Console.Write('.');
                }
                Console.Write('*');
                Console.WriteLine();
            }
        {
            
        }
        Console.WriteLine();
    }
}
