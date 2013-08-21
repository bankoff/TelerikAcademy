//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. Using this 
//method write a program that enters 10 numbers:
//            a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class CheckIntegerInRange
{
    public static int number;

    static void Main()
    {
        int countNumbers = 10;
        int start = 1;
        int end = 100;
        number = start;
        Console.WriteLine("Please enter 10 integer numbers:");
        for (int i = 0; i < countNumbers; i++)
        {
            // the start number is replaced by the entered number
            // the entered number is public static variable
            ReadNumber(number, end);
        }
    }

    static void ReadNumber(int start, int end)
    {
        try
        {
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber <= start || inputNumber >= end)
            {
                throw new ArgumentOutOfRangeException();
            }
            number = inputNumber;
            Console.WriteLine("The number {0} is VALID.",number);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number is not in the range ({0};100)",start); 
        }
        catch (FormatException)
        {
            Console.WriteLine("The number is not in valid format!"); 
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too big !");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("You have entered nothing!");
        }
    }
}