//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample" -> "elpmas".

using System;

class ReverseString
{
    static void Main()
    {
        Console.Write("Please enter text: ");
        string text = Console.ReadLine();
        char[] reversed = text.ToCharArray();
        Array.Reverse(reversed);

        Console.Write("\nThe reversed text is: ");

        Console.Write(reversed);
        Console.WriteLine("\n");
    }
}