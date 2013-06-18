using System;

class ExchangesBits
{
    static void Main()
    {
        int n = 35;
        int p = 3;
        int q = 24;
        int k = 3;
        int result = n;
 
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0') + " - this is binary number of {0}",n);
   
        for (int counter = 0; counter < k; counter++)
        {
            int np = result;
            int nq = result;
            int pBit = ((np >> (p + counter)) & 1); // get bit p
            int qBit = ((nq >> (q + counter)) & 1); // get bit q
            int reverseBit = pBit;
            pBit = qBit;
            qBit = reverseBit;

            if (pBit == 0)
            //Set the bit at position p to 0
            {
                int mask = ~(1 << (p+counter));
                result = result & mask;
            }
            else
            //Set the bit at position p to 1
            {
                int mask = 1 << (p+counter);
                result = result | mask;
            }

            if (qBit == 0)
            //Set the bit at position q to 0
            {
                int mask = ~(1 << (q+counter));
                result = result & mask;
            }
            else
            //Set the bit at position q to 1
            {
                int mask = 1 << (q+counter);
                result = result | mask;
            }
        }
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0') + " - this is binary result");
    }
}