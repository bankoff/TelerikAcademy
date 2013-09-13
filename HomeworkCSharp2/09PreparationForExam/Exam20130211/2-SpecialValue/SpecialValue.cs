using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SpecialValue
{
    static int GetValue(int[][] rows, int col)
    {
        int value=0;
        int row = 0;
        int count = 0;
        bool[][] flag = new bool[rows.Length][];
        for (int i = 0; i < rows.Length; i++)
        {
            flag[i] = new bool[rows[i].Length];
        }
        while (true)
        {
            if (rows[row][col]<0)
            {
                count++;
                value = count - rows[row][col];
                break;
            }
            else if (flag[row][col]==true)
            {
                return 0;
            }
            else
            {
                flag[row][col] = true;
                col = rows[row][col];
                count++;
                row++;
                if (row==rows.Length)
                {
                    row = 0;
                }
            }
        }
        return value;
    }
    
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int[][] rows = new int[row][];


        for (int i = 0; i < row; i++)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            rows[i] = new int[arr.Length];

            for (int j = 0; j < arr.Length; j++)
            {      
                rows[i][j] = int.Parse(arr[j]);
            }
        }

        int maxValue = 0;
        int value;

        for (int i = 0; i < rows[0].Length; i++)
        {
            value = GetValue(rows, i);
            if (value > maxValue)
            {
                maxValue = value;
            }
        }

        Console.WriteLine(maxValue);
    }
}