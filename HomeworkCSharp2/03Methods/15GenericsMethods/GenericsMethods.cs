//* Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). 
//Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class GenericsMethods
{
    static void Main()
    {
        var array = new[] { 2, 1.5, -3, 1};

        Console.WriteLine("The biggest number in array is:{0}", FindMax(array));
        Console.WriteLine("The smallest number in array is:{0}", FindMin(array));
        Console.WriteLine("The sum in array is:{0}", FindSum(array));
        Console.WriteLine("The average in array is:{0:F3}", FindAverage((FindSum(array)), array));
        Console.WriteLine("The product in array is:{0}", FindProduct(array));
    }
    static T FindMax<T>(params T[] array)
    {
        dynamic biggest = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > biggest)
            {
                biggest = array[i];
            }
        }
        return biggest;
    }
    static T FindMin<T>(params T[] array)
    {
        dynamic smallest = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < smallest)
            {
                smallest = array[i];
            }
        }
        return smallest;
    }
    static T FindSum<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        return sum;
    }
    static T FindAverage<T>(dynamic sum, params T[] array)
    {
        dynamic average = sum / array.Length;
        return average;
    }
    static T FindProduct<T>(params T[] array)
    {
        dynamic product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product = product * array[i];
        }
        return product;
    }
}