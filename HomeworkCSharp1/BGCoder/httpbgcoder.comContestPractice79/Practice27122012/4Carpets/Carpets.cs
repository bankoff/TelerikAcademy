using System;

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] matrix = new char[n, n];

        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                if (j < (n / 2 - i-1))
                {
                    matrix[i, j] = '.';
                }
                else
                {
                    if ((((i+j)%2 == n%2)&&(n%4==0))||(!((i+j)%2 == n%2)&&!(n%4==0)))
                    {
                        matrix[i, j] = ' '; 
                    }
                    else
                    {
                        matrix[i, j] = '/';
                    }
                }
            }
        }
        for (int i = 0; i < n/2; i++)
        {
            for (int j = n/2; j < n; j++)
            {
                if (matrix[i, n - j - 1]=='/')
                {
                    matrix[i, j] = '\\'; 
                }
                else
                {
                matrix[i, j] = matrix[i, n - j - 1];
                }
            }
        }

        for (int i = n/2; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[n-i-1,j]=='/')
                {
                    matrix[i, j] = '\\'; 
                }
                else if (matrix[n-i-1,j]=='\\')
                {
                    matrix[i, j] = '/';
                }
                else
                {
                    matrix[i, j] = matrix[n-i-1, j];
                }
            }
        }


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i,j].ToString());
            }
            Console.WriteLine();
        }

    }
}