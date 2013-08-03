//Extend the program 11 to support also subtraction and multiplication of polynomials.

using System;
using System.Text;

class AddSubstractAndMultiply
{
    static void Main()
    {
        decimal[] poli1 = new decimal[] { 3, 2, -4 };
        decimal[] poli2 = new decimal[] { 7, -1, 5 };

        Console.WriteLine("First polynomial: ".PadLeft(30, ' ') + PrintPoli(poli1));
        Console.WriteLine("Second polynomial: ".PadLeft(30, ' ') + PrintPoli(poli2));


        decimal[] sum = AddPolinomials(poli1, poli2);
        Console.WriteLine("\n" + "Sum: ".PadLeft(30, ' ') + PrintPoli(sum));


        decimal[] substr = SubstractPoli(poli1, poli2);
        Console.WriteLine("\n" + "Substraction: ".PadLeft(30, ' ') + PrintPoli(substr));


        decimal[] multiply = MultiplyPoly(poli1, poli2);
        Console.WriteLine("\n" + "Multiplication: ".PadLeft(30, ' ') + PrintPoli(multiply));
    }

    static decimal[] MultiplyPoly(decimal[] poli1, decimal[] poli2)
    {
        decimal[] result = new decimal[poli1.Length + poli2.Length];

        for (int i = 0; i < poli1.Length; i++)
        {
            for (int y = 0; y < poli2.Length; y++)
            {
                result[i + y] = result[i + y] + poli1[i] * poli2[y];
            }
        }

        return result;
    }

    static decimal[] SubstractPoli(decimal[] poli1, decimal[] poli2)
    {
        decimal[] newPolynomial = new decimal[Math.Max(poli1.Length, poli2.Length)];

        for (int i = 0; i < poli1.Length; i++)
        {
            newPolynomial[i] = poli1[i];
        }

        for (int i = 0; i < poli2.Length; i++)
        {
            newPolynomial[i] = newPolynomial[i] - poli2[i];
        }

        return newPolynomial;
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
            returnString.Remove(0, 2);
            returnString.Insert(0, "  ");
        }

        return returnString.ToString();
    }
}
