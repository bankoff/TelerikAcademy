using System;

class DecimalToHexadecimalCycle
{
    static void Main()
    {
        Console.WriteLine("Enter the number that you want to convert to Hexadecimal ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("{0}=", n);
        ToHexadecimal(n);
        Console.ReadKey();
    }
    static void ToHexadecimal(int n)
    {
        if (n == 0)
            return;
        else
        {
            int r = n % 16;
            n = n / 16;
            ToHexadecimal(n);
            switch (r)
            {
                case 10:
                    Console.Write("A");
                    break;
                case 11:
                    Console.Write("B");
                    break;
                case 12:
                    Console.Write("C");
                    break;
                case 13:
                    Console.Write("D");
                    break;
                case 14:
                    Console.Write("E");
                    break;
                case 15:
                    Console.Write("F");
                    break;
                default:
                    Console.Write(r);
                    break;
            }

        }
    }

}
