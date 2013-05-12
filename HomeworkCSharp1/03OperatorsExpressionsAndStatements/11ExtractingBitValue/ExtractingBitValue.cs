// Write an expression that extracts from a given integer i 
// the value of a given bit number b. 
// Example: i=5; b=2 -> value=1.

using System;

class ExtractingBitValue
{
    static void Main()
    {
        Console.WriteLine("Input one integer and then press Enter");
        string iStr = Console.ReadLine();
        int i = int.Parse(iStr);
        Console.WriteLine("Input one position of 0 to 31 and then press Enter");
        string bStr = Console.ReadLine();
        int b = int.Parse(bStr);
        Console.WriteLine("The binary number of " + i + " is " + Convert.ToString(i, 2).PadLeft(32, '0'));
        i = i >> b;
        int mask = 1;
        int bit = i & mask;
        Console.WriteLine("i = {0}; b = {1} -> value = {2}", iStr, b, bit);
    }
}