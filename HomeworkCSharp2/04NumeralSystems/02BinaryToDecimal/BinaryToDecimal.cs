// Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        bool binary;
        int decimalNumber;
        do
        {
            binary = true;
            Console.Write("Please enter number in binary system to convert it to decimal: ");
            string strBinaryNumber = Console.ReadLine();
            char[] reversed = strBinaryNumber.ToCharArray();
            Array.Reverse(reversed);
            decimalNumber = 0;

            for (int position = reversed.Length - 1; position >= 0; position--)
            {
                if (!((reversed[position]) == '1' || (reversed[position]) == '0'))
                {
                    Console.WriteLine("This is not a binary number.");
                    binary = false;
                    break;
                }
                else if ((reversed[position]) == '1')
                {
                    decimalNumber = decimalNumber + ((int)Math.Pow(2, position));
                }
            }
        } while (!binary);

        Console.WriteLine("Your decimal number is: {0}", decimalNumber);
    }
}