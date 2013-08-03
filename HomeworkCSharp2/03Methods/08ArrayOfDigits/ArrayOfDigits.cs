//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;

class ArrayOfDigits
{
    static void Main()
    {
        Console.Write("Please enter first positive integer number:  ");
        string firstNumber = Console.ReadLine();
        int[] arr1 = new int[firstNumber.Length];
        for (int i = 0; i < firstNumber.Length; i++)
        {
            arr1[i]=int.Parse(firstNumber[firstNumber.Length-i-1].ToString());
        }
        Console.Write("Please enter second positive integer number: ");

        string secondNumber = Console.ReadLine();
        int[] arr2 = new int[secondNumber.Length];
        for (int i = 0; i < secondNumber.Length; i++)
        {
            arr2[i] = int.Parse(secondNumber[secondNumber.Length -i- 1].ToString());
        }

        PrintArray(SumDigits(arr1, arr2));
        Console.WriteLine();
    }
    static void PrintArray(List<int> sum)
    {
        Console.Write("The sum is: ");
        for (int i = 0; i < sum.Count; i++)
        {
            Console.Write(sum[i]);
        }
        Console.WriteLine();
    }

    static List<int> SumDigits(int[] arr1, int[] arr2)
    {
        var res = new List<int>();
        int carryOne = 0;
        int len = Math.Max(arr1.Length, arr2.Length);
        int firstAddend,secondAddend;
        for (int i = 0; i < len; i++)
        {
            if (arr1.Length>i)
            {
                firstAddend = arr1[i];
            }
            else
            {
                firstAddend = 0;
            }

            if (arr2.Length > i)
            {
                secondAddend = arr2[i];
            }
            else
            {
                secondAddend = 0;
            }

            res.Add((firstAddend + secondAddend + carryOne) % 10);
            carryOne = (firstAddend + secondAddend + carryOne) / 10;
        }
        if (carryOne==1)
        {
            res.Add(1);
        }

        res.Reverse();
        return res;
    }
}