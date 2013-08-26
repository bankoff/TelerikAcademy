//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix 
//an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains 
//the size of matrix N. Each of the next N lines contain N numbers separated by space. The output should 
//be a single number in a separate text file. Example:
//      4
//      2 3 3 4
//      0 2 3 4			17
//      3 7 1 2
//      4 3 3 2

using System;
using System.Text;
using System.IO;

class SquareMatrix
{
    static void Main()
    {
        PrintResult(GetMax(ReadMatrix()));
        Console.WriteLine("The maxsum, written in your output file is {0}.", GetMax(ReadMatrix()));
    }

    static int[,] ReadMatrix()
    {
        StreamReader matrix = new StreamReader(@"../../matrix.txt", Encoding.GetEncoding("windows-1251"));

        using (matrix)
        {
            int matrixSize = int.Parse(matrix.ReadLine());
            int[,] numMatrix = new int[matrixSize, matrixSize];
            for (int rows = 0; rows < matrixSize; rows++)
            {
                string[] numbers = matrix.ReadLine().Split(' ');
                for (int cols = 0; cols < matrixSize; cols++)
                {
                    numMatrix[rows, cols] = int.Parse(numbers[cols]);
                }
            }
            return numMatrix;
        }
    }

    static int GetMax(int[,] numMatrix)
    {
        int maxSum = int.MinValue;
        for (int rows = 0; rows < numMatrix.GetLength(0) - 1; rows++)
        {
            for (int cols = 0; cols < numMatrix.GetLength(1) - 1; cols++)
            {
                if (numMatrix[rows, cols] + numMatrix[rows, cols + 1] + numMatrix[rows + 1, cols + 1] + numMatrix[rows + 1, cols] > maxSum)
                {
                    maxSum = numMatrix[rows, cols] + numMatrix[rows, cols + 1] + numMatrix[rows + 1, cols + 1] + numMatrix[rows + 1, cols];
                }
            }
        }
        return maxSum;
    }

    static void PrintResult(int maxSum)
    {
        StreamWriter output = new StreamWriter(@"../../output.txt", false, Encoding.GetEncoding("windows-1251"));

        using (output)
        {
            output.WriteLine(maxSum);
        }
    }
}

