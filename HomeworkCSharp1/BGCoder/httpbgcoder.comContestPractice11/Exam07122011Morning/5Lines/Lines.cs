using System;

class Lines
{
    static void Main()
    {
        int n = 8;
        int[] number = new int[n];
        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = (number[i] >> j) & 1;
            }
        }


        int maxLenghtRow = 0;
        int numberMaxLenghtRow = 0;
        for (int i = 0; i < n; i++)
        {
            int counter = 0;
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] == 1)
                {
                    counter++;
                    if (j == n - 1)
                    {
                        if (maxLenghtRow < counter)
                        {
                            maxLenghtRow = counter;
                            numberMaxLenghtRow = 1;
                        }
                        else if (maxLenghtRow == counter)
                        {
                            numberMaxLenghtRow++;
                        }
                    }
                }
                else
                {
                    if (maxLenghtRow < counter)
                    {
                        maxLenghtRow = counter;
                        numberMaxLenghtRow = 1;
                    }
                    else if (maxLenghtRow == counter)
                    {
                        numberMaxLenghtRow++;
                    }
                    counter = 0;
                }
            }
        }

        int maxLenghtCol = 0;
        int numberMaxLenghtCol = 0;
        for (int i = 0; i < n; i++)
        {
            int counter = 0;
            for (int j = 0; j < n; j++)
            {
                if (matrix[j, i] == 1)
                {
                    counter++;
                    if (j == n - 1)
                    {
                        if (maxLenghtCol < counter)
                        {
                            maxLenghtCol = counter;
                            numberMaxLenghtCol = 1;
                        }
                        else if (maxLenghtCol == counter)
                        {
                            numberMaxLenghtCol++;
                        }
                    }
                }
                else
                {
                    if (maxLenghtCol < counter)
                    {
                        maxLenghtCol = counter;
                        numberMaxLenghtCol = 1;
                    }
                    else if (maxLenghtCol == counter)
                    {
                        numberMaxLenghtCol++;
                    }
                    counter = 0;
                }
            }

        }


        if (maxLenghtRow > maxLenghtCol)
        {
            Console.WriteLine(maxLenghtRow);
            Console.WriteLine(numberMaxLenghtRow);
        }
        else if (maxLenghtRow < maxLenghtCol)
        {
            Console.WriteLine(maxLenghtCol);
            Console.WriteLine(numberMaxLenghtCol);
        }
        else if (maxLenghtCol == maxLenghtRow)
        {
            if (maxLenghtCol == 1)
            {
                Console.WriteLine(maxLenghtCol);
                Console.WriteLine(numberMaxLenghtCol);
            }
            else
            {
                Console.WriteLine(maxLenghtCol);
                Console.WriteLine(numberMaxLenghtRow + numberMaxLenghtCol);
            }
        }
    }
}