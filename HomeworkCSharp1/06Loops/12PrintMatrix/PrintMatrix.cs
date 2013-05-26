/*  Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
 * 
 *      N = 3           N = 4
 *      1 2 3           1 2 3 4
 *      2 3 4           2 3 4 5
 *      3 4 5           3 4 5 6
 *                      4 5 6 7
 */

using System;

class PrintMatrix
{
    static void Main()
    {
        Console.WriteLine("Input size of matrix N (N<20)");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int row = 1; row <= n; row++)
        {
            for (int number = row; number < (row+n); number++)
            {
                Console.Write("{0,3}",number); 
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
