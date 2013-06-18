using System;
using System.Numerics;

class Program
{ 
    static void Main() 
    { 
        int n = int.Parse(Console.ReadLine()); 
        BigInteger index = 0; 
        BigInteger sumIndex = 0; 
        for (int line = n-1 ; line >= 0; line--) 
        { 
            char letter = char.Parse(Console.ReadLine());
            index = (letter - 'A' + 1) * (BigInteger)Math.Pow(26, line); 
            sumIndex += index; 
        } 
        Console.WriteLine(sumIndex); 
    } 
}
