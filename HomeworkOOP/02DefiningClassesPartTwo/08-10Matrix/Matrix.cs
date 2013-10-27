//8.Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
//9.Implement an indexer this[row, col] to access the inner matrix cells.
//10.Implement the operators + and - (addition and subtraction of matrices of the same size) 
//and * for matrix multiplication. Throw an exception when the operation cannot be performed. 
//Implement the true operator (check for non-zero elements).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_10Matrix
{
    class Matrix<T>
    {
        // Private Fields
        private readonly T[,] matrix = null;

        // Public Properties
        public int Rows { get; private set; }

        public int Cols { get; private set; }

        // Constructor
        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;

            this.matrix = new T[this.Rows, this.Cols];
        }

        // Indexer
        public T this[int x, int y]
        {
            get { return matrix[x, y]; }
            set { matrix[x, y] = value; }
        }

        // Plus / Minus Operator
        private static Matrix<T> PlusMinus(Matrix<T> m1, Matrix<T> m2, bool plus)
        {
            if (!(m1.Rows == m2.Rows && m1.Cols == m2.Cols))
                throw new ArgumentException("Matrix size is not the same!");

            Matrix<T> result = new Matrix<T>(m1.Rows, m1.Cols);

            for (int i = 0; i < result.Rows; i++)
                for (int j = 0; j < result.Cols; j++)
                    result[i, j] = m1[i, j] + (plus ? m2[i, j] : -(dynamic)m2[i, j]);

            return result;
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            return PlusMinus(m1, m2, true);
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            return PlusMinus(m1, m2, false);
        }

        // Naive multiplication
        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (!(m1.Cols == m2.Rows))
                throw new ArgumentException("Matrix size is not the same!");

            Matrix<T> result = new Matrix<T>(m1.Rows, m2.Cols);

            for (int i = 0; i < result.Rows; i++)
                for (int j = 0; j < result.Cols; j++)
                    for (int k = 0; k < m1.Cols; k++)
                        result[i, j] += (dynamic)m1[i, k] * m2[k, j];

            return result;
        }

        // True / False
        private static bool BoolOperator(Matrix<T> m, bool value)
        {
            foreach (T item in m.matrix)
                if ((dynamic)item != 0)
                    return value;

            return !value;
        }

        public static bool operator true(Matrix<T> m)
        {
            return BoolOperator(m, true);
        }

        public static bool operator false(Matrix<T> m)
        {
            return BoolOperator(m, false);
        }

        // To string
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            for (int i = 0; i < this.Rows; i++)
                for (int j = 0; j < this.Cols; j++)
                    s.Append(this.matrix[i, j] + (j != this.Cols - 1 ? " " : Environment.NewLine));

            return s.ToString();
        }
    }
}