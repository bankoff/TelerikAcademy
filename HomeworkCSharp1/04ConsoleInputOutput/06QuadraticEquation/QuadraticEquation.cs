// Write a program that reads the coefficients a, b and c of a quadratic 
// equation ax2+bx+c=0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Input coefficient \"a\" and then press Enter");
        Console.Write("a = ");
        string aStr = Console.ReadLine();
        double a = double.Parse(aStr);

        Console.WriteLine("Input coefficient \"b\" and then press Enter");
        Console.Write("b = ");
        string bStr = Console.ReadLine();
        double b = double.Parse(bStr);

        Console.WriteLine("Input coefficient \"c\" and then press Enter");
        Console.Write("c = ");
        string cStr = Console.ReadLine();
        double c = double.Parse(cStr);
        double d = (b * b) - (4 * a * c);
        if (d < 0)
        {
            Console.WriteLine("Equation do not have real roots");
        }
        else if (d == 0)
        {
            d = Math.Sqrt(d);
            double x = (-b + d) / (2*a);
            Console.WriteLine("Equation have 1 real root X = " + x);
        }
        else
	    {
            d = Math.Sqrt(d);
            double x1 = (-b + d) / (2 * a);
            double x2 = (-b - d) / (2 * a);
            Console.WriteLine("Equation have 2 real roots \nX1 = {0:0.000}   and   X2 = {1:0.000}", x1,x2);
	    }
    }
}
