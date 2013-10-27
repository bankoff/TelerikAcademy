//2.Implement a set of extension methods for IEnumerable<T> that implement the following 
//group functions: sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02IEnumerableExtension
{
    class TestIEnumerableExtension
    {
        static void Main()
        {
            //Two examples for sequences of different types
            int[] arrayOne = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] arrayTwo = { -5.3, -3.4, 1.5, 2.2, 3.6, 4.1, 5.5, 6.6, 7.6, 8.3, 9.5 };

            //Obtaining the Sum using FindSum extension method
            Console.WriteLine(arrayOne.FindSum());
            Console.WriteLine(arrayTwo.FindSum());

            //Obtaining the Product using FindProduct extension method
            Console.WriteLine(arrayOne.FindProduct());
            Console.WriteLine(arrayTwo.FindProduct());

            //Obtaining Min value in the sequence using FindMin extension method
            Console.WriteLine(arrayOne.FindMin());
            Console.WriteLine(arrayTwo.FindMin());

            //Obtaining Max value in the sequence using FindMin extension method
            Console.WriteLine(arrayOne.FindMax());
            Console.WriteLine(arrayTwo.FindMax());

            //Obtaining Average value in the sequence using FindAverage extension method
            Console.WriteLine(arrayOne.FindAverage());
            Console.WriteLine(arrayTwo.FindAverage());
        }
    }
}