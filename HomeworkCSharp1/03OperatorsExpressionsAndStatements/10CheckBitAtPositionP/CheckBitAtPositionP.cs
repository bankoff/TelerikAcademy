// Write a boolean expression that returns if the bit at position p 
// (counting from 0) in a given integer number v has value of 1. 
// Example: v=5; p=1 -> false.

using System;

class CheckBitAtPositionP
{
    static void Main()
    {
        Console.WriteLine("Input one integer and then press Enter");
        string vStr = Console.ReadLine();
        int v = int.Parse(vStr);
        Console.WriteLine("Input one position of 0 to 31 and then press Enter");
        string pStr = Console.ReadLine();
        int p = int.Parse(pStr);
        Console.WriteLine("The binary number of " + v + " is " + Convert.ToString(v, 2).PadLeft(32, '0'));
        v = v >> p;
        int mask = 1;
        bool boolPosition = (v & mask) == 1;
        Console.WriteLine("v = {0}; p = {1} -> {2}", vStr, p, boolPosition);
    }
}