// Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        bool hex;
        int decimalNumber;

        do
        {
            Console.Write("Please enter number in hexadecimal system to convert it to decimal: ");
            string strHexadecimal = Console.ReadLine();
            char[] reversed = strHexadecimal.ToUpper().ToCharArray();
            Array.Reverse(reversed);
            decimalNumber = 0;
            int digit = 0;
            hex = true;

            for (int position = reversed.Length - 1; position >= 0; position--)
            {
                switch (reversed[position])
                {
                    case '0': digit = 0; break;
                    case '1': digit = 1; break;
                    case '2': digit = 2; break;
                    case '3': digit = 3; break;
                    case '4': digit = 4; break;
                    case '5': digit = 5; break;
                    case '6': digit = 6; break;
                    case '7': digit = 7; break;
                    case '8': digit = 8; break;
                    case '9': digit = 9; break;
                    case 'A': digit = 10; break;
                    case 'B': digit = 11; break;
                    case 'C': digit = 12; break;
                    case 'D': digit = 13; break;
                    case 'E': digit = 14; break;
                    case 'F': digit = 15; break;
                    default:
                        {
                            Console.WriteLine("This is not a hexadecimal number.");
                            hex = false;
                            break;
                        }
                }
                decimalNumber = decimalNumber + (digit * ((int)Math.Pow(16, position)));
            }
        } while (!hex);

        Console.WriteLine("Your decimal number is: {0}", decimalNumber);
    }
}