using System;

class TrueInput
{
    static void Main()
    {
        int a = 0;
        Console.WriteLine("Input \"a\" and then press Enter");
        string aStr = Console.ReadLine();
        Console.Write("a = ");
        while (!int.TryParse(aStr, out a))  // (!int.TryParse(aStr, out a)) е едно и също с това (int.TryParse(aStr, out a) == false)
        {
            Console.WriteLine("Input отново \"a\" and then press Enter");
            Console.Write("a = ");
            aStr = Console.ReadLine();          
        }
        Console.WriteLine("a = " + a);
    }
}