using System;

class FormulaBit1
{
    static void Main()
    {
        int n = 8;
        int[,] matrix = new int[n + 2, n + 2];
        int number;

        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                matrix[i + 1, j + 1] = (number >> j) & 1;
            }
        }

        for (int i = 0; i < n + 2; i++)
        {
            matrix[0, i] = 1;
            matrix[n + 1, i] = 1;
            matrix[i, 0] = 1;
            matrix[i, n + 1] = 1;
        }

        string direction = "down";
        int row = 1;
        int col = 1;
        int counter = 0;
        int turn = 0;

        if (matrix[1, 1] == 0)
        {
            counter++;
            while (true)
            {
                while (direction == "down")
                {
                    if (matrix[row + 1, col] == 0)
                    {
                        row++;
                        counter++;
                    }
                    else if (matrix[row, col + 1] == 0 && !(row == 8 && col == 8))
                    {
                        direction = "left";
                        turn++;
                    }
                    else
                    {
                        direction = "exit";
                        break;
                    }
                }

                if (direction == "exit" || (row == 8 && col == 8))
                {
                    break;
                }

                while (direction == "left")
                {
                    if (matrix[row, col + 1] == 0)
                    {
                        col++;
                        counter++;
                    }
                    else if (matrix[row - 1, col] == 0 && !(row == 8 && col == 8))
                    {
                        direction = "up";
                        turn++;
                    }
                    else
                    {
                        direction = "exit";
                        break;
                    }
                }

                if (direction == "exit" || (row == 8 && col == 8))
                {
                    break;
                }

                while (direction == "up")
                {
                    if (matrix[row - 1, col] == 0)
                    {
                        row--;
                        counter++;
                    }
                    else if (matrix[row, col + 1] == 0 && !(row == 8 && col == 8))
                    {
                        direction = "left";
                        turn++;
                    }
                    else
                    {
                        direction = "exit";
                        break;
                    }
                }

                if (direction == "exit" || (row == 8 && col == 8))
                {
                    break;
                }

                while (direction == "left")
                {
                    if (matrix[row, col + 1] == 0)
                    {
                        col++;
                        counter++;
                    }
                    else if (matrix[row + 1, col] == 0 && !(row == 8 && col == 8))
                    {
                        direction = "down";
                        turn++;
                    }
                    else
                    {
                        direction = "exit";
                        break;
                    }
                }

                if (direction == "exit" || (row == 8 && col == 8))
                {
                    break;
                }
            }
        }

        if (row == 8 && col == 8)
        {
            Console.WriteLine("{0} {1}", counter, turn);
        }
        else
        {
            Console.WriteLine("No {0}", counter);
        }
    }
}