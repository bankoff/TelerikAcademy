using System;

class Sheets
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < 11; i++)
        {
            int bit = (number >> i) & 1;
            if (bit != 1)
            {
                Console.WriteLine("A{0}", 10 - i);
            }
        }
    }
}