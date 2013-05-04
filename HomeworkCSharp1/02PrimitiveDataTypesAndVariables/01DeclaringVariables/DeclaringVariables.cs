// Declare five variables choosing for each of them the most appropriate of the  
// types byte, sbyte, short, ushort, int, uint, long, ulong to represent the 
// following values: 52130, -115, 4825932, 97, -10000.

using System;


class DeclaringVariables
{
    static void Main()
    {
        ushort variableA = 52130;
        sbyte variableB = -115;
        int variableC = 4825932;
        byte variableD = 97;
        short variableE = -10000;
        Console.WriteLine("{0} \r\n{1} \r\n{2} \r\n{3} \r\n{4}",
            variableA, variableB, variableC, variableD, variableE);
    }
}