// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class PrintSequence
{
    static void Main()
    {
        int member, counter, sign;
        sign = 1;
        {
            for (counter = 0; counter < 10; counter = counter + 1)
            {
                member = (counter + 2) * sign;
                Console.WriteLine(member);
                sign = sign * (-1);
            }
        }
    }
}