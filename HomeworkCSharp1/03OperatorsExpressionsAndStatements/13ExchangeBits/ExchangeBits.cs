// Write a program that exchanges bits 3, 4 and 5 with 
// bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static void Main()
    {
        Console.WriteLine("Input one integer and then press Enter");
        Console.Write("integer = ");
        string integerStr = Console.ReadLine();
        int integer = int.Parse(integerStr);

        int firstBit3 = 3;
        int firstBit24 = 24;
        int bitsForChanging = 3;
        int result = integer;

        Console.WriteLine("The binary representation of {0} is \n" + Convert.ToString(integer, 2).PadLeft(32, '0'), integer);

        for (int counter = 0; counter < bitsForChanging; counter++)
        {
            int np = result;
            int nq = result;
            int pBit = ((np >> (firstBit3 + counter)) & 1); // get bit p
            int qBit = ((nq >> (firstBit24 + counter)) & 1); // get bit q
            int reverseBit = pBit;
            pBit = qBit;
            qBit = reverseBit;

            if (pBit == 0)
            //Set the bit at position p to 0
            {
                int mask = ~(1 << (firstBit3 + counter));
                result = result & mask;
            }
            else
            //Set the bit at position p to 1
            {
                int mask = 1 << (firstBit3 + counter);
                result = result | mask;
            }

            if (qBit == 0)
            //Set the bit at position q to 0
            {
                int mask = ~(1 << (firstBit24 + counter));
                result = result & mask;
            }
            else
            //Set the bit at position q to 1
            {
                int mask = 1 << (firstBit24 + counter);
                result = result | mask;
            }
        }
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0') + " -is the result after bits exchanges", result);
    }
}