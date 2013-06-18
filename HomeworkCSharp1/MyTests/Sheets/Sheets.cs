using System;

class Sheets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < 11; i++)
        {
            int mask = 1;
            mask <<= i;

            if ((n & mask) == 0)
            {
                Console.WriteLine("A{0}", 10 - i);
            }
        }
    }
}

