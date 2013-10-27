using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_10Matrix
{
    class TestMatrix
    {
        static void Main()
        {
            Matrix<int> m1 = new Matrix<int>(3, 3);
            Matrix<int> m2 = new Matrix<int>(3, 3);

            // Fill with random numbers
            Random randomGenerator = new Random();
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    m1[i, j] = randomGenerator.Next(20);
                    m2[i, j] = randomGenerator.Next(20);
                }
            }

            Console.WriteLine("Matrix 1");
            Console.WriteLine(m1);

            Console.WriteLine("Matrix 2");
            Console.WriteLine(m2);

            Console.WriteLine("Matrix 1 + Matrix 2");
            Console.WriteLine(m1 + m2);

            Console.WriteLine("Matrix 1 - Matrix 2");
            Console.WriteLine(m1 - m2);

            Console.WriteLine("Matrix 1 * Matrix 2");
            Console.WriteLine(m1 * m2);

            Console.WriteLine(m1 ? "Not empty" : "Empty");

            if (new Matrix<int>(3, 3)!=null) Console.WriteLine("Empty");
        }
    }
}
