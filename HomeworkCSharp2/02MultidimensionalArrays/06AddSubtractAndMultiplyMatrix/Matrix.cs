// http://bg.wikipedia.org/wiki/%D0%9C%D0%B0%D1%82%D1%80%D0%B8%D1%86%D0%B0_(%D0%BC%D0%B0%D1%82%D0%B5%D0%BC%D0%B0%D1%82%D0%B8%D0%BA%D0%B0)

using System;

class Matrix
{
    public int Rows, Cols;
    private int[,] matrix;

    // Constructor   
    public Matrix(int x, int y)
    {
        matrix = new int[x, y];
        Rows = x;
        Cols = y;
        this.Name = "PESHO";
    }

    // Getter/Setter    
    public int this[int x, int y]
    {
        get
        {
            return matrix[x, y];
        }
        set
        {
            matrix[x, y] = value;
        }
    }

    public string Name { get; set; }

    // add of matrices
    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        Matrix m = new Matrix(m1.Rows, m1.Cols);
        for (int i = 0; i < m.Rows; i++)
        {
            for (int j = 0; j < m.Cols; j++)
            {
                m[i, j] = m1[i, j] + m2[i, j];
            }
        }
        return m;
    }

    // subtract of matrices
    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        Matrix m = new Matrix(m1.Rows, m1.Cols);
        for (int i = 0; i < m.Rows; i++)
        {
            for (int j = 0; j < m.Cols; j++)
            {
                m[i, j] = m1[i, j] - m2[i, j];
            }
        }
        return m;
    }

    // multiply of matrices
    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        Matrix m = new Matrix(m1.Rows, m2.Cols);
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m2.Cols; j++)
            {
                for (int k = 0; k < m1.Cols; k++)
                {
                    m[i, j] += m1[i, k] * m2[k, j];
                }
            }
        }
        return m;
    }

    // Convert result to string  
    public override string ToString()
    {
        int max = this.matrix[0, 0];
        foreach (int cell in this.matrix)
        {
            max = Math.Max(max, cell);
        }
        int cellSize = Convert.ToString(max).Length;
        string s = String.Empty;
        for (int i = 0; i < this.Rows; i++)
        {
            for (int j = 0; j < this.Cols; j++)
            {
                s += (Convert.ToString(this.matrix[i, j])).PadLeft(cellSize + 3) + (j != this.Cols - 1 ? "" : "\n");
            }
        }
        return s;
    }
}