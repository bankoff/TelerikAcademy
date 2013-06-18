using System;

class FormulaBit1
{
    static void Main()
    {
        checked
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

            if (matrix[0, 0] == 1)
            {
                Console.WriteLine("No 0");
            }
            else
            {
                int row = 0;
                int col = 0;
                int counter = 1;
                int turn = 0;
                string direction = "down";
                while (true)
                {

                    if (direction == "down")
                    {
                        if (row == 7)
                        {
                            if (matrix[row, col + 1] == 0)
                            {
                                direction = "left";
                                turn++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (matrix[row + 1, col] == 0)
                            {
                                row++;
                                counter++;
                            }
                            else if ((matrix[row, col + 1] == 0)&(counter>1))
                            {
                                direction = "left";
                                turn++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    if (col == 7 & row == 7)
                    {
                        break;
                    }

                    if (direction == "left")
                    {
                        if (col == 7)
                        {
                            if (((turn - 1) % 4 == 0) & (row > 1))
                            {
                                if (matrix[row - 1, col] == 0)
                                {
                                    direction = "up";
                                    turn++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else if (((turn - 3) % 4 == 0) & (row < 7))
                            {
                                if (matrix[row + 1, col] == 0)
                                {
                                    direction = "down";
                                    turn++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (matrix[row, col + 1] == 0)
                            {
                                col++;
                                counter++;
                            }
                            else if (((turn - 1) % 4 == 0) & (matrix[row - 1, col] == 0))
                            {
                                direction = "up";
                                turn++;
                            }
                            else if (((turn - 3) % 4 == 0) & (matrix[row + 1, col] == 0))
                            {
                                direction = "down";
                                turn++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    if (col == 7 & row == 7)
                    {
                        break;
                    }

                    if (direction == "up")
                    {
                        if (row == 0)
                        {
                            if (matrix[row, col - 1] == 0)
                            {
                                direction = "left";
                                turn++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (matrix[row - 1, col] == 0)
                            {
                                row--;
                                counter++;
                            }
                            else if (matrix[row, col - 1] == 0)
                            {
                                direction = "left";
                                turn++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    if (col == 7 & row == 7)
                    {
                        break;
                    }
                }

                if (row == 7 & col == 7)
                {
                    Console.WriteLine("{0} {1}", counter, turn);
                }
                else
                {
                    Console.WriteLine("No {0}", counter);
                }

            }
        }
    }
}