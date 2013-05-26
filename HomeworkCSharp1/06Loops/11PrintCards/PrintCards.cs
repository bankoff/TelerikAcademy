/*  Write a program that prints all possible cards from a standard deck 
 *  of 52 cards (without jokers). The cards should be printed with their 
 *  English names. Use nested for loops and switch-case.
 */

using System;

class PrintCards
{
    static void Main()
    {
        string[] faceValue = new string[]{"Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten",
            "Jack","Queen","King","Ace"};
        for (int faceIndex = 0; faceIndex < faceValue.Length; faceIndex++)
        {
            for (int suitIndex = 1; suitIndex <= 4; suitIndex++)
            {
                switch (suitIndex)
                {
                    case 1:
                        {
                            Console.WriteLine("{0} of clubs",faceValue[faceIndex]);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("{0} of diamonds", faceValue[faceIndex]);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("{0} of hearts", faceValue[faceIndex]);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("{0} of spades", faceValue[faceIndex]);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
