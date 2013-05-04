// Declare a character variable and assign it with the symbol that has Unicode code 72.
// Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

class DeclareCharacter
{
    static void Main()
    {
        int variable = 0x48;
        char variableChar = (char)variable;
        Console.WriteLine("On Unicode code {0:X} correspond symbol {1}", variable, variableChar);
    }
}