// Write a program that exchanges bits {p, p+1, …, p+k-1) with
// bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;

class ExchangeBitsPQK
{
    static void Main()
    {
        Console.WriteLine("Input one integer and then press Enter");
        Console.Write("integer = ");
        string integerStr = Console.ReadLine();
        int integer = int.Parse(integerStr);

        Console.WriteLine("Input one position at 0 to 31 for bit \"p\" and then press Enter");
        Console.Write("p = ");
        string pStr = Console.ReadLine();
        int p = int.Parse(pStr);

        Console.WriteLine("Input one position at 0 to 31 for bit \"q\" and then press Enter");
        Console.Write("q = ");
        string qStr = Console.ReadLine();
        int q = int.Parse(qStr);

        int kMax = (p > q) ? (31 - p) : (31 - q);

        Console.WriteLine("Input number (at 0 to {0}) of bits \"k\" for changing and then press Enter", kMax);
        Console.Write("k = ");
        string kStr = Console.ReadLine();
        int k = int.Parse(kStr);

        int result = integer;

        Console.WriteLine(Convert.ToString(integer, 2).PadLeft(32, '0') + " - this is binary representation of {0}", integer);

        for (int counter = 0; counter < k; counter++)
        {
            int assistP = result;
            int assistR = result;
            int pBit = ((assistP >> (p + counter)) & 1); // get bit p
            int qBit = ((assistR >> (q + counter)) & 1); // get bit q
            int reverseBit = pBit;
            pBit = qBit;
            qBit = reverseBit;

            if (pBit == 0)
            //Set the bit at position p to 0
            {
                int mask = ~(1 << (p + counter));
                result = result & mask;
            }
            else
            //Set the bit at position p to 1
            {
                int mask = 1 << (p + counter);
                result = result | mask;
            }

            if (qBit == 0)
            //Set the bit at position q to 0
            {
                int mask = ~(1 << (q + counter));
                result = result & mask;
            }
            else
            //Set the bit at position q to 1
            {
                int mask = 1 << (q + counter);
                result = result | mask;
            }
        }
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0') + " - this is binary result");
    }
}