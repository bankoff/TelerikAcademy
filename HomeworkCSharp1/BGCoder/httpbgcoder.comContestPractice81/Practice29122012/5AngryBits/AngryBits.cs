using System;

class AngryBits
{
    static void Main()
    {
        int n = 8;
        int[] number = new int[n];
        int[,] matrix = new int[n, 16];
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
            for (int j = 0; j < 16; j++)
            {
                matrix[i, j] = (number[i] >> j) & 1;
            }
        }

        int birdRow = 0;
        int birdCol = 0;

        for (int col = 8; col < 16; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                if (matrix[row, col] == 1)
                {
                    birdRow = row;
                    birdCol = col;
                    matrix[row, col] = 0;
                    break;
                }
            }



            string direction = "up";
            int flightRow = birdRow;
            int flightCol = birdCol;
            while (true)
            {
                if (flightRow == 0)
                {
                    direction = "down";
                }
                if (direction == "up")
                {
                    flightRow--;
                    flightCol--;
                }
                else if (direction == "down")
                {
                    flightRow++;
                    flightCol--;
                }

                if ((flightRow > 7) || (flightCol < 0))
                {
                    break;
                }



                int pigs = 0;

                if (matrix[flightRow, flightCol] == 1)
                {
                    for (int i = flightRow - 1; i <= flightRow + 1; i++)
                    {
                        for (int j = flightCol - 1; j <= flightCol + 1; j++)
                        {
                            if ((j >= 0) & (i >= 0) & (i < 8))
                            {
                                if (matrix[i, j] == 1)
                                {
                                    pigs++;
                                    matrix[i, j] = 0;
                                }
                            }
                        }
                    }
                    result = result + pigs * (birdCol - flightCol);
                    break;
                }
            }
        }

        string yesOrNo = " Yes";
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (matrix[i, j] == 1)
                {
                    yesOrNo = " No";
                    break;
                }
            }
            if (yesOrNo == " No")
            {
                break;
            }
        }
        Console.WriteLine(result + yesOrNo);
    }
}