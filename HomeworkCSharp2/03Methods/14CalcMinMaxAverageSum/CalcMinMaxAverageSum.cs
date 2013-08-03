//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
//Use variable number of arguments.

using System;

class CalcMinMaxAverageSum
{
    static void Main()
    {
        int[] array = { 2, 4, -6, 3 };
        
        Console.WriteLine("The biggest integer in array is:{0}", FindMax(array));
        Console.WriteLine("The smallest integer in array is:{0}", FindMin(array));
        Console.WriteLine("The average in array is:{0:F2}", FindAverage(array));
        Console.WriteLine("The sum in array is:{0}", FindSum(array));
        Console.WriteLine("The product in array is:{0}", FindProduct(array));
    }

    static int FindMax(params int[] array)
    {
        int biggest = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > biggest)
            {
                biggest = array[i];
            }
        }
        return biggest;
    }
    static int FindMin(params int[] array)
    {
        int smallest = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < smallest)
            {
                smallest = array[i];
            }
        }
        return smallest;
    }
    static double FindSum(params int[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        return sum;
    }
    static double FindAverage(int[] array)
    {
        double average = FindSum(array) / (double)array.Length;
        return average;
    }
    static int FindProduct(int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product = product * array[i];
        }
        return product;
    }
}