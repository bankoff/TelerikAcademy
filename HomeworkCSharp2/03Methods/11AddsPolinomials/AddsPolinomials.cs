//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5 -> { 5, 0, 1 }

using System;
using System.Text;

class AddsPolinomials
{
    static void Main()
    {
        decimal[] poli1 = { -6, 2, 5, 2 }; //2x^3+5x^2+2x-6
        decimal[] poli2 = { 0, -3, 4}; //4x^2-3x
        Console.WriteLine("First polinomial is:");
        Console.WriteLine(PrintPoli(poli1));
        Console.WriteLine("Second polinomial is:");
        Console.WriteLine(PrintPoli(poli2));
        Console.WriteLine("The sum - result is:");
        Console.WriteLine(PrintPoli(AddPolinomials(poli1, poli2)));
        Console.WriteLine();
    }

    static string PrintPoli(decimal[] polynomial)
    {
        StringBuilder returnString = new StringBuilder();

        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if (polynomial[i] != 0)
            {
                returnString.Append(polynomial[i] > 0 ? " + " : " - ");
                returnString.Append(Math.Abs(polynomial[i]));
                if (i != 0)
                {
                    returnString.Append(i > 1 ? "x^" + i : "x");
                }
            }
        }


        //delete extra characters at the beginning
        if (returnString[1] != '-')
        {
            returnString.Remove(0, 3);
        }
        else
        {
            returnString.Remove(0, 1);
        }

        return returnString.ToString();
    }

    static decimal[] AddPolinomials(decimal[] poli1, decimal[] poli2)
    {
        int maxLen = Math.Max(poli1.Length, poli2.Length);
        decimal[] result = new decimal[maxLen];
        for (int i = 0; i < poli1.Length; i++)
        {
            result[i] = poli1[i];
        }
        for (int i = 0; i < poli2.Length; i++)
        {
            result[i] += poli2[i];
        }
        return result;
    }
}