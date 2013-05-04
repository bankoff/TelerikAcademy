// Declare an integer variable and assign it with the value 254 in hexadecimal format. 
// Use Windows Calculator to find its hexadecimal representation.

using System;

class DecimalInHexadecimal
{
    static void Main()
    {
        int value = 0xFE;
        Console.WriteLine("Number {0} in hexadecimal is {0:X}", value);
    }
}