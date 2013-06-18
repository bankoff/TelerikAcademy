using System;

class ShipDamage
{
    static void Main()
    {
        int sX1 = int.Parse(Console.ReadLine());
        int sY1 = int.Parse(Console.ReadLine());
        int sX2 = int.Parse(Console.ReadLine());
        int sY2 = int.Parse(Console.ReadLine());

        int offsetH = int.Parse(Console.ReadLine());

        int ships = 3;
        int[] cX = new int[ships];
        int[] cY = new int[ships];

        int result = 0;

        for (int i = 0; i < ships; i++)
        {
            cX[i] = int.Parse(Console.ReadLine());
            cY[i] = int.Parse(Console.ReadLine());
        }

        int sXRight = Math.Max(sX1, sX2);
        int sXLeft = Math.Min(sX1, sX2);
        int sYUp = Math.Max(sY1, sY2);
        int sYDown = Math.Min(sY1, sY2);

        for (int i = 0; i < ships; i++)
        {
            cY[i] = 2 * offsetH - cY[i];
        }

        for (int i = 0; i < ships; i++)
        {
            if (sXLeft <= cX[i] && cX[i] <= sXRight && sYDown <= cY[i] && cY[i] <= sYUp)
            {
                if (((cX[i] == sXLeft) || (cX[i] == sXRight)) &&
                    ((cY[i] == sYDown) || (cY[i] == sYUp)))
                {
                    result = result + 25;
                }
                else if ((cX[i] == sXLeft) || (cX[i] == sXRight) ||
                    (cY[i] == sYDown) || (cY[i] == sYUp))
                {
                    result = result + 50;
                }
                else
                {
                    result = result + 100;
                }
            }
        }
        Console.WriteLine("{0}%",result);
    }
}