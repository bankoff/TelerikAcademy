// Write a program that reads a rectangular matrix of size N x M and finds 
// in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MatrixNxM3x3MaxSum
{
    static void Main()
    {
        // read input from console
        uint matrixSizeRow;
        do
        {
            Console.Write("Please enter the rows of matrix: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out matrixSizeRow));
        uint matrixSizeCol;
        do
        {
            Console.Write("Please enter the columns of matrix: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out matrixSizeCol));

        int[,] matrix = new int[matrixSizeRow, matrixSizeCol];
        for (int row = 0; row < matrixSizeRow; row++)
        {
            for (int col = 0; col < matrixSizeCol; col++)
            {
                do
                {
                    Console.Write("Please enter element[{0},{1}] of matrix: ", row, col);
                }
                while (!int.TryParse(Console.ReadLine(), out matrix[row, col]));
            }
        }

        if (matrixSizeCol >= 3 && matrixSizeRow >= 3)
        {
            long maxSum = long.MinValue;
            long currentSum;
            int counter = 0;
            for (int row = 1; row < matrixSizeRow - 1; row++)
            {
                for (int col = 1; col < matrixSizeCol - 1; col++)
                {
                    currentSum = matrix[row - 1, col - 1] + matrix[row - 1, col] + matrix[row - 1, col + 1] +
                                 matrix[row, col - 1] + matrix[row, col] + matrix[row, col + 1] +
                                 matrix[row + 1, col - 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        counter = 1;
                    }
                    else if (currentSum==maxSum)
                    {
                        counter++;
                    }
                }
            }

            // print matrix and result
            Console.WriteLine("\nmatrix: \n");
            for (int row = 0; row < matrixSizeRow; row++)
            {
                for (int col = 0; col < matrixSizeCol; col++)
                {
                    Console.Write("{0,8}",matrix[row,col]);
                }
                Console.WriteLine();
            }

            if (counter==1)
            {
                Console.WriteLine("\nSquare whit maximal sum is: \n");    
            }
            else
            {
                Console.WriteLine("\nSquares whit maximal sum are: \n");  
            }

            for (int row = 1; row < matrixSizeRow - 1; row++)
            {
                for (int col = 1; col < matrixSizeCol - 1; col++)
                {
                    currentSum = matrix[row - 1, col - 1] + matrix[row - 1, col] + matrix[row - 1, col + 1] +
                                 matrix[row, col - 1] + matrix[row, col] + matrix[row, col + 1] +
                                 matrix[row + 1, col - 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum == maxSum)
                    {
                        Console.WriteLine("{0,8} {1,8} {2,8}", matrix[row - 1, col - 1], matrix[row - 1, col], matrix[row - 1, col + 1]);
                        Console.WriteLine("{0,8} {1,8} {2,8}", matrix[row, col - 1], matrix[row, col], matrix[row, col + 1]);
                        Console.WriteLine("{0,8} {1,8} {2,8}", matrix[row + 1, col - 1], matrix[row + 1, col], matrix[row + 1, col + 1]);
                        Console.WriteLine("\n");
                    }
                }
            }
            Console.WriteLine("Maximal sum is: {0}", maxSum); 
        }
        else
        {
            Console.WriteLine("Matrix is smaller");
        }
    }
}