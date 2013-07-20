// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets 
// of several neighbor elements located on the same line, column or diagonal. Write a program 
// that finds the longest sequence of equal strings in the matrix. Example:

//      ha     fifi     ho      hi                              s	qq	s
//      fo	   ha       hi	    xx  --> ha, ha, ha              pp	pp	s   -->  s, s, s  
//      xxx	   ho       ha	    xx                              pp	qq	s

// Входните данни може да копираш и пейстнеш от файла 03.txt в главната дректория

using System;
using System.Collections.Generic;

class LongestSequenceInMatrix
{
    static List<string> MaxHorizontalSequences(string[,] matrix, List<string> result)
    {
        int curentLength;
        int maxLength = int.Parse(result[result.Count - 1]);
        result.RemoveAt(result.Count - 1);

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            curentLength = 1;
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col].CompareTo(matrix[row, col - 1]) == 0)
                {
                    curentLength++;

                    if (curentLength > maxLength)
                    {
                        maxLength = curentLength;
                        result.Clear();
                        result.Add(matrix[row, col]);
                    }
                    else if (curentLength == maxLength)
                    {
                        result.Add(matrix[row, col]);
                    }
                }
            }
        }
        result.Add(maxLength.ToString());
        return result;
    }

    static List<string> MaxDiagonalSequences(string[,] matrix, List<string> result)
    {
        int curentLength;
        int maxLength = int.Parse(result[result.Count - 1]);
        result.RemoveAt(result.Count - 1);

        for (int i = 0; i <= (matrix.GetLength(0) - 1) + (matrix.GetLength(1) - 1) - 1; i++)
        {
            curentLength = 1;
            string lastElement = "";
            bool firstNumber = true;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (row + col == i && firstNumber)
                    {
                        lastElement = matrix[row, col];
                        firstNumber = false;
                    }
                    else if (row + col == i)
                    {
                        if (matrix[row, col].CompareTo(lastElement) == 0)
                        {
                            curentLength++;
                            if (curentLength > maxLength)
                            {
                                maxLength = curentLength;
                                result.Clear();
                                result.Add(matrix[row, col]);
                            }
                            else if (curentLength == maxLength)
                            {
                                result.Add(matrix[row, col]);
                            }
                        }
                        else
                        {
                            lastElement = matrix[row, col];
                        }
                    }
                }
            }
        }

        result.Add(maxLength.ToString());
        return result;
    }

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

        string[,] matrix = new string[matrixSizeRow, matrixSizeCol];
        for (int row = 0; row < matrixSizeRow; row++)
        {
            for (int col = 0; col < matrixSizeCol; col++)
            {
                Console.Write("Please enter element[{0},{1}] of matrix: ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        List<string> maxSequences = new List<string>() { "0" };
        maxSequences = MaxHorizontalSequences(matrix, maxSequences);
        maxSequences = MaxDiagonalSequences(matrix, maxSequences);

        //reverce matrix[i,j] to matrix1[j,i]
        string[,] matrix1 = new string[matrixSizeCol, matrixSizeRow];
        for (int i = 0; i < matrixSizeRow; i++)
        {
            for (int j = 0; j < matrixSizeCol; j++)
            {
                matrix1[j, i] = matrix[i, j];
            }
        }

        maxSequences = MaxHorizontalSequences(matrix1, maxSequences);

        //reverce matrix[i,j] to matrix2[i,k], where (k = matrixSizeCol-j-1)
        string[,] matrix2 = new string[matrixSizeRow, matrixSizeCol];
        for (int i = 0; i < matrixSizeRow; i++)
        {
            for (int j = 0; j < matrixSizeCol; j++)
            {
                matrix2[i, j] = matrix[i, matrixSizeCol - j - 1];
            }
        }

        maxSequences = MaxDiagonalSequences(matrix2, maxSequences);

        //print matrix
        Console.WriteLine();
        for (int i = 0; i < matrixSizeRow; i++)
        {
            for (int j = 0; j < matrixSizeCol; j++)
            {
                Console.Write("{0,10} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //print result
        if (maxSequences[maxSequences.Count - 1] == "0" && matrixSizeCol != 0 && matrixSizeRow != 0)
        {
            Console.WriteLine("Maximal sequences in matrix have 1 element");
            Console.WriteLine("This is every element in matrix");
        }
        else
        {
            Console.WriteLine("Maximal sequences in matrix have {0} elements", maxSequences[maxSequences.Count - 1]);
            Console.WriteLine("Maximal sequences in matrix are:");
            for (int i = 0; i < maxSequences.Count - 1; i++)
            {
                for (int j = 0; j < int.Parse(maxSequences[maxSequences.Count - 1]); j++)
                {
                    Console.Write("{0} ", maxSequences[i]);
                }
                Console.WriteLine();
            }
        }
    }
}