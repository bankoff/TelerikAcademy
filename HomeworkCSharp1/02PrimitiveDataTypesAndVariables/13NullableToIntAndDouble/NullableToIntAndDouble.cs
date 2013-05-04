// Create a program that assigns null values to an integer and to double variables. 
// Try to print them on the console, try to add some values or the null literal to 
// them and see the result.

using System;

class NullableToIntAndDouble
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine("This is the integer with Null value:" + nullInt);
        Console.WriteLine("This is the double with Null value:" + nullDouble);
        nullInt = nullInt + null;
        nullDouble = nullDouble + null;
        Console.WriteLine("This is a integer with added null:" + nullInt);
        Console.WriteLine("This is a double with added null:" + nullDouble);
        nullInt = nullInt + 5;
        nullDouble = nullDouble + 5;
        Console.WriteLine("This is a integer with added value five:" + nullInt);
        Console.WriteLine("This is a double with added value five:" + nullDouble);
    }
}