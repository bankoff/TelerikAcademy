//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. 
//Example: string = "43 68 9 23 318" -> result = 461

using System;

class StringToSumOfInt
{
    static void Main()
    {
        string sequenceOfIntegers = "43 68 9 23 318";
        //string sequenceOfIntegers = "35 16 233 17 8 23";
        Console.WriteLine(sequenceOfIntegers);
        Console.WriteLine("result={0}", CalculateSum(sequenceOfIntegers));
    }
    static int CalculateSum(string sequenceOfIntegers)
    {
        string[] array = sequenceOfIntegers.Split(' ');
        int sumOfintegers = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sumOfintegers = sumOfintegers + int.Parse(array[i].Trim());
        }
        return sumOfintegers;
    }
}