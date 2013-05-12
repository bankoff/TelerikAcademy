//	Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Input a number and then press Enter");
        string numberStr = Console.ReadLine();
        int number = int.Parse(numberStr);
        // all odd numbers in their bitwise representation end with 1, all even - end with 0
        // if the number is even, it will end on zero and shifting will not change the number
        // if the number is odd, it will end on 1 and shifting will change it
        int assistNumber = number >> 1;
        assistNumber = assistNumber << 1;

        if (number == assistNumber)
        {
            Console.WriteLine("The number {0} is even.", number);  
        }
        else
        {
            Console.WriteLine("The number {0} is odd.", number);
        }
    }
}