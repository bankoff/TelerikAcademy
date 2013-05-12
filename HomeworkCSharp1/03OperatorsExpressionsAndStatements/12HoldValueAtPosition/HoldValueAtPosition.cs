/* We are given integer number n, value v (v=0 or 1) and a position p. 
 * Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
 * at the position p from the binary representation of n.
 * Example: 
 * n = 5 (00000101), p=3, v=1 -> 13 (00001101)
 * n = 5 (00000101), p=2, v=0 -> 1 (00000001)
 */

using System;

class HoldValueAtPosition
{
    static void Main()
    {
        Console.WriteLine("Input one integer and then press Enter");
        Console.Write("n = ");
        string nStr = Console.ReadLine();
        int n = int.Parse(nStr);
        Console.WriteLine("Input one position of 0 to 31 and then press Enter");
        Console.Write("p = ");
        string pStr = Console.ReadLine();
        int p = int.Parse(pStr);
        Console.WriteLine("Input 0 or 1 and then press Enter");
        Console.Write("v = ");
        string vStr = Console.ReadLine();
        int v = int.Parse(vStr);
        Console.WriteLine("The binary representation of " + n + " is " + 
            Convert.ToString(n, 2).PadLeft(32, '0'));
        int result;
        if (v == 0)
        //Set the bit at position p to 0
        {
            int mask = ~(1 << p);       
            result = n & mask;      
        }
        else
        //Set the bit at position p to 1
        {
            int mask = 1 << p;          
            result = n | mask;      
        }
        Console.WriteLine("The result is " + result + " with binary representation " + 
            Convert.ToString(result, 2).PadLeft(32, '0'));  
    }
}
