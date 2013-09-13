using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class JoroTheRabbit
{
   static int[] ReadInput(string input)
    {
        char[] separator = { ' ', ',' };
        string[] stringArray = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[stringArray.Length];

        for (int i = 0; i < stringArray.Length; i++)
        {
            array[i] = int.Parse(stringArray[i]);
        }

        return array;
    }

    static void Main()
    {
        int[] array = ReadInput(Console.ReadLine());
        int result = 0;
        int arrLength = array.Length;

        for (int step = 1; step < arrLength; step++)
        {
            for (int k = 0; k < arrLength; k++)
            {
                int m = k;
                int first = array[m];
                int count = 1;

                while (true)
                {
                    m = m + step;
                    if (m >= arrLength)
                    {
                        m = m - arrLength;
                    }

                    if (first < array[m] & m != k)
                    {
                        first = array[m];
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count > result)
                {
                    result = count;
                }
            }
        }

        Console.WriteLine(result);
    }
}