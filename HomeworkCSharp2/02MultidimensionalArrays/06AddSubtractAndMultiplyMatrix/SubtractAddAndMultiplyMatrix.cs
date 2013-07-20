//Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, 
//subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

// CLASS Matrix is in Matrix.cs

using System;

class SubtractAddAndMultiplyMatrix
{
    static void Main()
    {
        Console.Write("How you want to fill the matrix? \nFor manually press 1, for random press 2: ");
        int manualRandom = int.Parse(Console.ReadLine());
        int row1 = 3, col1 = 3, row2 = 3, col2 = 3;
        int mathFunction=0;
        if (manualRandom==1)
        {
            Console.WriteLine("For adding matrix press 1,\nfor subtracting matrix press2,\nfor multiplying matrix press3.");
            Console.Write("What are you wont: ");
            mathFunction = int.Parse(Console.ReadLine());
        }
        if (mathFunction==1||mathFunction==2)
        {
            Console.Write("Please enter rows of matrix: ");
            row1 = int.Parse(Console.ReadLine());
            row2 = row1;
            Console.Write("Please enter columns of matrix: ");
            col1 = int.Parse(Console.ReadLine());
            col2 = col1;
        }
        else if (mathFunction==3)
        {
            Console.Write("Please enter rows of matrix1: ");
            row1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter columns of matrix1 and rows of matrix2: ");
            col1 = int.Parse(Console.ReadLine());
            row2 = col1;
            Console.Write("Please enter columns of matrix2: ");
            col2 = int.Parse(Console.ReadLine());
        }

        Matrix m1 = new Matrix(row1, col1);
        Matrix m2 = new Matrix(row2, col2);
        Console.WriteLine(m1.Name);

        // Fill with random numbers        
        Random randomGenerator = new Random();
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Cols; j++)
            {
                if (manualRandom==1)
                {
                    Console.Write("Please enter element matrix1[{0},{1}]: ",i,j);
                    m1[i, j] = int.Parse(Console.ReadLine());
                }
                else if (manualRandom==2)
                {
                    m1[i, j] = randomGenerator.Next(20);
                }
            }
        }
        for (int i = 0; i < m2.Rows; i++)
        {
            for (int j = 0; j < m2.Cols; j++)
            {
                if (manualRandom == 1)
                {
                    Console.Write("Please enter element matrix1[{0},{1}]: ", i, j);
                    m2[i, j] = int.Parse(Console.ReadLine());
                }
                else if (manualRandom == 2)
                {
                    m2[i, j] = randomGenerator.Next(20);
                }
            }
        }

        Console.WriteLine("Matrix 1");
        Console.WriteLine(m1);
        Console.WriteLine("Matrix 2");
        Console.WriteLine(m2); 

        if (mathFunction==1)
        {
            Console.WriteLine("Matrix 1 + Matrix 2");
            Console.WriteLine(m1 + m2);
        }
        else if (mathFunction==2)
        {
            Console.WriteLine("Matrix 1 - Matrix 2");
            Console.WriteLine(m1 - m2);
        }
        else if (mathFunction == 3)
        {
            Console.WriteLine("Matrix 1 * Matrix 2");
            Console.WriteLine(m1 * m2);
        }
        else
        {
            Console.WriteLine("Matrix 1 + Matrix 2");
            Console.WriteLine(m1 + m2);
            Console.WriteLine("Matrix 1 - Matrix 2");
            Console.WriteLine(m1 - m2);
            Console.WriteLine("Matrix 1 * Matrix 2");
            Console.WriteLine(m1 * m2);
        }
    }
}