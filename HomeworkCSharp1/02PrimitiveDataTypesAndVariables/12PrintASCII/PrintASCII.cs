// Find online more information about ASCII (American Standard Code 
// for Information Interchange) and write a program that prints the 
// entire ASCII table of characters on the console.

using System;
using System.Text;

class PrintASCII
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int counter;
        char character;
        {
            for (counter = 0; counter <= 255; counter++)
            {
                character = (char)counter;
                Console.WriteLine(character);
            }
        }
    }
}
