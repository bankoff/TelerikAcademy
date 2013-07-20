//Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. 
//Example:
//      1	3	2	2	2	4
//      3	3	3	2	4	4
//      4	3	1	2	3	3
//      4	3	1	3	3	1
//      4	3	3	3	1	1

using System;

class LargestAreaOfEqualNeighborElements
{
    static void Main()
    {
        int[,] matrix = new int[,]{ { 1, 3, 2, 2, 2, 4 }, 
                                { 3, 3, 3, 2, 4, 4 }, 
                                { 4, 3, 1, 2, 3, 3 }, 
                                { 4, 3, 1, 3, 3, 1 }, 
                                { 4, 3, 3, 3, 1, 1 } };
        int matrixSizeRow = matrix.GetLength(0);
        int matrixSizeCol = matrix.GetLength(1);

        //// read input from console
        //uint matrixSizeRow;
        //do
        //{
        //    Console.Write("Please enter the rows of matrix: ");
        //}
        //while (!uint.TryParse(Console.ReadLine(), out matrixSizeRow));
        //uint matrixSizeCol;
        //do
        //{
        //    Console.Write("Please enter the columns of matrix: ");
        //}
        //while (!uint.TryParse(Console.ReadLine(), out matrixSizeCol));

        //int[,] matrix = new int[matrixSizeRow, matrixSizeCol];
        //for (int row = 0; row < matrixSizeRow; row++)
        //{
        //    for (int col = 0; col < matrixSizeCol; col++)
        //    {
        //        do
        //        {
        //            Console.Write("Please enter element[{0},{1}] of matrix: ", row, col);
        //        }
        //        while (!int.TryParse(Console.ReadLine(), out matrix[row, col]));
        //    }
        //}

        //use BFS, see https://en.wikipedia.org/wiki/Breadth-first_search
        bool[,] visited = new bool[matrixSizeRow, matrixSizeCol];
        int maxLength = -1;
        int[] queueI = new int[matrixSizeRow * matrixSizeCol];
        int[] queueJ = new int[matrixSizeRow * matrixSizeCol];
        int[] checkInDirectionX = { 0, 1, 0, -1 };
        int[] checkInDirectionY = { -1, 0, 1, 0 };
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                if (visited[rows, cols] == true)
                {
                    continue;
                }
                visited[rows, cols] = true;
                int head = 0;
                int tail = 1;
                int currentLength = 1;
                queueI[0] = rows;
                queueJ[0] = cols;
                while (head < tail)
                {
                    int newI = queueI[head];
                    int newJ = queueJ[head++];
                    for (int k = 0; k < 4; k++)
                    {
                        int nextI = newI + checkInDirectionY[k];
                        int nextJ = newJ + checkInDirectionX[k];
                        if (nextI >= 0 && nextI < matrixSizeRow && nextJ >= 0 && nextJ < matrixSizeCol && 
                            !visited[nextI, nextJ] && matrix[nextI, nextJ] == matrix[rows, cols])
                        {
                            currentLength++;
                            visited[nextI, nextJ] = true;
                            queueI[tail] = nextI;
                            queueJ[tail++] = nextJ;
                        }
                    }
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
        }

        //print matrix
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("{0,5} ",matrix[rows,cols]);
            }
            Console.WriteLine();      
        }

        //print result
        Console.WriteLine("\nLargest area is: {0}", maxLength);
    }
}