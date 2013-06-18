using System;

class Poker
{
    static void Main()
    {
        string[] card = new string[5];
        int[] cardNumber = new int[6];
        int pair = 0;
        bool request = false;

        for (int i = 0; i < 5; i++)
        {
            card[i] = Console.ReadLine();
            if (card[i] == "J")
            {
                cardNumber[i] = 11;
            }
            else if (card[i] == "Q")
            {
                cardNumber[i] = 12;
            }
            else if (card[i] == "K")
            {
                cardNumber[i] = 13;
            }
            else if (card[i] == "A")
            {
                cardNumber[i] = 14;
            }
            else
            {
                cardNumber[i] = int.Parse(card[i]);
            }
        }
        Array.Sort(cardNumber);

        if (cardNumber[1] == cardNumber[2])
        {
            pair++;
        }
        if (cardNumber[2] == cardNumber[3])
        {
            pair++;
        }
        if (cardNumber[3] == cardNumber[4])
        {
            pair++;
        }
        if (cardNumber[4] == cardNumber[5])
        {
            pair++;
        }


        switch (pair)
        {
            case 4:
                {
                    Console.WriteLine("Impossible");
                    break;
                }
            case 3:
                {
                    if ((cardNumber[1] == cardNumber[4]) || (cardNumber[2] == cardNumber[5]))
                    {
                        Console.WriteLine("Four of a Kind");
                    }
                    else
                    {
                        Console.WriteLine("Full House");
                    }
                    break;
                }
            case 2:
                {
                    if ((cardNumber[1] == cardNumber[3]) || (cardNumber[2] == cardNumber[4]) || (cardNumber[3] == cardNumber[5]))
                    {
                        Console.WriteLine("Three of a Kind");
                    }
                    else
                    {
                        Console.WriteLine("Two Pairs");    
                    }
                    break;
                }
            case 1:
                {
                    Console.WriteLine("One Pair");
                }
                break;
            default:
                {
                    if (cardNumber[5] == 14)
                    {
                        cardNumber[0] = 1;
                        request = true;
                    }
                    if ((cardNumber[5] - cardNumber[1] == 4) ||
                        (request && (cardNumber[4] - cardNumber[0] == 4)))
                    {
                        Console.WriteLine("Straight");
                    }
                    else
                    {
                        Console.WriteLine("Nothing");
                    }
                }
                break;
        }
    }
}



        //if (cardNumber[1] == cardNumber[2] &&
        //    cardNumber[1] == cardNumber[3] &&
        //    cardNumber[1] == cardNumber[4] &&
        //    cardNumber[1] == cardNumber[5])
        //{
        //    Console.WriteLine("Impossible");
        //}
        //else if ((cardNumber[1] == cardNumber[2] && cardNumber[1] == cardNumber[3] && cardNumber[1] == cardNumber[4]) ||
        //    (cardNumber[2] == cardNumber[3] && cardNumber[2] == cardNumber[4] && cardNumber[2] == cardNumber[5]))
        //{
        //    Console.WriteLine("Four of a Kind");
        //}
        //else if ((cardNumber[1] == cardNumber[2] && cardNumber[1] == cardNumber[3] && cardNumber[4] == cardNumber[5]) ||
        //    (cardNumber[1] == cardNumber[2] && cardNumber[3] == cardNumber[4] && cardNumber[3] == cardNumber[5]))
        //{
        //    Console.WriteLine("Full House");
        //}
        //else if ((cardNumber[1] == cardNumber[2] && cardNumber[1] == cardNumber[3]) ||
        //    (cardNumber[2] == cardNumber[3] && cardNumber[2] == cardNumber[4]) ||
        //    (cardNumber[3] == cardNumber[4] && cardNumber[3] == cardNumber[5]))
        //{
        //    Console.WriteLine("Three of a Kind");
        //}
        //else if (cardNumber[1] == cardNumber[2])
        //{
        //    pair++;
        //}
        //else if (cardNumber[2] == cardNumber[3])
        //{
        //    pair++;
        //}
        //else if (cardNumber[3] == cardNumber[4])
        //{
        //    pair++;
        //}
        //else if (cardNumber[4] == cardNumber[5])
        //{
        //    pair++;
        //}
        //else if (pair == 2)
        //{
        //    Console.WriteLine("Two Pairs");
        //}
        //else if (pair == 1)
        //{
        //    Console.WriteLine("One Pair");
        //}
        //else
        //{
        //    if (cardNumber[5] == 14)
        //    {
        //        cardNumber[0] = 1;
        //        request = true;
        //    }
        //    if ((cardNumber[5] - cardNumber[1] == 4) ||
        //        (request && (cardNumber[4] - cardNumber[0] == 4)))
        //    {
        //        Console.WriteLine("Straight");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Nothing");
        //    }
        //}
    //}
//}