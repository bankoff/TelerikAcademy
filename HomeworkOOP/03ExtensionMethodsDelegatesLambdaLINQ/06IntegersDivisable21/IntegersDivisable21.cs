//6.Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06IntegersDivisable21
{
    class IntegersDivisable21
    {
        static void Main()
        {
            List<int> intArr = new List<int> { 2, 65, 21, 55, -42, 210, 63, 18, -5, -23 };
            List<int> numDivisable21Lambda = new List<int>(intArr.FindAll(x => (x % 7) == 0 && (x % 3) == 0));
            Console.WriteLine("Found with lambda expression:");
            foreach (var number in numDivisable21Lambda)
            {
                Console.WriteLine(number + " ");
            }

            Console.WriteLine("Found with LINQ query:");
            var numDivisable21LINQ = from intNum in intArr
                                     where intNum % 7 == 0
                                     where intNum % 3 == 0
                                     select intNum;

            foreach (var number in numDivisable21LINQ)
            {
                Console.WriteLine(number + " ");
            }

        }
    }
}
