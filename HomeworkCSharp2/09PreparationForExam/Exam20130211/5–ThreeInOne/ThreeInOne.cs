using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ThreeInOne
{
    static void Main()
    {
        FirstTask();
        SecondTask();
        ThirdTask();
    }

    private static void ThirdTask()
    {
        int[] money = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

        int G1 = money[0];
        int S1 = money[1];
        int B1 = money[2];
        int G2 = money[3];
        int S2 = money[4];
        int B2 = money[5];
        int step = 0;

        while (true)
        {
            if (B2 > B1 && S2 > S1 && G2 > G1)
            {
                Console.WriteLine(-1);
                return;
            }

            while (B2 > B1)
            {
                if (S1 > 0)
                {
                    step++;
                    S1--;
                    B1 = B1 + 9;
                }
                else if (G1 > 0 && G1 > G2)
                {
                    step++;
                    G1--;
                    S1 = S1 + 9;
                }
                else
                {
                    Console.WriteLine(-1);
                    return;
                }
            }

            while (S2 > S1)
            {
                if (G1 > 0 && G1 > G2)
                {
                    step++;
                    G1--;
                    S1 = S1 + 9;
                }
                else if (B1 >= B2 + 11)
                {
                    step++;
                    B1 = B1 - 11;
                    S1++;
                }
                else
                {
                    Console.WriteLine(-1);
                    return;
                }
            }

            while (G2 > G1)
            {
                if (S1 >= 11)
                {
                    step++;
                    S1 = S1 - 11;
                    G1++;
                }
                else if (B1 >= B2 + 11)
                {
                    step++;
                    B1 = B1 - 11;
                    S1++;
                }
                else
                {
                    Console.WriteLine(-1);
                    return;
                }
            }


            if (B1 >= B2 && S1 >= S2 && G1 >= G2)
            {
                Console.WriteLine(step);
                return;
            }
        }
    }

    private static void SecondTask()
    {
        int[] cakes = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
        int friends = int.Parse(Console.ReadLine());
        int myCakes = 0;
        Array.Sort(cakes, (a, b) => b - a);

        for (int i = 0; i < cakes.Length; i = i + friends + 1)
        {
            myCakes = myCakes + cakes[i];
        }

        Console.WriteLine(myCakes);
    }

    private static void FirstTask()
    {
        int[] points = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
        int maxPoints = 0;
        int player = -1;
        int count = 0;

        for (int i = 0; i < points.Length; i++)
        {
            if (points[i] <= 21)
            {
                if (points[i] > maxPoints)
                {
                    maxPoints = points[i];
                    player = i;
                    count = 1;
                }
                else if (points[i] == maxPoints)
                {
                    player = i;
                    count++;
                }
            }
        }
        if (count > 1)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(player);
        }
    }
}