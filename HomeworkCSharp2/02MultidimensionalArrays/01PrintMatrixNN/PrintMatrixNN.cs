//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
// a)  1	5	9	13       b)  1	8	 9	16          c)  7	11	14	16       d)  1	12	11	10
//     2	6	10	14           2	7	10	15              4	8	12	15           2	13	16	 9
//     3	7	11	15           3	6	11	14              2	5	9	13           3	14	15	 8
//     4	8	12	16           4	5   12	13              1	3	6	10           4	 5	 6	 7

using System;

class PrintMatrixNN
{
    static void Main()
    {
        //declaring the matix size 
        uint matrixSize;
        do
        {
            Console.Write("Please enter the size of array: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out matrixSize));
        int counter;
        int[,] matrix = new int[matrixSize, matrixSize];

        //Matrix A)
        counter = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = counter;
                counter++;
            }
        }
        Console.WriteLine("a)");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,5} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //Matrix B
        counter = 1;
        string direktion = "down";
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (direktion == "down")
                {
                    matrix[row, col] = counter;
                }
                else if (direktion == "up")
                {
                    matrix[matrix.GetLength(0) - 1 - row, col] = counter;
                }
                counter++;
            }
            if (direktion == "down")
            {
                direktion = "up";
            }
            else if (direktion == "up")
            {
                direktion = "down";
            }
        }
        Console.WriteLine("b)");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,5} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //Matrix C
        counter = 1;
        for (int i = 0; i <= matrix.GetLength(0) - 1 + matrix.GetLength(1) - 1; i++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (row + col == i)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                }
            }
        }
        Console.WriteLine("c)");
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,5} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //Matrix D
        counter = 1;
        int topPositionX = 0;
        int bottomPositionX = matrix.GetLength(1) - 1;
        int topPositionY = 0;
        int bottomPositionY = matrix.GetLength(0) - 1;

        while (counter <= matrix.GetLength(0) * matrix.GetLength(1))
        {
            // go down
            for (int i = topPositionY; i <= bottomPositionY; i++)
            {
                matrix[topPositionX, i] = counter;
                counter++;
            }
            topPositionX++;

            // go right
            for (int i = topPositionX; i <= bottomPositionX; i++)
            {
                matrix[i, bottomPositionY] = counter;
                counter++;
            }
            bottomPositionY--;

            // go up
            for (int i = bottomPositionY; i >= topPositionY; i--)
            {
                matrix[bottomPositionX, i] = counter;
                counter++;
            }
            bottomPositionX--;

            //go left
            for (int i = bottomPositionX; i >= topPositionX; i--)
            {
                matrix[i, topPositionY] = counter;
                counter++;
            }
            topPositionY++;
        }
        Console.WriteLine("d)");
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.Write("{0,5} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}