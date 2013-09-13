using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class OneTaskIsNotEnough
{
    static string Bound(string command)
    {
        int comList = command.Length;
        string direction = "Up";
        int coordX = 0;
        int coordY = 0;
        int allCommand = 4 * comList;

        for (int i = 0; i <= 2500; i++)
        {
            int commandNumber = i % comList;
            if (command[commandNumber] == 'L')
            {
                switch (direction)
                {
                    case "Up": direction = "Left"; break;
                    case "Left": direction = "Down"; break;
                    case "Down": direction = "Right"; break;
                    case "Right": direction = "Up"; break;
                }
            }
            else if (command[commandNumber] == 'R')
            {
                switch (direction)
                {
                    case "Up": direction = "Right"; break;
                    case "Left": direction = "Up"; break;
                    case "Down": direction = "Left"; break;
                    case "Right": direction = "Down"; break;
                }
            }
            else
            {
                switch (direction)
                {
                    case "Up": coordX++; break;
                    case "Left": coordY--; break;
                    case "Down": coordX--; break;
                    case "Right": coordY++; break;
                }
            }

            if (coordX == 0 & coordY == 0)
            {
                return "bounded";
            }
            else if (commandNumber == comList - 1 & direction == "Up")
            {
                return "unbounded";
            }
        }
        return "unbounded";
    }

    static int LastLamp(int lamps)
    {
        List<int> LampOffOld = new List<int>(lamps);
        List<int> LampOffNew = new List<int>(lamps);
        int step = 2;
        int lastLamp = 0;


        for (int i = 0; i < lamps; i++)
        {
            LampOffOld.Add(i+1);
        }

        while (LampOffOld.Count > 0)
        {
            for (int i = 0; i < LampOffOld.Count; i++)
            {
                if (i % step == 0)
                {
                    lastLamp = LampOffOld[i];
                }
                else
                {
                    LampOffNew.Add(LampOffOld[i]);
                }
            }
            //LampOffOld.Clear();
            LampOffOld = new List<int>(LampOffNew);
            LampOffNew.Clear();
            step++;
        }

        return lastLamp;




        //bool[] lampNumber = new bool[lamps + 1];
        //lampNumber[0] = true;
        //int startNumber = 1;

        //int step = 2;
        //int lastLamp = 0;

        //while (true)
        //{
        //    int count = 1;
        //    lampNumber[startNumber] = true;
        //    lastLamp = startNumber;

        //    for (int i = startNumber; i <= lamps; i++)
        //    {
        //        if (!lampNumber[i])
        //        {
        //            count++;

        //            if ((count - 1) % step == 0)
        //            {
        //                lampNumber[i] = true;
        //                lastLamp = i;
        //            }
        //        }
        //    }

        //    bool allLampOn = true;
        //    for (int i = startNumber; i <= lamps; i++)
        //    {
        //        if (!lampNumber[i])
        //        {
        //            startNumber = i;
        //            allLampOn = false;
        //            break;
        //        }
        //    }

        //    step++;
        //    if (allLampOn)
        //    {
        //        break;
        //    }
        //}
        //return 0;
    }

    static void Main()
    {
        int lamps = int.Parse(Console.ReadLine());
        Console.WriteLine(LastLamp(lamps));

        string commandsOne = Console.ReadLine();
        string commandsTwo = Console.ReadLine();
        Console.WriteLine(Bound(commandsOne));
        Console.WriteLine(Bound(commandsTwo));
        //Console.WriteLine("bounded");
        //Console.WriteLine("bounded");
    }
}