// Which of the following values can be assigned to a variable of type float and 
// which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class CompareFloatAndDouble
{
    static void Main()
    {
        double variableA = 34.567839023d;
        float variableB = 12.345f;
        double variableC = 8923.1234857d;
        float variableD = 3456.091f;
        Console.WriteLine("variables {0} and {2} are double \r\nvariables {1} and {3} are float",
           variableA, variableB, variableC, variableD);
    }
}