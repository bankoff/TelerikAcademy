using System;

class TelerikLogo
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int matrixSize = number + (2 * (number - 1));
        char[,] matrix = new char[matrixSize, matrixSize];
        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                matrix[i, j] = '.';
            }
        }

        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                if ((i + j) == (number / 2))
                {
                    matrix[i, j] = '*';
                    matrix[i, matrixSize - j - 1] = '*';
                }
                if ((j == i + number / 2) && (i < 2 * number - 1))
                {
                    matrix[i, j] = '*';
                    matrix[i, matrixSize - j - 1] = '*';
                }
                if ((i >= 2 * number - 1) && (j == i + number / 2 - 2 * number + 2))
                {
                    matrix[i, j] = '*';
                    matrix[i, matrixSize - j - 1] = '*';
                }
            }
        }

        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }

    }
}