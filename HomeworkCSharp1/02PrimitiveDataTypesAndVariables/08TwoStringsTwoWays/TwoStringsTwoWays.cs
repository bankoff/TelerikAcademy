// Declare two string variables and assign them with following value:
//      The "use" of quotations causes difficulties.
// Do the above in two different ways: with and without using quoted strings.

using System;

class TwoStringsTwoWays
{
    static void Main()
    {
        string firstWay = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(firstWay);
        string secondWay = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(secondWay);
    }
}