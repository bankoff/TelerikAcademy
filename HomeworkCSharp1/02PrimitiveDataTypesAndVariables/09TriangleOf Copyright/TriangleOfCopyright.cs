// Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
// Use Windows Character Map to find the Unicode code of the © symbol.
// Note: the © symbol may be displayed incorrectly.

using System;
using System.Text;

class TriangleOfCopyright
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int variable = 0x00A9;
        char variableChar = (char)variable;
        Console.WriteLine(@"
        {0} {0} {0}
        {0} {0}
        {0}", variableChar);
    }
}
