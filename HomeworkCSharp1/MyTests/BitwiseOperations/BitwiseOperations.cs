using System;

class BitwiseOperations
{
    static void Main()
    {
        //Bitwise operators are used on integer numbers (byte, sbyte, int, uint, long, ulong)
        {
            ushort a = 3;                   // 00000000 00000011
            ushort b = 5;                   // 00000000 00000101
            Console.WriteLine(a | b);       // 00000000 00000111
            Console.WriteLine(a & b);       // 00000000 00000001
            Console.WriteLine(a ^ b);       // 00000000 00000110
            Console.WriteLine(~a & b);      // 00000000 00000100
            Console.WriteLine(a << 1);      // 00000000 00000110
            Console.WriteLine(a >> 1);      // 00000000 00000001
        }


        //How to get the bit at position p in a number n?
        {
            int p = 5;
            int n = 35;                     // 00000000 00100011
            int mask = 1 << p;              // 00000000 00100000
            int nAndMask = n & mask;        // 00000000 00100000
            int bit = nAndMask >> p;        // 00000000 00000001
            Console.WriteLine(bit);         // 1
        }


        //How to set the bit at position p to 0?
        {
            int p = 5;
            int n = 35;                 // 00000000 00100011
            int mask = ~(1 << p);       // 11111111 11011111
            int result = n & mask;      // 00000000 00000011
            Console.WriteLine(result);  // 3
        }


        //How to set the bit at position p to 1?
        {
            int p = 4;
            int n = 35;                 // 00000000 00100011
            int mask = 1 << p;          // 00000000 00010000
            int result = n | mask;      // 00000000 00110011
            Console.WriteLine(result);  // 51
        }


        //How to print a binary number to the console?
        {
            int result = 51;
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            // 00000000000000000000000000110011
        }
    }
}