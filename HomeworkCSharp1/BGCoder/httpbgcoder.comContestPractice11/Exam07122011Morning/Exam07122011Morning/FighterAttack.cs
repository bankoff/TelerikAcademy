using System;

class FighterAttack
{
    static void Main()
    {
        int pX1 = int.Parse(Console.ReadLine());
        int pY1 = int.Parse(Console.ReadLine());
        int pX2 = int.Parse(Console.ReadLine());
        int pY2 = int.Parse(Console.ReadLine());
        int fX = int.Parse(Console.ReadLine());
        int fY = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int damage = 0;

        int pXLeft = Math.Min(pX1, pX2);
        int pXRight = Math.Max(pX1, pX2);
        int pYDown = Math.Min(pY1, pY2);
        int pYUp = Math.Max(pY1, pY2);

        if (pXLeft <= (fX + distance) && (fX + distance) <= pXRight && pYDown <= fY && fY <= pYUp)
        {
            damage = damage + 100;
        }
        if (pXLeft <= (fX + distance + 1) && (fX + distance + 1) <= pXRight && pYDown <= fY && fY <= pYUp)
        {
            damage = damage + 75;
        }
        if (pXLeft <= (fX + distance) && (fX + distance) <= pXRight && pYDown <= (fY + 1) && (fY + 1) <= pYUp)
        {
            damage = damage + 50;
        }
        if (pXLeft <= (fX + distance) && (fX + distance) <= pXRight && pYDown <= (fY - 1) && (fY - 1) <= pYUp)
        {
            damage = damage + 50;
        }
        Console.WriteLine("{0}%", damage);
    }
}