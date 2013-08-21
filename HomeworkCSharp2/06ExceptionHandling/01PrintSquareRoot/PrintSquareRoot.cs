//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". In all cases finally 
//print "Good bye". Use try-catch-finally.

using System;

class PrintSquareRoot
{
    static void Main()
    {
        Console.Write("Please enter integer number to calculates its square root: ");
        string numberString = Console.ReadLine();
        SquareRoot(numberString);
    }

    static void SquareRoot(string numberString)
    {
        try
        {
            int number = int.Parse(numberString);
            if (number < 0)
            {
                throw new FormatException();
            }
            Console.WriteLine(Math.Sqrt(number));
        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid number! ");
        }

        catch (OverflowException)
        {
            Console.WriteLine("Invalid number! ");
        }

        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid number! ");
        }

        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}