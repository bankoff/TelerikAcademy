using System;

class UKFlag
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        char[,] matrix = new char[number, number];

        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                matrix[i, j] = '.';
            }
        }

        for (int i = 0; i < number; i++)
        {
            matrix[i, i] = '\\';
            matrix[i, number - i - 1] = '/';
            matrix[i, number / 2] = '|';
            matrix[number / 2, i] = '-';
        }

        matrix[number / 2, number / 2] = '*';

        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                Console.Write(matrix[i,j]);
            }
            Console.WriteLine();
        }
    }
}