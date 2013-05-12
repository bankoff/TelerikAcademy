// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class FindThirdBit
{
    static void Main()
    {
        int position = 3;
        Console.WriteLine("Input one integer and then press Enter");
        string integerStr = Console.ReadLine();
        int integer = int.Parse(integerStr);
        Console.WriteLine("The binary representation of " + integer + " is " + Convert.ToString(integer, 2).PadLeft(32, '0'));
        integer = integer >> position;
        int mask = 1;
        int bit = integer & mask;
        Console.WriteLine("The third bit counting from zero is {0}", bit);
    }
}
