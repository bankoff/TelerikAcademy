using System;
using System.Threading;
using System.Globalization;

class Fire
{
    static void Main()
    {
        checked
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int number = int.Parse(Console.ReadLine());
            char[,] matrix1 = new char[number / 2, number];
            char[] matrix3 = new char[number];
            char[,] matrix4 = new char[number / 2, number];

            for (int i = 0; i < number / 2; i++)
            {
                for (int j = 0; j < number / 2; j++)
                {

                    if (i + j == number / 2 - 1)
                    {
                        matrix1[i, j] = '#';
                    }
                    else
                    {
                        matrix1[i, j] = '.';
                    }
                    matrix4[i, j] = '.';
                    matrix4[i, j + number / 2] = '.';
                }
            }

            for (int i = 0; i < number / 2; i++)
            {
                for (int j = number / 2; j < number; j++)
                {
                    matrix1[i, j] = matrix1[i, number - j - 1];
                }
            }

            for (int i = 0; i < number / 2; i++)
            {
                for (int j = i; j < number / 2; j++)
                {
                    matrix4[i, j] = '\\';
                    matrix4[i, number - j - 1] = '/';
                }
            }

            for (int i = 0; i < number / 2; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(matrix1[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = number / 2 - 1; i >= number / 4; i--)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(matrix1[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < number; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            for (int i = 0; i < number / 2; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(matrix4[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}