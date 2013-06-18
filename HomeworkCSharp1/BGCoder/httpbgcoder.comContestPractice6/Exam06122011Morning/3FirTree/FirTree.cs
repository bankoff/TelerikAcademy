using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int variableN = n;
        
        for (int row = 0; row < n-1; row++)
        {


            for (int i = 0; i < variableN - 2-row; i++)
            {
                Console.Write('.');
            }
            for (int i = 0; i < (2 * row + 1); i++)
            {
                Console.Write('*');
            }
            for (int i = 0; i < variableN - 2-row; i++)
            {
                Console.Write('.');
            }

            Console.WriteLine();
        }

        for (int i = 0; i < variableN - 2; i++)
        {
            Console.Write('.');
        }

            Console.Write('*');

        for (int i = 0; i < variableN - 2; i++)
        {
            Console.Write('.');
        }
        Console.WriteLine();
    }
}