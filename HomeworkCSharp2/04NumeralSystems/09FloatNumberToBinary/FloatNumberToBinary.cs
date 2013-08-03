//Write a program that shows the internal binary representation of given 32-bit signed
//floating-point number in IEEE 754 format (the C# type float). 
//Example: -27,25 -> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

//http://www.h-schmidt.net/FloatConverter/
//http://en.wikipedia.org/wiki/Floating_point
//http://en.wikipedia.org/wiki/Single_precision
//http://en.wikipedia.org/wiki/Double-precision_floating-point_format
//http://www.introprogramming.info/intro-csharp-book/read-online/glava8-broini-sistemi/

using System;

class FloatNumberToBinary
{
    static void Main()
    {
        float number;
        do
        {
            Console.Write("Please enter floating-point number: ");
        } while (!float.TryParse(Console.ReadLine(), out number));

        //float number = -27.25f;
        long convertBitsOfNumber = BitConverter.DoubleToInt64Bits(number);
        long sign = 0;
        long mask = 1;
        string binaryRepresentation = "";
        string exponent = String.Empty;
        string mantisa = String.Empty;

        // check for the sign
        sign = ((convertBitsOfNumber >> 63) & mask);

        // just in case make the bit which show the sign to be 0 in that way the number will be positive with sure 
        convertBitsOfNumber = (convertBitsOfNumber & (~(mask << 63)));

        // take every bit from the number
        while (convertBitsOfNumber != 0)
        {
            binaryRepresentation = (convertBitsOfNumber & mask) + binaryRepresentation;
            convertBitsOfNumber = convertBitsOfNumber >> 1;
        }
        Console.WriteLine(binaryRepresentation);

        if (number > -2.0f && number < 2.0f)
        {
            exponent = "0";
            exponent += binaryRepresentation.Substring(3, 7);
            mantisa = binaryRepresentation.Substring(10, 23);
        }
        else
        {
            exponent = binaryRepresentation.Substring(0, 1);
            exponent += binaryRepresentation.Substring(4, 7);
            mantisa = binaryRepresentation.Substring(11, 23);
        }

        Console.Write(sign + " ");
        Console.Write(exponent + " ");
        Console.WriteLine(mantisa);
    }
}