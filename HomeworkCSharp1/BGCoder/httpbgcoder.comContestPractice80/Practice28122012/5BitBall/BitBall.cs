using System;

class BitBall
{
    static void Main()
    {
        int n = 8;
        int[,] matrix = new int[n, n];
        int number;

        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = (number >> j) & 1;
            }
        }

        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                int bit = (number >> j) & 1;
                if ((matrix[i, j] == 1) & (bit == 1))
                {
                    matrix[i, j] = 0;
                }
                else if (bit == 1)
                {
                    matrix[i, j] = 2;
                }
            }
        }


        int bottom = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[j, i] == 1)
                {
                    break;
                }
                if (matrix[j, i] == 2)
                {
                    bottom++;
                    break;
                }
            }
        }

        int top = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                if (matrix[j, i] == 2)
                {
                    break;
                }
                if (matrix[j, i] == 1)
                {
                    top++;
                    break;
                }
            }
        }

        Console.WriteLine("{0}:{1}", top, bottom);


    }
}